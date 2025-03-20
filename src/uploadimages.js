
import * as fs from 'fs';
import Arweave from 'arweave';


(async () => {

    const arweave = Arweave.init({
        host: 'arweave.net',
        port: 443,
        protocol: 'https',
        timeout: 20000,
        logging: false,
    });

    // Upload image to Arweave
    const data = fs.readFileSync('./ape-punk.png');
    
    const transaction = await arweave.createTransaction({
        data: data
    });

    
    transaction.addTag('Content-Type', 'image/png');

    await arweave.transactions.sign(transaction, "Arweave WALLET JSON without ext:true");
    

    const response = await arweave.transactions.post(transaction);
    
    console.log(response);

    const imageUrl = transaction.id ? `https://arweave.net/${transaction.id}` : undefined;

    console.log(imageUrl);
    
})();
