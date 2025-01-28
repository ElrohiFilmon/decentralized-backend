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
					.CounterAxisAlignment(AutoLayoutAlignment.Start)
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
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(1440)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new AutoLayout()
											.CounterAxisAlignment(AutoLayoutAlignment.Start)
											.Margin(256,64,0,0)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(1184)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new AutoLayout()
													.CounterAxisAlignment(AutoLayoutAlignment.Start)
													.Margin(32,32,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(1120)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new TextBlock()
															.Text("Featured Cars")
															.Margin(0,1,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(166)
															.Height(29)
															.AutoLayout(isIndependentLayout: true),
														new AutoLayout()
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(0,56,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(1120)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.CornerRadius(12)
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(357.32812)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(357.32812)
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
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(0,192,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(357.32812)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,16,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.32812)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.Text("2025 Porsche 911 GT3")
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(177)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true),
																						new TextBlock()
																							.Text("12.5 SOL")
																							.Margin(259.14062,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(67)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																					),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,48,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.32812)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,3,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(14)
																							.Height(14)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 7 0 C 8.856515496969223 9.71445146547012e-16 10.636993184685707 0.7374980002641678 11.949747800827026 2.050252616405487 C 13.262502416968346 3.3630072325468063 13.999999999999998 5.143484503030777 14 7 C 13.999999999999998 8.856515496969223 13.262502416968346 10.636993184685707 11.949747800827026 11.949747800827026 C 10.636993184685707 13.262502416968346 8.856515496969223 13.999999999999998 7 14 C 5.143484503030777 13.999999999999998 3.3630072325468063 13.262502416968346 2.050252616405487 11.949747800827026 C 0.7374980002641678 10.636993184685707 1.0200174038743626e-15 8.856515496969223 0 7 C 3.400058012914542e-16 5.143484503030777 0.7374980002641678 3.3630072325468063 2.050252616405487 2.050252616405487 C 3.3630072325468063 0.7374980002641678 5.143484503030777 1.7486012637846216e-15 7 0 Z M 6.34375 3.28125 L 6.34375 7 C 6.34375 7.21875 6.453124921768904 7.423828125 6.636328041553497 7.546875 L 9.26132845878601 9.296875 C 9.56210970878601 9.499218752607703 9.969531247392297 9.417187176644802 10.171875 9.11367154121399 C 10.374218752607703 8.810155905783176 10.292187176644802 8.405468752607703 9.98867154121399 8.203125 L 7.65625 6.649999916553497 L 7.65625 3.28125 C 7.65625 2.9175781197845936 7.363671880215406 2.625 7 2.625 C 6.636328119784594 2.625 6.34375 2.9175781197845936 6.34375 3.28125 Z")
																									.Width(14)
																									.Height(14)
																							),
																						new TextBlock()
																							.Text("Ends in 2h 45m")
																							.Margin(18,1,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(103)
																							.Height(17)
																							.AutoLayout(isIndependentLayout: true)
																					),
																				new AutoLayout()
																					.CornerRadius(8)
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,84,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.32812)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.TextAlignment(TextAlignment.Center)
																							.Text("Place Bid")
																							.Margin(127.5625,10,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(70)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																					)
																			)
																	),
																new AutoLayout()
																	.CornerRadius(12)
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(381.32812,0,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(357.32812)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(357.32812)
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
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(0,192,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(357.32812)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,16,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.32812)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.Text("1967 Ford Mustang")
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(150)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true),
																						new TextBlock()
																							.Text("8.2 SOL")
																							.Margin(265.375,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(60)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																					),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,48,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.32812)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,3,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(12.25)
																							.Height(14)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 0 1.3097751196030598 L 0 5.397665518074512 C 0 5.862509254176538 0.18320314951325362 6.308212032064832 0.5113281560534819 6.636337022254497 L 5.3238281476687 11.448837295602086 C 6.007421911294176 12.13243102516389 7.114844225599968 12.13243102516389 7.798437989225444 11.448837295602086 L 11.448828686985484 7.798446779742062 C 12.13242245061096 7.11485305018026 12.13242245061096 6.00743120829014 11.448828686985484 5.323837478728338 L 6.636328173829614 0.5113376226132498 C 6.308203167289386 0.1832126324235847 5.862499949959071 0.000009499994291857622 5.3976561906937475 0.000009499994291857622 L 1.3125000261609132 0.000009499994291857622 C 0.587890636717909 -0.002724874964700713 0 0.5851657662675495 0 1.3097751196030598 Z M 3.062500061042131 2.184775197750292 C 3.294564502788821 2.1847751977502923 3.5171240095732084 2.276962392873021 3.681218339861622 2.4410567149845668 C 3.8453126701500353 2.6051510370961126 3.93750007848274 2.8277107414065465 3.93750007848274 3.059775171589399 C 3.93750007848274 3.291839601772251 3.8453126701500353 3.514398888850184 3.681218339861622 3.67849321096173 C 3.5171240095732084 3.8425875330732757 3.294564502788821 3.9347749368122553 3.062500061042131 3.9347749368122553 C 2.8304356192954407 3.9347749368122553 2.6078759038947927 3.8425875330732757 2.4437815736063793 3.67849321096173 C 2.279687243317966 3.514398888850184 2.1875000436015224 3.291839601772251 2.187500043601522 3.059775171589399 C 2.187500043601522 2.8277107414065465 2.279687243317966 2.6051510370961126 2.4437815736063793 2.4410567149845668 C 2.6078759038947927 2.276962392873021 2.8304356192954407 2.1847751977502923 3.062500061042131 2.184775197750292 Z")
																									.Margin(0,0.8777248,0.288476,1.1607428)
																									.Width(12.25)
																									.Height(14)
																							),
																						new TextBlock()
																							.Text("Buy Now")
																							.Margin(16.25,1,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(59)
																							.Height(17)
																							.AutoLayout(isIndependentLayout: true)
																					),
																				new AutoLayout()
																					.CornerRadius(8)
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,84,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.32812)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.TextAlignment(TextAlignment.Center)
																							.Text("Buy Now")
																							.Margin(128.71875,10,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(68)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																					)
																			)
																	),
																new AutoLayout()
																	.CornerRadius(12)
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(762.65625,0,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(357.34375)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(357.34375)
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
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(0,192,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(357.34375)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,16,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.34375)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.Text("2025 Tesla Model S")
																							.Margin(0,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(154)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true),
																						new TextBlock()
																							.Text("15.0 SOL")
																							.Margin(259.42188,2,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(67)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																					),
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,48,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.34375)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,3,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(14)
																							.Height(14)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 7 0 C 8.856515496969223 9.71445146547012e-16 10.636993184685707 0.7374980002641678 11.949747800827026 2.050252616405487 C 13.262502416968346 3.3630072325468063 13.999999999999998 5.143484503030777 14 7 C 13.999999999999998 8.856515496969223 13.262502416968346 10.636993184685707 11.949747800827026 11.949747800827026 C 10.636993184685707 13.262502416968346 8.856515496969223 13.999999999999998 7 14 C 5.143484503030777 13.999999999999998 3.3630072325468063 13.262502416968346 2.050252616405487 11.949747800827026 C 0.7374980002641678 10.636993184685707 1.0200174038743626e-15 8.856515496969223 0 7 C 3.400058012914542e-16 5.143484503030777 0.7374980002641678 3.3630072325468063 2.050252616405487 2.050252616405487 C 3.3630072325468063 0.7374980002641678 5.143484503030777 1.7486012637846216e-15 7 0 Z M 6.34375 3.28125 L 6.34375 7 C 6.34375 7.21875 6.453124921768904 7.423828125 6.636328041553497 7.546875 L 9.26132845878601 9.296875 C 9.56210970878601 9.499218752607703 9.969531247392297 9.417187176644802 10.171875 9.11367154121399 C 10.374218752607703 8.810155905783176 10.292187176644802 8.405468752607703 9.98867154121399 8.203125 L 7.65625 6.649999916553497 L 7.65625 3.28125 C 7.65625 2.9175781197845936 7.363671880215406 2.625 7 2.625 C 6.636328119784594 2.625 6.34375 2.9175781197845936 6.34375 3.28125 Z")
																									.Width(14)
																									.Height(14)
																							),
																						new TextBlock()
																							.Text("Ends in 5h 30m")
																							.Margin(18,1,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(103)
																							.Height(17)
																							.AutoLayout(isIndependentLayout: true)
																					),
																				new AutoLayout()
																					.CornerRadius(8)
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.Margin(16,84,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(325.34375)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new TextBlock()
																							.TextAlignment(TextAlignment.Center)
																							.Text("Place Bid")
																							.Margin(127.578125,10,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(70)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																					)
																			)
																	)
															)
													),
												new AutoLayout()
													.CounterAxisAlignment(AutoLayoutAlignment.Start)
													.Margin(32,452,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(1120)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new TextBlock()
															.Text("Recent Activity")
															.Margin(0,1,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(180)
															.Height(29)
															.AutoLayout(isIndependentLayout: true),
														new AutoLayout()
															.CornerRadius(12)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(0,56,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(1120)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Width(1120)
																	.AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
																	.Children
																	(
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(24,24,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(1072)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(298.64062)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,12,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(20)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 12.448242309351137 0.36621094623029676 C 11.95996108262738 -0.12207031541009894 11.1669916551723 -0.12207031541009894 10.678710428448543 0.36621094623029676 L 5.991210651900485 5.053711057978095 C 5.502929425176729 5.54199231961849 5.502929425176729 6.334961207731786 5.991210651900485 6.823242469372182 L 6.616210622106894 7.448242484271888 C 7.10449184883065 7.936523745912283 7.8974606802393135 7.936523745912283 8.38574190696307 7.448242484271888 L 8.54199189951467 7.291992480546962 L 12.713866819851726 11.459961210700087 L 12.557616827300123 11.616211214425013 C 12.069335600576366 12.104492476065408 12.069335600576366 12.897461960225167 12.557616827300123 13.385743221865562 L 13.182616797506531 14.010743236765268 C 13.670898024230286 14.499024498405664 14.46386745168537 14.499024498405664 14.952148678409126 14.010743236765268 L 19.639648454957182 9.323242528971008 C 20.12792968168094 8.834961267330613 20.12792968168094 8.041992379217318 19.639648454957182 7.553711117576921 L 19.014648484750776 6.928711102677215 C 18.52636725802702 6.44042984103682 17.73339783057194 6.44042984103682 17.24511660384818 6.928711102677215 L 17.088866611296577 7.084961106402141 L 12.916992287005943 2.9130858877373083 L 13.073242279557546 2.7568358840123817 C 13.5615235062813 2.268554622371986 13.5615235062813 1.4755859577761141 13.073242279557546 0.9873046961357185 L 12.448242309351137 0.36230471848891593 L 12.448242309351137 0.36621094623029676 Z M 6.510741996343846 11.616211214425013 C 6.02246076962009 11.127929952784617 5.229491938211426 11.127929952784617 4.74121071148767 11.616211214425013 L 0.36621092004281697 15.991211318722959 C -0.12207030668093899 16.479492580363356 -0.12207030668093899 17.27246206452311 0.36621092004281697 17.760743326163507 L 2.2412108306620397 19.635743370862627 C 2.7294920573857957 20.124024632503023 3.5224605907712494 20.124024632503023 4.010741817495005 19.635743370862627 L 8.38574190696307 15.260743266564681 C 8.874023133686826 14.772462004924286 8.874023133686826 13.979492520764527 8.38574190696307 13.491211259124132 L 8.331054051942157 13.436523996238993 L 10.627929657706408 11.143554714738526 L 8.858397776803812 9.3740238993909 L 6.565429255318339 11.66699318089137 L 6.510741996343846 11.612304725913305 L 6.510741996343846 11.616211214425013 Z")
																									.Margin(-0.00292968,0.0009765476,-0.0029296875,-0.0029296875)
																									.Width(20)
																									.Height(20)
																							),
																						new AutoLayout()
																							.CounterAxisAlignment(AutoLayoutAlignment.Start)
																							.Margin(36,0,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(262.64062)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new TextBlock()
																									.Text("New bid on 2025 Porsche 911 GT3")
																									.Margin(0,2,0,0)
																									.VerticalAlignment(VerticalAlignment.Top)
																									.HorizontalAlignment(HorizontalAlignment.Left)
																									.Width(265)
																									.Height(20)
																									.AutoLayout(isIndependentLayout: true),
																								new TextBlock()
																									.Text("2 minutes ago")
																									.Margin(0,25,0,0)
																									.VerticalAlignment(VerticalAlignment.Top)
																									.HorizontalAlignment(HorizontalAlignment.Left)
																									.Width(94)
																									.Height(17)
																									.AutoLayout(isIndependentLayout: true)
																							)
																					),
																				new TextBlock()
																					.Text("12.5 SOL")
																					.Margin(1004.71875,12,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(69)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true)
																			),
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(24,84,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(1072)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(288.4375)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,12,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(17.5)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 0 1.8711073435547498 L 0 7.710950863062858 C 0 8.375013353797542 0.2617187724990666 9.011731618076587 0.73046875941861 9.480481611536364 L 7.605468418560305 16.35548211165953 C 8.582030891309353 17.332044598034066 10.164062693209244 17.332044598034066 11.140625165958292 16.35548211165953 L 16.35546877043821 11.140638434419513 C 17.33203124318726 10.164075948044978 17.33203124318726 8.582044720118231 16.35546877043821 7.605482233743697 L 9.480468366238478 0.7304823296669712 C 9.011718379318934 0.2617323362071945 8.37499952787727 0.000013571420633345091 7.710937046407916 0.000013571420633345091 L 1.8749999476781736 0.000013571420633345091 C 0.839843726564182 -0.0038926785830724546 0 0.8359511079977429 0 1.8711073435547498 Z M 4.374999877915738 3.1211074751257644 C 4.706520493123453 3.121107475125765 5.024462630463149 3.2528034702582174 5.258883091089745 3.487223934155564 C 5.49330355171634 3.721644398052911 5.62499984303452 4.039586837851913 5.62499984303452 4.371107457685169 C 5.62499984303452 4.702628077518425 5.49330355171634 5.020569921270988 5.258883091089745 5.254990385168334 C 5.024462630463149 5.48941084906568 4.706520493123453 5.621107142221354 4.374999877915738 5.621107142221354 C 4.043479262708023 5.621107142221354 3.725536827345112 5.48941084906568 3.4911163667185163 5.254990385168334 C 3.2566959060919207 5.020569921270988 3.124999912796956 4.702628077518425 3.1249999127969557 4.371107457685169 C 3.1249999127969557 4.039586837851913 3.2566959060919207 3.721644398052911 3.4911163667185163 3.487223934155564 C 3.725536827345112 3.2528034702582174 4.043479262708023 3.121107475125765 4.374999877915738 3.1211074751257644 Z")
																									.Margin(0,1.2538927,0.41210938,1.6582031)
																									.Width(17.5)
																									.Height(20)
																							),
																						new AutoLayout()
																							.CounterAxisAlignment(AutoLayoutAlignment.Start)
																							.Margin(33.5,0,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(254.9375)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new TextBlock()
																									.Text("1967 Ford Mustang listed for sale")
																									.Margin(0,2,0,0)
																									.VerticalAlignment(VerticalAlignment.Top)
																									.HorizontalAlignment(HorizontalAlignment.Left)
																									.Width(257)
																									.Height(20)
																									.AutoLayout(isIndependentLayout: true),
																								new TextBlock()
																									.Text("15 minutes ago")
																									.Margin(0,25,0,0)
																									.VerticalAlignment(VerticalAlignment.Top)
																									.HorizontalAlignment(HorizontalAlignment.Left)
																									.Width(100)
																									.Height(17)
																									.AutoLayout(isIndependentLayout: true)
																							)
																					),
																				new TextBlock()
																					.Text("8.2 SOL")
																					.Margin(1011.2344,12,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(61)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true)
																			),
																		new AutoLayout()
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.Margin(24,144,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(1072)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new AutoLayout()
																					.CounterAxisAlignment(AutoLayoutAlignment.Start)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(308.89062)
																					.AutoLayout(isIndependentLayout: true)
																					.Children
																					(
																						new AutoLayout()
																							.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																							.CounterAxisAlignment(AutoLayoutAlignment.Center)
																							.Orientation(Orientation.Horizontal)
																							.Margin(0,12,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(20)
																							.Height(20)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new Path()
																									.Data("F1 M 10 20 C 12.652164995670319 19.999999999999996 15.19570454955101 18.946432024240494 17.071068286895752 17.071068286895752 C 18.946432024240494 15.19570454955101 19.999999999999996 12.652164995670319 20 10 C 19.999999999999996 7.347835004329681 18.946432024240494 4.804296046495438 17.071068286895752 2.928932309150696 C 15.19570454955101 1.053568571805954 12.652164995670319 1.6653345369377348e-15 10 0 C 7.347835004329681 1.942890293094024e-15 4.804296046495438 1.053568571805954 2.928932309150696 2.928932309150696 C 1.053568571805954 4.804296046495438 2.706168622523819e-15 7.347835004329681 0 10 C 2.0816681711721685e-15 12.652164995670319 1.053568571805954 15.19570454955101 2.928932309150696 17.071068286895752 C 4.804296046495438 18.946432024240494 7.347835004329681 19.999999999999996 10 20 Z M 14.4140625 8.1640625 L 9.4140625 13.1640625 C 9.046875014901161 13.531249985098839 8.45312524586916 13.531249985098839 8.089843988418579 13.1640625 L 5.589843988418579 10.6640625 C 5.22265650331974 10.296875014901161 5.22265650331974 9.70312524586916 5.589843988418579 9.339843988418579 C 5.957031473517418 8.976562730967999 6.550781242549419 8.97265650331974 6.9140625 9.339843988418579 L 8.75 11.175781488418579 L 13.0859375 6.8359375 C 13.453124985098839 6.468750014901161 14.04687475413084 6.468750014901161 14.410156011581421 6.8359375 C 14.773437269032001 7.203124985098839 14.77734349668026 7.79687475413084 14.410156011581421 8.160156011581421 L 14.4140625 8.1640625 Z")
																									.Width(20)
																									.Height(20)
																							),
																						new AutoLayout()
																							.CounterAxisAlignment(AutoLayoutAlignment.Start)
																							.Margin(36,0,0,0)
																							.VerticalAlignment(VerticalAlignment.Top)
																							.HorizontalAlignment(HorizontalAlignment.Left)
																							.Width(272.89062)
																							.AutoLayout(isIndependentLayout: true)
																							.Children
																							(
																								new TextBlock()
																									.Text("2025 Tesla Model S auction started")
																									.Margin(0,2,0,0)
																									.VerticalAlignment(VerticalAlignment.Top)
																									.HorizontalAlignment(HorizontalAlignment.Left)
																									.Width(275)
																									.Height(20)
																									.AutoLayout(isIndependentLayout: true),
																								new TextBlock()
																									.Text("1 hour ago")
																									.Margin(0,25,0,0)
																									.VerticalAlignment(VerticalAlignment.Top)
																									.HorizontalAlignment(HorizontalAlignment.Left)
																									.Width(70)
																									.Height(17)
																									.AutoLayout(isIndependentLayout: true)
																							)
																					),
																				new TextBlock()
																					.Text("15.0 SOL")
																					.Margin(1004.8281,12,0,0)
																					.VerticalAlignment(VerticalAlignment.Top)
																					.HorizontalAlignment(HorizontalAlignment.Left)
																					.Width(69)
																					.Height(20)
																					.AutoLayout(isIndependentLayout: true)
																			)
																	)
															)
													)
											)
									),
								new AutoLayout()
									.CounterAxisAlignment(AutoLayoutAlignment.Start)
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(256)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new AutoLayout()
											.CounterAxisAlignment(AutoLayoutAlignment.Start)
											.Margin(0,64,0,0)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(255)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new AutoLayout()
													.CounterAxisAlignment(AutoLayoutAlignment.Start)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(255)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new AutoLayout()
															.CornerRadius(8)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(16,24,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(223)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(16,16,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(20)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new Path()
																			.Data("F1 M 17.993749618530273 7.984375 C 17.993749618530273 8.546875 17.524999618530273 8.987500190734863 16.993749618530273 8.987500190734863 L 15.993749618530273 8.987500190734863 L 16.015625 13.993749618530273 C 16.015625 14.07812462002039 16.00937500037253 14.16249980777502 16 14.246874809265137 L 16 14.75 C 16 15.440625011920929 15.440625011920929 16 14.75 16 L 14.25 16 C 14.215624999254942 16 14.181250382214785 15.999999809311703 14.146875381469727 15.996874809265137 C 14.103125382214785 15.999999809311703 14.059374999254942 16 14.015625 16 L 13 16 L 12.25 16 C 11.559374988079071 16 11 15.440625011920929 11 14.75 L 11 14 L 11 12 C 11 11.446874976158142 10.553125023841858 11 10 11 L 8 11 C 7.446874976158142 11 7 11.446874976158142 7 12 L 7 14 L 7 14.75 C 7 15.440625011920929 6.440625011920929 16 5.75 16 L 5 16 L 4.003125190734863 16 C 3.9562501907348633 16 3.909374952316284 15.99687461857684 3.862499952316284 15.993749618530273 C 3.824999950826168 15.99687461857684 3.787500001490116 16 3.75 16 L 3.25 16 C 2.559374988079071 16 2 15.440625011920929 2 14.75 L 2 11.25 C 2 11.221875000745058 1.999999952269718 11.190625380724669 2.003124952316284 11.162500381469727 L 2.003124952316284 8.987500190734863 L 1 8.987500190734863 C 0.4375 8.987500190734863 0 8.550000011920929 0 7.984375 C 0 7.703125 0.09375 7.453125 0.3125 7.234375 L 8.324999809265137 0.25 C 8.543749809265137 0.03125 8.793749809265137 0 9.012499809265137 0 C 9.231249809265137 0 9.481249809265137 0.0625 9.668749809265137 0.21875 L 17.649999618530273 7.234375 C 17.899999618530273 7.453125 18.024999618530273 7.703125 17.993749618530273 7.984375 Z")
																			.Margin(0,0,0.001531601,0)
																			.Width(20)
																			.Height(16)
																			.AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
																	),
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(48,12,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(44.828125)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new TextBlock()
																			.Text("Home")
																			.Margin(0,2,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(45)
																			.Height(20)
																			.AutoLayout(isIndependentLayout: true)
																	)
															),
														new AutoLayout()
															.CornerRadius(8)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(16,80,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(223)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																	.CounterAxisAlignment(AutoLayoutAlignment.Center)
																	.Orientation(Orientation.Horizontal)
																	.Margin(16,16,0,0)
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
																	),
																new TextBlock()
																	.Text("Marketplace")
																	.Margin(48,14,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(94)
																	.Height(20)
																	.AutoLayout(isIndependentLayout: true)
															),
														new AutoLayout()
															.CornerRadius(8)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(16,136,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(223)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																	.CounterAxisAlignment(AutoLayoutAlignment.Center)
																	.Orientation(Orientation.Horizontal)
																	.Margin(16,16,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(16)
																	.Height(16)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new Path()
																			.Data("F1 M 4.224999904632568 2.668750047683716 L 3.409374952316284 5 L 12.590624809265137 5 L 11.774999618530273 2.668750047683716 C 11.634374618530273 2.2687500417232513 11.256250202655792 2 10.831250190734863 2 L 5.168749809265137 2 C 4.743749797344208 2 4.365624904632568 2.2687500417232513 4.224999904632568 2.668750047683716 Z M 1.2374999523162842 5.150000095367432 L 2.3375000953674316 2.0093750953674316 C 2.7593750953674316 0.8062500953674316 3.8937498331069946 0 5.168749809265137 0 L 10.831250190734863 0 C 12.106250166893005 0 13.240625381469727 0.8062500953674316 13.662500381469727 2.0093750953674316 L 14.762499809265137 5.150000095367432 C 15.487499833106995 5.450000107288361 16 6.165624976158142 16 7 L 16 11.5 L 16 13 C 16 13.553125023841858 15.553125023841858 14 15 14 L 14 14 C 13.446874976158142 14 13 13.553125023841858 13 13 L 13 11.5 L 3 11.5 L 3 13 C 3 13.553125023841858 2.553125023841858 14 2 14 L 1 14 C 0.4468749761581421 14 0 13.553125023841858 0 13 L 0 11.5 L 0 7 C 0 6.165624976158142 0.5124999284744263 5.450000107288361 1.2374999523162842 5.150000095367432 Z M 4 8 C 3.9999999999999996 7.734783500432968 3.8946432024240494 7.480429783463478 3.707106828689575 7.292893409729004 C 3.519570454955101 7.10535703599453 3.265216499567032 6.999999999999999 3 7 C 2.734783500432968 6.999999999999999 2.480429545044899 7.10535703599453 2.292893171310425 7.292893409729004 C 2.1053567975759506 7.480429783463478 2.000000000000001 7.734783500432968 2 8 C 2.000000000000001 8.265216499567032 2.1053567975759506 8.519570216536522 2.292893171310425 8.707106590270996 C 2.480429545044899 8.89464296400547 2.734783500432968 9 3 9 C 3.265216499567032 9 3.519570454955101 8.89464296400547 3.707106828689575 8.707106590270996 C 3.8946432024240494 8.519570216536522 3.9999999999999996 8.265216499567032 4 8 Z M 13 9 C 13.265216499567032 9 13.519570216536522 8.89464296400547 13.707106590270996 8.707106590270996 C 13.89464296400547 8.519570216536522 14 8.265216499567032 14 8 C 14 7.734783500432968 13.89464296400547 7.480429783463478 13.707106590270996 7.292893409729004 C 13.519570216536522 7.10535703599453 13.265216499567032 6.999999999999999 13 7 C 12.734783500432968 6.999999999999999 12.480429783463478 7.10535703599453 12.292893409729004 7.292893409729004 C 12.10535703599453 7.480429783463478 12 7.734783500432968 12 8 C 12 8.265216499567032 12.10535703599453 8.519570216536522 12.292893409729004 8.707106590270996 C 12.480429783463478 8.89464296400547 12.734783500432968 9 13 9 Z")
																			.Margin(0,1)
																			.Width(16)
																			.Height(16)
																	),
																new TextBlock()
																	.Text("My Purchases")
																	.Margin(48,14,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(107)
																	.Height(20)
																	.AutoLayout(isIndependentLayout: true)
															),
														new AutoLayout()
															.CornerRadius(8)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(16,192,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(223)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																	.CounterAxisAlignment(AutoLayoutAlignment.Center)
																	.Orientation(Orientation.Horizontal)
																	.Margin(16,16,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(16)
																	.Height(16)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new Path()
																			.Data("F1 M 9.95859432220459 0.29296875 C 9.56796932220459 -0.09765625 8.93359375 -0.09765625 8.54296875 0.29296875 L 4.79296875 4.04296875 C 4.40234375 4.43359375 4.40234375 5.067968845367432 4.79296875 5.458593845367432 L 5.29296875 5.958593845367432 C 5.68359375 6.349218845367432 6.317968845367432 6.349218845367432 6.708593845367432 5.958593845367432 L 6.833593845367432 5.833593845367432 L 10.171093940734863 9.16796875 L 10.046093940734863 9.29296875 C 9.655468940734863 9.68359375 9.655468940734863 10.31796932220459 10.046093940734863 10.70859432220459 L 10.546093940734863 11.20859432220459 C 10.936718940734863 11.59921932220459 11.571094512939453 11.59921932220459 11.961719512939453 11.20859432220459 L 15.711719512939453 7.458593845367432 C 16.102344512939453 7.067968845367432 16.102344512939453 6.43359375 15.711719512939453 6.04296875 L 15.211719512939453 5.54296875 C 14.821094512939453 5.15234375 14.186718940734863 5.15234375 13.796093940734863 5.54296875 L 13.671093940734863 5.66796875 L 10.33359432220459 2.3304686546325684 L 10.45859432220459 2.2054686546325684 C 10.84921932220459 1.8148436546325684 10.84921932220459 1.180468738079071 10.45859432220459 0.789843738079071 L 9.95859432220459 0.28984376788139343 L 9.95859432220459 0.29296875 Z M 5.208593845367432 9.29296875 C 4.817968845367432 8.90234375 4.18359375 8.90234375 3.79296875 9.29296875 L 0.29296875 12.79296875 C -0.09765625 13.18359375 -0.09765625 13.81796932220459 0.29296875 14.20859432220459 L 1.79296875 15.70859432220459 C 2.18359375 16.09921932220459 2.8179686069488525 16.09921932220459 3.2085936069488525 15.70859432220459 L 6.708593845367432 12.20859432220459 C 7.099218845367432 11.81796932220459 7.099218845367432 11.18359375 6.708593845367432 10.79296875 L 6.664843559265137 10.749218940734863 L 8.502344131469727 8.914843559265137 L 7.086718559265137 7.499218940734863 L 5.252343654632568 9.33359432220459 L 5.208593845367432 9.289843559265137 L 5.208593845367432 9.29296875 Z")
																			.Margin(-0.002343744,0.0007812381,-0.0023441315,-0.0023441315)
																			.Width(16)
																			.Height(16)
																	),
																new TextBlock()
																	.Text("Listings & Auctions")
																	.Margin(48,14,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(144)
																	.Height(20)
																	.AutoLayout(isIndependentLayout: true)
															),
														new AutoLayout()
															.CornerRadius(8)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(16,248,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(223)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																	.CounterAxisAlignment(AutoLayoutAlignment.Center)
																	.Orientation(Orientation.Horizontal)
																	.Margin(16,16,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(14)
																	.Height(16)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new Path()
																			.Data("F1 M 7 8 C 8.060865998268127 7.999999999999999 9.078281819820404 7.5785728096961975 9.8284273147583 6.828427314758301 C 10.578572809696198 6.078281819820404 10.999999999999998 5.060865998268127 11 4 C 10.999999999999998 2.9391340017318726 10.578572809696198 1.921718418598175 9.8284273147583 1.1715729236602783 C 9.078281819820404 0.4214274287223816 8.060865998268127 6.661338147750939e-16 7 0 C 5.939134001731873 7.771561172376096e-16 4.921718180179596 0.4214274287223816 4.171572685241699 1.1715729236602783 C 3.4214271903038025 1.921718418598175 3.0000000000000013 2.9391340017318726 3 4 C 3.000000000000001 5.060865998268127 3.4214271903038025 6.078281819820404 4.171572685241699 6.828427314758301 C 4.921718180179596 7.5785728096961975 5.939134001731873 7.999999999999999 7 8 Z M 5.571875095367432 9.5 C 2.4937500953674316 9.5 0 11.993749618530273 0 15.071874618530273 C 0 15.584374606609344 0.41562503576278687 16 0.9281250238418579 16 L 13.071874618530273 16 C 13.584374606609344 16 14 15.584374606609344 14 15.071874618530273 C 14 11.993749618530273 11.506250381469727 9.5 8.428125381469727 9.5 L 5.571875095367432 9.5 Z")
																			.Width(14)
																			.Height(16)
																	),
																new TextBlock()
																	.Text("Profile & Wallet")
																	.Margin(48,14,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(114)
																	.Height(20)
																	.AutoLayout(isIndependentLayout: true)
															)
													),
												new AutoLayout()
													.CounterAxisAlignment(AutoLayoutAlignment.Start)
													.Margin(0,1307,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(255)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new AutoLayout()
															.CornerRadius(8)
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(16,17,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(223)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new TextBlock()
																	.TextAlignment(TextAlignment.Center)
																	.Text("Connect Wallet")
																	.Margin(72.34375,9,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(101)
																	.Height(17)
																	.AutoLayout(isIndependentLayout: true),
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(50.34375,11,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(14)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new Path()
																			.Data("F1 M 1.75 0 C 0.7847656458616257 0 0 0.7847656458616257 0 1.75 L 0 10.5 C 0 11.465234354138374 0.7847656458616257 12.25 1.75 12.25 L 12.25 12.25 C 13.215234354138374 12.25 14 11.465234354138374 14 10.5 L 14 4.375 C 14 3.4097656458616257 13.215234354138374 2.625 12.25 2.625 L 2.1875 2.625 C 1.9468749947845936 2.625 1.75 2.4281250052154064 1.75 2.1875 C 1.75 1.9468749947845936 1.9468749947845936 1.75 2.1875 1.75 L 12.25 1.75 C 12.733984395861626 1.75 13.125 1.3589843958616257 13.125 0.875 C 13.125 0.39101560413837433 12.733984395861626 0 12.25 0 L 1.75 0 Z M 11.375 6.5625 C 11.607064437121153 6.5625 11.829623939469457 6.6546874064952135 11.993718266487122 6.818781733512878 C 12.157812593504786 6.982876060530543 12.25 7.205435562878847 12.25 7.4375 C 12.25 7.669564437121153 12.157812593504786 7.892123939469457 11.993718266487122 8.056218266487122 C 11.829623939469457 8.220312593504786 11.607064437121153 8.3125 11.375 8.3125 C 11.142935562878847 8.3125 10.920376060530543 8.220312593504786 10.756281733512878 8.056218266487122 C 10.592187406495214 7.892123939469457 10.5 7.669564437121153 10.5 7.4375 C 10.5 7.205435562878847 10.592187406495214 6.982876060530543 10.756281733512878 6.818781733512878 C 10.920376060530543 6.6546874064952135 11.142935562878847 6.5625 11.375 6.5625 Z")
																			.Margin(0,0.875)
																			.Width(14)
																			.Height(14)
																			.AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
																	)
															)
													)
											)
									),
								new AutoLayout()
									.CounterAxisAlignment(AutoLayoutAlignment.Start)
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(1440)
									.AutoLayout(isIndependentLayout: true)
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
													.Margin(24,0,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(1392)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new AutoLayout()
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(0,16,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(124.390625)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new TextBlock()
																	.Text("DcentCars")
																	.Margin(0,1,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(126)
																	.Height(29)
																	.AutoLayout(isIndependentLayout: true)
															),
														new AutoLayout()
															.CounterAxisAlignment(AutoLayoutAlignment.Start)
															.Margin(1213.8906,16,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(178.10938)
															.AutoLayout(isIndependentLayout: true)
															.Children
															(
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(0,6,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(17.5)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new Path()
																			.Data("F1 M 8.749126434326172 0 C 8.057720182785658 0 7.499126485420966 0.5585937201976776 7.499126485420966 1.25 L 7.499126485420966 1.9492188096046448 C 4.66709535118261 2.3984375596046448 2.4991263917769326 4.8515623807907104 2.4991263917769326 7.8125 L 2.4991263917769326 9.117187261581421 C 2.4991263917769326 10.890624821186066 1.893657666525974 12.613280713558197 0.788188991515254 13.996093273162842 L 0.2061577615809776 14.7265625 C -0.020404736608671176 15.00781249254942 -0.06337348112699745 15.39453100413084 0.09287651248615322 15.718749761581421 C 0.2491265060993039 16.042968519032 0.5772514777857598 16.25 0.936626455645426 16.25 L 16.56162551893728 16.25 C 16.921000496796946 16.25 17.249125729253713 16.042968519032 17.405375722866864 15.718749761581421 C 17.561625716480016 15.39453100413084 17.51865721410555 15.00781249254942 17.2920947159159 14.7265625 L 16.710062536032638 13.999999761581421 C 15.604593861021918 12.613281011581421 14.999125582805775 10.890624821186066 14.999125582805775 9.117187261581421 L 14.999125582805775 7.8125 C 14.999125582805775 4.8515623807907104 12.831157517469732 2.3984375596046448 9.999126383231376 1.9492188096046448 L 9.999126383231376 1.25 C 9.999126383231376 0.5585937201976776 9.440532685866685 0 8.749126434326172 0 Z M 8.749126434326172 3.75 L 9.061626421552473 3.75 C 11.303813889505829 3.75 13.124125659447968 5.570312440395355 13.124125659447968 7.8125 L 13.124125659447968 9.117187261581421 C 13.124125659447968 10.988281071186066 13.667094893893125 12.8125 14.674907322895626 14.375 L 2.823345247733505 14.375 C 3.8311576767360056 12.8125 4.374126315134741 10.988281071186066 4.374126315134741 9.117187261581421 L 4.374126315134741 7.8125 C 4.374126315134741 5.570312440395355 6.194438979146516 3.75 8.43662644709987 3.75 L 8.749126434326172 3.75 Z M 11.249125736090159 17.5 L 8.749126434326172 17.5 L 6.24912653651576 17.5 C 6.24912653651576 18.1640625 6.510845156608503 18.800780773162842 6.979595137447955 19.269530773162842 C 7.448345118287407 19.738280773162842 8.085063961470281 20 8.749126434326172 20 C 9.413188907182063 20 10.04990655827209 19.738280773162842 10.518656539111541 19.269530773162842 C 10.987406519950992 18.800780773162842 11.249125736090159 18.1640625 11.249125736090159 17.5 Z")
																			.Margin(0.00087348477,0,0.0008735657,0)
																			.Width(17.5)
																			.Height(20)
																			.AutoLayout(counterAlignment: AutoLayoutAlignment.Start)
																	),
																new AutoLayout()
																	.CounterAxisAlignment(AutoLayoutAlignment.Start)
																	.Margin(41.5,0,0,0)
																	.VerticalAlignment(VerticalAlignment.Top)
																	.HorizontalAlignment(HorizontalAlignment.Left)
																	.Width(136.60938)
																	.AutoLayout(isIndependentLayout: true)
																	.Children
																	(
																		new AutoLayout()
																			.CornerRadius(16)
																			.CounterAxisAlignment(AutoLayoutAlignment.Start)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(32)
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
																		new TextBlock()
																			.TextAlignment(TextAlignment.Center)
																			.Text("John Doe")
																			.Margin(40,6,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(72)
																			.Height(20)
																			.AutoLayout(isIndependentLayout: true),
																		new AutoLayout()
																			.PrimaryAxisAlignment(AutoLayoutAlignment.Center)
																			.CounterAxisAlignment(AutoLayoutAlignment.Center)
																			.Orientation(Orientation.Horizontal)
																			.Margin(120.609375,8,0,0)
																			.VerticalAlignment(VerticalAlignment.Top)
																			.HorizontalAlignment(HorizontalAlignment.Left)
																			.Width(16)
																			.Height(16)
																			.AutoLayout(isIndependentLayout: true)
																			.Children
																			(
																				new Path()
																					.Data("F1 M 6.296093463897705 7.708593845367432 C 6.686718463897705 8.099218845367432 7.321094036102295 8.099218845367432 7.711719036102295 7.708593845367432 L 13.711719512939453 1.7085938453674316 C 14.102344512939453 1.3179688453674316 14.102344512939453 0.68359375 13.711719512939453 0.29296875 C 13.321094512939453 -0.09765625 12.686718940734863 -0.09765625 12.296093940734863 0.29296875 L 7.002343654632568 5.586719036102295 L 1.708593726158142 0.2960934638977051 C 1.317968726158142 -0.09453153610229492 0.68359375 -0.09453153610229492 0.29296875 0.2960934638977051 C -0.09765625 0.6867184638977051 -0.09765625 1.3210935592651367 0.29296875 1.7117185592651367 L 6.29296875 7.711719036102295 L 6.296093463897705 7.708593845367432 Z")
																					.Margin(0.9976562,4.9976563,0.99765587,3.000782)
																					.Width(16)
																					.Height(16)
																			)
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