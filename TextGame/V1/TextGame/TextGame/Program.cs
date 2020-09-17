using System;

namespace TextGame
{
	internal class Program
	{
			public static void Main(string[] args)
			{
				char ja;
					ja = 'y';
					//ja = 'Y';
				char nein;
					nein = 'n';
					//nein = 'N';
				char rechts;
					rechts = 'r';
					//rechts = 'R';
				char links;
					links = 'l';
					//links = 'L';
				char weglaufen; 
					weglaufen = 'w';
					//weglaufen = 'W';
				char angreifen;
					angreifen = 'a';
					//angreifen = 'A';
				char reden;
					reden = 'k';
					//reden = 'K';
							
			//Console.Write("ist ein Spielstand existent? (y/n): ");
			//char spielstand = Convert.ToChar(Console.ReadLine());
			
			//while (spielstand == nein) //Spielstand Nicht Vorhanden
			{
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Clear();
					
				while (name != "" || name != " ")
				{
					Console.WriteLine($"Hallo {name}, Sie sind gegenwärtig dabei eine noch unbekannte Welt zu erforschen!.\n"); 
					Console.Write("\nWie soll diese Welt heißen: ");
					string welt = Console.ReadLine();
					
					while (welt != "" || welt != " ")
					{
						Console.Clear();
							
						Console.WriteLine($"Sie sind Erfolgreich in {welt} angekommen");
						Console.ReadLine();
						Console.Clear();
							
						Console.WriteLine("Hier haben sie zu alle grundlegenden befehle:\n");
						Console.ReadLine();
						//Console.WriteLine("Q = Programm Beenden\n");
						//Console.ReadLine();
						//Console.WriteLine("X = Programm Neustarten\n");
						//Console.ReadLine();
						Console.WriteLine("Y = Bestätigen\n");
						Console.ReadLine();
						Console.WriteLine("N = Ablehnen\n");
						Console.ReadLine();
						Console.WriteLine("R = Rechts\n");
						Console.ReadLine();
						Console.WriteLine("L = Links\n");
						Console.ReadLine();
						Console.WriteLine("A = Angreifen\n");
						Console.ReadLine();
						Console.WriteLine("W = Weglaufen\n");
						Console.ReadLine();
						Console.WriteLine("U = Unterhalten");

						Console.Clear();
						Console.Write("Haben sie dies verstanden: ");
						char verstanden = Convert.ToChar(Console.ReadLine());
							
						while (verstanden == ja)
						{
							Console.Clear();
							Console.WriteLine("Alle Befehle können in der Datei: BEFEHLE.md nachgelesen werden!");
							Console.ReadLine();
							Console.Clear();
							
							Console.Write("Wollen sie nach Rechts oder nach Links? (R/L): ");
							char R1 = Console.ReadLine()[0]; //R(1) = Richtung
							Console.Clear();
							
							while (R1 == rechts || R1 == links)
							{
								if (R1 == rechts) //Rechts
								{
									Console.Write("Sie laufen 200m nach rechts, Wollen sie sich umsehen: ");
								    char U1 = Console.ReadLine()[0]; //U(1) = Umschauen
								    Console.Clear();
									
									while (U1 == ja || U1 == nein)
									{
										if (U1 == ja) //Umschauen ja 
										{
											Console.WriteLine("Sie stehen in Mitten von Bäumen...");
											Console.ReadLine();
											Console.Clear();
											
											Console.WriteLine("Sie gehen 5m weiter und entdecken eine Truhe...");
											Console.ReadLine();
											Console.Clear();
											
											Console.WriteLine("Sie öffnen die Truhe und entdecken: \n");
											Console.ReadLine();
											Console.WriteLine("1. Ein Schwert");
											Console.ReadLine();
											Console.WriteLine("2. Eine Axt");
											Console.ReadLine();
											Console.WriteLine("3. 20 Fackeln");
											Console.ReadLine();
											Console.WriteLine("4. Drei Feuerzeuge");
											Console.ReadLine();
											Console.WriteLine($"5. Eine Topografische Karte von {welt}");
											Console.ReadLine();
											Console.Clear();
											
											Console.Write("Wollen sie die Gegenstände einpacken: ");
											char E1 = Console.ReadLine()[0]; //E(1) = Einpacken
											Console.Clear();
											
											while (E1 == ja || E1 == nein)
											{
												if (E1 == ja) //Einpacken = Ja
												{
													Console.WriteLine("Sie haben alle Gegenstände erfolgreich eingepackt!");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Mit den neu dazu gewonnen Gegenständen können sie nun (1)Holz Hacken, (2)Jagen Gehen, (3)Die Welt tiefergehend erkunden...\n");
													Console.Write("Wie wollen sie nun weiter machen: ");
													int NA1 = Convert.ToInt32(Console.ReadLine()); //na(1) = (N)ächste (A)ktion
													Console.Clear();
													
													while (NA1 == 1 || NA1 == 2 || NA1 == 3)
													{
														if (NA1 == 1) //Aktion 1 = Holz Hacken
														{
															Console.WriteLine("Sie suchen sich den Größten, Dicksten und Schönsten Baum...");
															Console.ReadLine();
															Console.Clear();
															
															Console.WriteLine("Sie haben bissher 12 Bretter eingesammelt...\n");
															Console.ReadLine();
															Console.WriteLine("13...\n");
															Console.ReadLine();
															Console.WriteLine("14...\n");
															Console.ReadLine();
															Console.WriteLine("22...");
															Console.ReadLine();
															Console.Clear();

															Console.WriteLine("Mein Beileid, ihre axt ist abgeprallt und in ihrem kopf gelanden...");
															Console.ReadLine();
															Console.Clear();
															Console.WriteLine("Sie sind an eines unnötigen und traurigen Todes verreckt!");
															Console.ReadLine();
														}
														else //Aktion 2 = Jagen Gehen && Aktion 3 = Die Welt Tiefer Erkunden
														{
															if (NA1 == 2) //Aktion 2 = Jagen Gehen
															{
																Console.WriteLine("Sie markieren sich ihre gegenwärtige position und fangen sysematisch nach essen zu suchen...");
																Console.ReadLine();
																Console.Clear();

																Console.WriteLine("Sie sind auf eine grüne wiese gelandet auf welcher viele Hasen, Hüner, Kühe und schafe frei leben...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Sie haben 3 Hasen und zwei Hühner gefangen...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Sie versuchen eine Kuh zu fangen...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Die horde Kühe fängt an zu rennen und läuft über sie drüber...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Ein paar wahnsinnige kühe haben sie gekillt...");
																Console.ReadLine();
																Console.Clear();
															}
															else //Aktion 3 = Die Welt Tiefer Erkunden
															{
																Console.WriteLine("Sie schauen sich die eigesammelte karte an und entdecken eine interessant aussehende Höhle...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Sie sind nun in der höhle angelangt...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Sie zünden eine ihrer 20 Fackeln an...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Sie entdecken sehr viele Zeichnungen an den wänden...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Jemand schleicht sich von hinten an sie ran...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Sie Bemerken diese person...");
																Console.ReadLine();
																Console.Clear();
																
																Console.WriteLine("Wollen Sie die person angreifen oder sich mit ihr unterhalten? (A/K)");
																Console.Write("Ihre Wahl: ");
																char P1 = Convert.ToChar(Console.ReadLine()); //P(1) = Person
																Console.Clear();

																while (P1 == angreifen || P1 == reden)
																{
																	if (P1 == angreifen)
																	{
																		Console.Write("Wollen sie die axt verwenden: ");
																		char WA1 = Convert.ToChar(Console.ReadLine()); //WA(1) = Waffe Axt
																		Console.Clear();

																		while (WA1 == ja || WA1 == nein) //Waffe Wählen
																		{
																			if (WA1 == ja) //Waffe = Axt
																			{
																				Console.WriteLine("Sie schlagen mit der axt drauf los...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Sie treffen...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Sie bemerken das sie nicht getroffen haben...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Sie Spüren ein stechen und sehen nur noch schwartz...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Der fremde hat ihnen in messer in die kehle gerammt...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Sie starben an einen kurzen jedoch schmerzhaften tod...");
																				Console.ReadLine();
																			}

																			else //Waffe = Schwert
																			{
																				Console.WriteLine("Sie Greifen ihr schwert und schwingen dieses...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Sie Sehen den kopf durch die lüfte fliegen...");
																				Console.ReadLine();
																				Console.Clear();
																				
																				Console.WriteLine("Sie wollen sich nun wieder hinaus begeben und rutschen in der blutlache aus...");
																				Console.ReadLine();
																				Console.Clear();

																				Console.WriteLine("Ihr genick knack und puff");
																				Console.ReadLine();
																				Console.WriteLine("schon sind sie tod...");
																				Console.ReadLine();
																			}
																		}
																	}
																	else //Unterhalten
																	{
																		string nameP1 = "Eden";
																		
																		Console.WriteLine("Sie Beginnen sich mit der person zu unterhalten...");
																		Console.ReadLine();
																		Console.Clear();

																		Console.WriteLine($"{name}: Guten Morgen");
																		Console.ReadLine();
																		Console.WriteLine($"Der Fremde: Guten tag, ich bin {nameP1}");
																		Console.ReadLine();
																		Console.WriteLine($"{name}: und ich bin {name}");
																		Console.ReadLine();
																		Console.WriteLine($"{nameP1}: Nice, Schön dich kennen zu lernen {name}");
																		Console.ReadLine();
																		Console.WriteLine($"{name}: Freut mich auch, was ist das für eine höhle?");
																		Console.ReadLine();
																		Console.WriteLine($"{nameP1}: Dies ist die höhle des todes...");
																		Console.ReadLine();
																		Console.WriteLine($"{name}: Die höhle des was???");
																		Console.ReadLine();
																		Console.WriteLine($"{nameP1}: Du hast mich schon Richtig verstanden...");
																		Console.ReadLine();
																		Console.WriteLine($"{name}: OK? Schönen tag noch...");
																		Console.ReadLine();
																		Console.Clear();
																		
																		Console.WriteLine($"Sie beginnen in richtung ausgang zu laufen und bemerken das {nameP1} nie existierte...");
																		Console.ReadLine();
																		Console.Clear();
																		
																		Console.WriteLine("Ihnen wird schwarz vor augen und sie kippen um...");
																		Console.ReadLine();
																		Console.Clear();
																		
																		Console.WriteLine("Sie beginnen all ihre innereien aus zu kotzen...");
																		Console.ReadLine();
																		Console.Clear();
																		
																		Console.WriteLine("Sie sind an giftigen gasen vereckt!");
																		Console.ReadLine();
																	}
																}
															}
														}
													}
												}
												else //Einpacken = Nein
												{
													Console.WriteLine("Sie beginnen sich weiter gerade aus zu bewegen...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Der boden unter ihren füßen gibt nach...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie Stürzen...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie Werden von hunderten speeren durchbohrt...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Nachdem sie noch zwei stunden voller qualen weiterlebten sind sie nun endlich verstorben...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie sind in einer falle verreckt!");
													Console.ReadLine();
												}
											}
										}
										else //Umschauen = Nein
										{
											Console.WriteLine("Sie laufen 25m gerade aus...");
											Console.ReadLine();
											Console.Clear();
											
											Console.Write("Ihnen begegnet ein Bär, Wollen Sie gegen ihn Kämpfen oder Rennen? (A/W): ");
											char A1 = Convert.ToChar(Console.ReadLine()); //A(1) = Angriff
											Console.Clear();
											
											while (A1 == ja || A1 == nein)
											{
												if (A1 == angreifen) //Angreifen = Ja
												{
													Console.WriteLine("Der Bär stürzt sich auf sie und reist ihren kopf mit seinen zähnhn ab...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Ihr Blut färbt alles innerhalb eines 3m radiuses Rot");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie sind, nachdem sie ein Wunderschönes kunstwerk erschufen, Qualvoll gestorben!");
													Console.ReadLine();
												}
												else //Angreifen = Nein
												{
													if (A1 == weglaufen)
													Console.WriteLine("Sie beginnen weg zu laufen...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Der Bär jagt sie...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie entkommen ihm...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Glaubten sie...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Er holt sie ein...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie entkommen ihm wirklich...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie sind entkommen...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Jedoch greift sie ein ihnen unbekanntes Löwen ähnliches fiech an...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Das fiech greif sie an und jagt ihnen seine zähne in hals...");
													Console.ReadLine();
													Console.Clear();
													
													Console.WriteLine("Sie sind langsam und schmerzhaft verblutet!");
													Console.ReadLine();
												}
											}
										}
									}
								}
 								else //Links
								{
									
								}
							}
						} 
					}
				}			
			}
		}
	}
}	