using System;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;
using Solnet.Rpc;
using Solnet.Wallet;
using Solnet.Wallet.Utilities;
using Solnet.Rpc.Core.Http;
using Solnet.Rpc.Builders;

class Program
{
    private static readonly string privateKey = Environment.GetEnvironmentVariable("PRIVATE_KEY");
    private static readonly IRpcClient rpcClient = ClientFactory.GetClient(Cluster.MainNet);

    static async Task Main(string[] args)
    { 
        if (string.IsNullOrEmpty(privateKey))
        {
            throw new InvalidOperationException("Private key is not set in the environment variables.");
        }

        string arweaveUri = await UploadToArweaveAsync("path/to/image.png");

        var metadata = new
        {
            name = "MyNFT",
            symbol = "MNFT",
            description = "My awesome NFT!",
            image = arweaveUri,
        };

        var latestBlockhash = await rpcClient.GetRecentBlockHashAsync();
        var transactionBuilder = new TransactionBuilder()
            .SetRecentBlockHash(latestBlockhash.Result.Value.Blockhash)
            .SetFeePayer(new PublicKey(privateKey));

        var transaction = transactionBuilder.Build(new Wallet(privateKey).Account);

        // Sign the transaction
        var wallet = new Wallet(privateKey);
        var signedTransaction = wallet.Account.Sign(transaction);

        var result = await rpcClient.SendTransactionAsync(signedTransaction);
        Console.WriteLine(result);
    }

    private static async Task<string> UploadToArweaveAsync(string filePath)
    {
        using (var httpClient = new HttpClient())
        {
            byte[] fileBytes = await File.ReadAllBytesAsync(filePath);
            string fileBase64 = Convert.ToBase64String(fileBytes);

            var content = new JObject
            {
                { "data", fileBase64 }
            };

            var httpContent = new StringContent(content.ToString(), Encoding.UTF8, "application/json");
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            // Add your Arweave wallet key to the request headers
            string arweaveKey = Environment.GetEnvironmentVariable("d");
            if (string.IsNullOrEmpty(arweaveKey))
            {
                throw new InvalidOperationException("Arweave key is not set in the environment variables.");
            }
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {arweaveKey}");

            HttpResponseMessage response = await httpClient.PostAsync("https://arweave.net", httpContent);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            var jsonResponse = JObject.Parse(responseBody);

            if (jsonResponse["uri"] == null)
            {
                throw new InvalidOperationException("The response does not contain a 'uri' field.");
            }

            return jsonResponse["uri"].ToString();
        }
    }
}