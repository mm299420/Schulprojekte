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
		Console.WriteLine("1. Ein Schwert\n");
		Console.ReadLine();
		Console.WriteLine("2. Eine Axt\n");
		Console.ReadLine();
		Console.WriteLine("3. 20 Fackeln\n");
		Console.ReadLine();
		Console.WriteLine("4. Drei Feuerzeuge\n");
		Console.ReadLine();
		Console.WriteLine($"5. Eine Topografische Karte von {welt}\n");
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

				Console.WriteLine("Mit den neu dazu gewonnen Gegenständen können sie nun (1)Holz Hacken, (2)Jagen Gehen, (3) Die Welt tiefergehend erkunden...\n");
				Console.ReadLine();
				Console.Write("Wie wollen sie nun weiter machen: ");
				int NA1 = Convert.ToInt32(Console.ReadLine()); //na(1) = (N)ächste (A)ktion
				Console.Clear();

				while (NA1 == 1 || NA1 == 2 || NA1 == 3)
				{
					if (NA1 == 1) //Aktion 1 = Holz Hacken
					{

					}
					if else (NA1 ==2) //Aktion 2 = Jagen Gehen
					{

					}
					else //Aktion 3 = Die Welt Tiefer Erkunden
					{

					}
				}
			}
			else //Einpacken = Nein
			{

			}
		}
	}
	else //Umschauen = Nein
	{
		Console.WriteLine("Sie laufen 25m gerade aus...");
		Consol.ReadLine();
		Console.Clear();

		Console.WriteLine("Ihnen begegnet ein Bär, Wollen Sie gegen ihn Kämpfen oder Rennen? (A/W)");
		char A1 = Console.ReadLine{}[0]; //A(1) = Angriff
		Console.Clear();

		while (A1 == ja || A1 == nein)
		{
			if (A1 == ja) //Angreifen = Ja
			{

			}
			else //Angreifen = Nein
			{

				}
		}
}
