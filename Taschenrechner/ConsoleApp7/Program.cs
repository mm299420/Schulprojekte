using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Wilkommen bei ihrem neuen Taschenrechner!");
			Console.ReadLine();
			Console.Clear();

			Console.Write("Bitte geben sie ihre erste zahl ein: ");
			Decimal x = Convert.ToDecimal(Console.ReadLine());
			Console.Clear();

			Console.Write("Bitte geben sie ihre zweite zahl ein: ");
			Decimal y = Convert.ToDecimal(Console.ReadLine());
			Console.Clear();

			Console.WriteLine("Wollen sie eine dritte zahl eingben? (nur ja und nein verfügbar!)");
			Console.Write("Ihre Entscheidung: ");
			string ergebnis = Console.ReadLine();
			Console.Clear();

			//Zwei Ziffern
			if (ergebnis == "nein" || ergebnis == "Nein")
			{
				//Durchführbare Aktionen
				Console.WriteLine("Wenn sie ihre zahl subtrahieren wollen geben sie a ein.");
				Console.WriteLine("Wenn sie ihre zahl addieren wollen geben sie b ein.");
				Console.WriteLine("Wenn sie ihre zahl dividieren wollen geben sie c ein.");
				Console.WriteLine("wenn sie ihre zahl multiplizieren wollen geben sie d ein.");

				Console.Write("\nWas wollen sie nun tun: ");
				string aktion = Console.ReadLine();
				Console.Clear();

				//Minus
				if (aktion == "a")
				{
					Console.WriteLine($"{x} - {y} = " + (x - y));
					Console.ReadLine();
				}

				//Plus
				if (aktion == "b")
				{
					Console.WriteLine($"{x} + {y} = " + (x + y));
					Console.ReadLine();
				}

				//Mal
				if (aktion == "c")
				{
					Console.WriteLine($"{x} / {y} = " + (x / y));
					Console.ReadLine();
				}

				//Geteilt
				if (aktion == "d")
				{
					Console.WriteLine($"{x} * {y} = " + (x * y));
					Console.ReadLine();
				}

				//Bei falscher eingabe
				else
				{
					Console.WriteLine("Die von ihnen gewünschte rechenart ist leider nicht verfügbar!");
					Console.Write("Bitte starten sie das programm neu...");
					Console.ReadLine();
				}

			}

			//Drei Ziffern
			if (ergebnis == "ja" || ergebnis == "Ja")
			{
				//Dritte Ziffer
				Console.Write("Bitte geben sie ihre dritte zahl ein: ");
				Decimal z = Convert.ToDecimal(Console.ReadLine());
				Console.Clear();

				//Durchführbare Aktionen
				Console.WriteLine("Wenn sie ihre zahl subtrahieren wollen geben sie a ein.");
				Console.WriteLine("Wenn sie ihre zahl addieren wollen geben sie b ein.");
				Console.WriteLine("Wenn sie ihre zahl dividieren wollen geben sie c ein.");
				Console.WriteLine("wenn sie ihre zahl multiplizieren wollen geben sie d ein.");

				Console.Write("\nWas wollen sie nun tun: ");
				string aktion = Console.ReadLine();
				Console.Clear();

				//Minus
				if (aktion == "a")
				{
					Console.WriteLine($"{x} - {y} - {z} = " + (x - y - z));
					Console.ReadLine();
				}

				//Plus
				if (aktion == "b")
				{
					Console.WriteLine($"{x} + {y} + {z} = " + (x + y + z));
					Console.ReadLine();
				}

				//Mal
				if (aktion == "c")
				{
					Console.WriteLine($"{x} / {y} / {z} = " + (x / y / z));
					Console.ReadLine();
				}

				//Geteilt
				if (aktion == "d")
				{
					Console.WriteLine($"{x} * {y} * {z} = " + (x * y * z));
					Console.ReadLine();
				}

				//Bei falscher eingabe
				else
				{
					Console.WriteLine("Die von ihnen gewünschte rechenart ist leider nicht verfügbar!");
					Console.Write("Bitte starten sie das programm neu...");
					Console.ReadLine();
				}
			}
			else
			{
				if(ergebnis != "nein" || ergebnis != "Nein" || ergebnis != "ja" || ergebnis != "Ja")
					Console.WriteLine("Sie können nur ja oder nein eingeben!");
					Console.ReadLine();
			}
			
		}
	}
}
