using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Shapes;
using System;
using Uno.Toolkit.UI;

namespace Untitled;

public partial class Frame : Page
{
	public Frame()
	{
		this
			.Background(Theme.Brushes.Background.Default)
			.Content
			(
				new AutoLayout()
					.CornerRadius(8)
					.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
					.CounterAxisAlignment(AutoLayoutAlignment.Center)
					.Children
					(
						new AutoLayout()
							.CornerRadius(8)
							.CounterAxisAlignment(AutoLayoutAlignment.Start)
							.Width(1440)
							.Height(1440)
							.Children
							(
								new AutoLayout()
									.CounterAxisAlignment(AutoLayoutAlignment.Start)
									.Width(1440)
									.Height(1440)
									.AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
									.Children
									(
										new AutoLayout()
											.CounterAxisAlignment(AutoLayoutAlignment.Start)
											.Width(1440)
											.AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
											.Children
											(
												new AutoLayout()
													.CounterAxisAlignment(AutoLayoutAlignment.Start)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(720)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new AutoLayout()
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(64,234,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(592)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																			.CounterAxisAlignment(AutoLayoutAlignment.Center)
																			.Orientation(Orientation.Horizontal)
																			.Margin(0,2,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(45)
																			.Height(36)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new Path()
																					.Data("F1 M 12.044531464576721 4.5 L 15.75 4.5 L 15.75 11.25 L 7.825781464576721 11.25 L 9.963281035423279 5.913281142711639 C 10.300781048834324 5.062499865889549 11.123437687754631 4.5 12.044531464576721 4.5 Z M 19.125 11.25 L 19.125 4.5 L 24.834375858306885 4.5 C 25.51640709489584 4.5 26.163282115012407 4.8093750067055225 26.592188358306885 5.34375 L 31.317187070846558 11.25 L 19.125 11.25 Z M 37.139063358306885 11.3203125 L 30.107813358306885 2.53125 C 28.828125804662704 0.9281250536441803 26.887500911951065 0 24.834375858306885 0 L 12.044531464576721 0 C 9.281250268220901 0 6.799218535423279 1.6804688572883606 5.779687285423279 4.239843964576721 L 2.8546873927116394 11.559374570846558 C 1.1812499463558197 12.220312044024467 0 13.84453122317791 0 15.75 L 0 23.625 C 0 24.86953130364418 1.0054686963558197 25.875 2.25 25.875 L 4.591406464576721 25.875 C 5.125781457871199 29.06718760728836 7.903125107288361 31.5 11.25 31.5 C 14.59687489271164 31.5 17.3742185421288 29.06718760728836 17.90859353542328 25.875 L 27.091405391693115 25.875 C 27.625780384987593 29.06718760728836 30.40312510728836 31.5 33.75 31.5 C 37.09687489271164 31.5 39.87421961501241 29.06718760728836 40.408594608306885 25.875 L 42.75 25.875 C 43.99453130364418 25.875 45 24.86953130364418 45 23.625 L 45 20.25 C 45 15.665625214576721 41.568750858306885 11.8828125 37.139063358306885 11.3203125 Z M 30.564844608306885 23.625 C 30.708077352494 23.20143758878112 30.934044912457466 22.810557760298252 31.22962260246277 22.47506618499756 C 31.52520029246807 22.139574609696865 31.88449513167143 21.86615858785808 32.28663611412048 21.67070174217224 C 32.68877709656954 21.4752448964864 33.12574803829193 21.361644451506436 33.5721652507782 21.336496353149414 C 34.018582463264465 21.311348254792392 34.46554721519351 21.37515439465642 34.88709568977356 21.524210214614868 C 35.30864416435361 21.673266034573317 35.696370989084244 21.90459978953004 36.02775764465332 22.204772472381592 C 36.3591443002224 22.504945155233145 36.62758470699191 22.867973998188972 36.81748151779175 23.272770166397095 C 37.007378328591585 23.677566334605217 37.11494945688173 24.116060469299555 37.13394355773926 24.562781810760498 C 37.152937658596784 25.00950315222144 37.08297643996775 25.455545525997877 36.928125858306885 25.875 C 36.78489311411977 26.29856241121888 36.55892340838909 26.689442239701748 36.26334571838379 27.02493381500244 C 35.96776802837849 27.360425390303135 35.60847318917513 27.63384141214192 35.206332206726074 27.82929825782776 C 34.80419122427702 28.0247551035136 34.36722028255463 28.138355548493564 33.92080307006836 28.163503646850586 C 33.47438585758209 28.188651745207608 33.02742110565305 28.12484560534358 32.605872631073 27.975789785385132 C 32.18432415649295 27.826733965426683 31.796595185995102 27.59540021046996 31.465208530426025 27.295227527618408 C 31.13382187485695 26.995054844766855 30.865383613854647 26.632026001811028 30.67548680305481 26.227229833602905 C 30.485589992254972 25.822433665394783 30.378021009732038 25.383939530700445 30.35902690887451 24.937218189239502 C 30.340032808016986 24.49049684777856 30.409994026646018 24.044454474002123 30.564844608306885 23.625 Z M 11.25 21.375 C 12.14510565251112 21.375000000000004 13.003550536930561 21.730578906834126 13.636485815048218 22.363514184951782 C 14.269421093165874 22.99644946306944 14.625 23.85489434748888 14.625 24.75 C 14.625 25.64510565251112 14.269421093165874 26.50355053693056 13.636485815048218 27.136485815048218 C 13.003550536930561 27.769421093165874 12.14510565251112 28.124999999999996 11.25 28.125 C 10.35489434748888 28.124999999999996 9.496449999511242 27.769421093165874 8.863514721393585 27.136485815048218 C 8.230579443275928 26.50355053693056 7.875 25.64510565251112 7.875 24.75 C 7.875 23.85489434748888 8.230579443275928 22.99644946306944 8.863514721393585 22.363514184951782 C 9.496449999511242 21.730578906834126 10.35489434748888 21.375000000000004 11.25 21.375 Z")
																					.Margin(0,2.25)
																					.Width(45)
																					.Height(36)
																			),
																		new TextBlock()
																			.Text("DcentCars")
																			.Margin(57,-2,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(189)
																			.Height(44)
																			.AutoLayout(isIndependentLayout: true)
																	),
																new TextBlock()
																	.Text("Welcome Back")
																	.Margin(0,72,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(216)
																	.Height(36)
																	.AutoLayout(isIndependentLayout: true),
																new TextBlock()
																	.Text("Enter your credentials to access your account")
																	.Margin(0,122,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(347)
																	.Height(20)
																	.AutoLayout(isIndependentLayout: true)
															),
														new AutoLayout()
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(64,426,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(592)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CornerRadius(12)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(288)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new TextBlock()
																					.TextAlignment(TextAlignment.Center)
																					.Text("Sign in as Buyer")
																					.Margin(94.1875,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(121)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(72.1875,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(14)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(14)
																							.Height(16)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 7 8 C 5.939134001731873 7.999999999999999 4.921718180179596 7.5785728096961975 4.171572685241699 6.828427314758301 C 3.4214271903038025 6.078281819820404 3.0000000000000004 5.060865998268127 3 4 C 3 2.9391340017318726 3.4214271903038025 1.921718418598175 4.171572685241699 1.1715729236602783 C 4.921718180179596 0.4214274287223816 5.939134001731873 9.992007221626409e-16 7 0 C 8.060865998268127 3.3306690738754696e-16 9.078281819820404 0.4214274287223816 9.8284273147583 1.1715729236602783 C 10.578572809696198 1.921718418598175 10.999999999999998 2.9391340017318726 11 4 C 10.999999999999998 5.060865998268127 10.578572809696198 6.078281819820404 9.8284273147583 6.828427314758301 C 9.078281819820404 7.5785728096961975 8.060865998268127 7.999999999999999 7 8 Z M 6.534375190734863 11.225000381469727 L 5.953125 10.256250381469727 C 5.753124997019768 9.921875387430191 5.993749916553497 9.5 6.381249904632568 9.5 L 7 9.5 L 7.615624904632568 9.5 C 8.00312489271164 9.5 8.243749812245369 9.925000369548798 8.043749809265137 10.256250381469727 L 7.462500095367432 11.225000381469727 L 8.506250381469727 15.096875190734863 L 9.631250381469727 10.506250381469727 C 9.693750381469727 10.253125369548798 9.937500178813934 10.087499812245369 10.190625190734863 10.153124809265137 C 12.381250143051147 10.703124821186066 14 12.684374570846558 14 15.040624618530273 C 14 15.571874618530273 13.568749606609344 16 13.040624618530273 16 L 8.921875 16 C 8.856250002980232 16 8.79687537997961 15.987499808892608 8.740625381469727 15.965624809265137 L 8.75 16 L 5.25 16 L 5.259375095367432 15.965624809265137 C 5.203125096857548 15.987499808892608 5.140625 16 5.078125 16 L 0.9593750238418579 16 C 0.43125003576278687 15.999999999999996 0 15.568749606609344 0 15.040624618530273 C 0 12.681249618530273 1.6218750476837158 10.699999809265137 3.809375047683716 10.153124809265137 C 4.062500059604645 10.090624809265137 4.306250095367432 10.256250381469727 4.368750095367432 10.506250381469727 L 5.493750095367432 15.096875190734863 L 6.537499904632568 11.225000381469727 L 6.534375190734863 11.225000381469727 Z")
																									.Width(14)
																									.Height(16)
																							)
																					)
																			),
																		new AutoLayout()
																			.CornerRadius(12)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(304,0,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(288)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new TextBlock()
																					.TextAlignment(TextAlignment.Center)
																					.Text("Sign in as Seller")
																					.Margin(96.8125,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(120)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(70.8125,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(18)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(18)
																							.Height(16)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 16.613407135009766 3.2437500953674316 L 14.822782516479492 0.40937501192092896 C 14.663407519459724 0.15625 14.379032701253891 0 14.075907707214355 0 L 2.9259073734283447 0 C 2.622782379388809 0 2.3384073227643967 0.15625 2.179032325744629 0.40937501192092896 L 0.3852824568748474 3.2437500953674316 C -0.5397175550460815 4.706250071525574 0.2790323495864868 6.740624904632568 2.007157325744629 6.974999904632568 C 2.132157325744629 6.990624904632568 2.260282516479492 7 2.385282516479492 7 C 3.200907528400421 7 3.9259074330329895 6.643750011920929 4.4227824211120605 6.09375 C 4.919657409191132 6.643750011920929 5.6446573138237 7 6.460282325744629 7 C 7.275907337665558 7 8.000907719135284 6.643750011920929 8.497782707214355 6.09375 C 8.994657695293427 6.643750011920929 9.719658076763153 7 10.535283088684082 7 C 11.35403311252594 7 12.075907528400421 6.643750011920929 12.572782516479492 6.09375 C 13.072782516479492 6.643750011920929 13.79465788602829 7 14.610282897949219 7 C 14.738407894968987 7 14.863408088684082 6.990624904632568 14.988408088684082 6.974999904632568 C 16.722783088684082 6.743749901652336 17.544658303260803 4.7093751430511475 16.616533279418945 3.2437500953674316 L 16.613407135009766 3.2437500953674316 Z M 15.116533279418945 7.965624809265137 L 15.113408088684082 7.965624809265137 C 14.947783082723618 7.987499808892608 14.779032707214355 8 14.607157707214355 8 C 14.219657719135284 8 13.847782909870148 7.940624907612801 13.500907897949219 7.834374904632568 L 13.500907897949219 12 L 3.5009074211120605 12 L 3.5009074211120605 7.831250190734863 C 3.150907427072525 7.940625190734863 2.7759074568748474 8 2.3884074687957764 8 C 2.2165324687957764 8 2.0446574985980988 7.987499808892608 1.8790324926376343 7.965624809265137 L 1.87590754032135 7.965624809265137 C 1.7477825433015823 7.946874808520079 1.6227825433015823 7.925000190734863 1.50090754032135 7.893750190734863 L 1.50090754032135 12 L 1.50090754032135 14 C 1.50090754032135 15.103124976158142 2.3977824449539185 16 3.5009074211120605 16 L 13.500907897949219 16 C 14.60403287410736 16 15.500907897949219 15.103124976158142 15.500907897949219 14 L 15.500907897949219 12 L 15.500907897949219 7.893750190734863 C 15.375907897949219 7.925000190734863 15.25090828537941 7.949999809265137 15.116533279418945 7.965624809265137 Z")
																									.Margin(0.49909252,0,0.4978714,0)
																									.Width(18)
																									.Height(16)
																							)
																					)
																			)
																	),
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(0,82,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CornerRadius(12)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(592)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new TextBlock()
																					.Text("Email")
																					.Margin(16,0,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(41)
																					.Height(58)
																					.AutoLayout(isIndependentLayout: true)
																			),
																		new AutoLayout()
																			.CornerRadius(12)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(0,74,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(592)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new TextBlock()
																					.Text("Password")
																					.Margin(16,0,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(74)
																					.Height(58)
																					.AutoLayout(isIndependentLayout: true)
																			)
																	),
																new AutoLayout()
																	.CornerRadius(12)
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(0,238,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new TextBlock()
																			.TextAlignment(TextAlignment.Center)
																			.Text("Sign In")
																			.Margin(269.67188,18,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(53)
																			.Height(20)
																			.AutoLayout(isIndependentLayout: true)
																	),
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(0,318,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(592)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(233.54688,0,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(124.90625)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.Text("Or continue with")
																							.Margin(8,1,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(110)
																							.Height(17)
																							.AutoLayout(isIndependentLayout: true)
																					)
																			),
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(592)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(0,9.5,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(592)
																					.AutoLayout(isIndependentLayout: true)
																			)
																	),
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(0,362,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CornerRadius(12)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(288)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new TextBlock()
																					.TextAlignment(TextAlignment.Center)
																					.Text("Phantom")
																					.Margin(119.59375,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(68)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(101.59375,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(10)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(10)
																							.Height(16)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 9.496874809265137 8.149999618530273 L 4.75 11.050000190734863 L 0 8.149999618530273 L 4.75 0 L 9.496874809265137 8.149999618530273 Z M 4.75 11.981249809265137 L 0 9.081250190734863 L 4.75 16 L 9.5 9.081250190734863 L 4.75 11.981249809265137 Z")
																									.Margin(0.25,0)
																									.Width(10)
																									.Height(16)
																							)
																					)
																			),
																		new AutoLayout()
																			.CornerRadius(12)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(304,0,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(288)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new TextBlock()
																					.TextAlignment(TextAlignment.Center)
																					.Text("Solflare")
																					.Margin(127.1875,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(58)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(103.1875,19,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(16)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(16)
																							.Height(16)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 2 0 C 0.8968750238418579 0 0 0.8968750238418579 0 2 L 0 12 C 0 13.103124976158142 0.8968750238418579 14 2 14 L 14 14 C 15.103124976158142 14 16 13.103124976158142 16 12 L 16 5 C 16 3.896875023841858 15.103124976158142 3 14 3 L 2.5 3 C 2.2249999940395355 3 2 2.7750000059604645 2 2.5 C 2 2.2249999940395355 2.2249999940395355 2 2.5 2 L 14 2 C 14.553125023841858 2 15 1.553125023841858 15 1 C 15 0.4468749761581421 14.553125023841858 0 14 0 L 2 0 Z M 13 7.5 C 13.265216499567032 7.5 13.519570216536522 7.60535703599453 13.707106590270996 7.792893409729004 C 13.89464296400547 7.980429783463478 14 8.234783500432968 14 8.5 C 14 8.765216499567032 13.89464296400547 9.019570216536522 13.707106590270996 9.207106590270996 C 13.519570216536522 9.39464296400547 13.265216499567032 9.5 13 9.5 C 12.734783500432968 9.5 12.480429783463478 9.39464296400547 12.292893409729004 9.207106590270996 C 12.10535703599453 9.019570216536522 12 8.765216499567032 12 8.5 C 12 8.234783500432968 12.10535703599453 7.980429783463478 12.292893409729004 7.792893409729004 C 12.480429783463478 7.60535703599453 12.734783500432968 7.5 13 7.5 Z")
																									.Margin(0,1)
																									.Width(16)
																									.Height(16)
																							)
																					)
																			)
																	)
															)
													),
												new AutoLayout()
													.CounterAxisAlignment(AutoLayoutAlignment.Start)
													.Margin(720,0,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(720)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new AutoLayout()
															.CornerRadius(24,0,0,24)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(720)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new Image()
																	.Source(new BitmapImage(new Uri("https://picsum.photos/360/360")))
																	.Stretch(Stretch.UniformToFill)
																	.AutoLayout
																	(
																		counterAlignment: AutoLayoutAlignment.Stretch,
																		primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
																	)
															),
														new AutoLayout()
															.CornerRadius(24,0,0,24)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(720)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(64,936,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(592)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new TextBlock()
																			.Text("Discover Exclusive Car NFTs")
																			.Margin(0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(500)
																			.Height(44)
																			.AutoLayout(isIndependentLayout: true),
																		new TextBlock()
																			.Text("Buy and sell premium automotive NFTs on the Solana blockchain")
																			.Margin(0,58,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(488)
																			.Height(20)
																			.AutoLayout(isIndependentLayout: true)
																	)
															)
													)
											)
									)
							)
					)
			);
	}
}