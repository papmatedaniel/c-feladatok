using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240919
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.Négyzet kerülete és területe:
			/*
			Console.Write("Add meg a négyzet oldalának hosszát: ");
			int oldalHossz = Convert.ToInt32(Console.ReadLine());

			double terulet = Math.Pow(oldalHossz, 2);
			int kerulet = oldalHossz * 4;
			Console.WriteLine($"A négyzet területe: {terulet}");
			Console.WriteLine($"A négyzet kerulet: {kerulet}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//2.Trapéz területe
			/*
			Console.Write("Add meg a trapéz felső alapjának hosszát: ");
			int felsoAlap = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a trapéz alsó alapjának hosszát: ");
			int alsoAlap = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a trapéz magasságát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			int terulet = ((alsoAlap + felsoAlap) * magassag) / 2;
			Console.WriteLine($"A trapéz területe: {terulet}");
			Console.WriteLine("Nyomj le entert ");
			*/

			//3.Téglalap területe
			/*
			Console.Write("Add meg a téglalap egyik oldalának hosszát: ");
			int hossz = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a téglalap másik oldalának hosszát: ");
			int szelesseg = Convert.ToInt32(Console.ReadLine());

			int terulet = hossz * szelesseg;
			int kerulet = 2 * (hossz + szelesseg);
			Console.WriteLine($"A téglalap területe: {terulet}");
			Console.WriteLine($"A téglalap kerülete: {kerulet}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//4. Háromszög területe:
			/*
			Console.Write("Add meg háromszög alapjának hosszát: ");
			int alap = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg háromszög magasságát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			int terulet = (alap * magassag) / 2;
			Console.WriteLine($"A háromszög területe: {terulet}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//5. Kör kerülete és területe
			/*
			Console.Write("Add meg kör sugarát: ");
			int sugar = Convert.ToInt32(Console.ReadLine());

			double kerulet  = 2 * sugar * Math.PI;
			Console.WriteLine($"A kör kerülete: {kerulet}");
			double terulet = Math.Pow(sugar,2) * Math.PI;
			Console.WriteLine($"A kör kerülete: {terulet}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/
			//6.Négyzetgyök számítás:
			/*
			Console.Write("Adj meg egy pozitiv szamot: ");
			int szam = Convert.ToInt32(Console.ReadLine());

			double negyzetgyok = Math.Pow(szam, 0.5);
			Console.WriteLine($"A szám négyzete: {negyzetgyok}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//7. Háromszög területe Heron képlet segítségével:
			/*
			Console.Write("Add meg egy háromszög a oldalának hosszát: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg egy háromszög b oldalának hosszát: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg egy háromszög c oldalának hosszát: ");
			int c = Convert.ToInt32(Console.ReadLine());

			double s = (a + b + c) / 2;
			double ter = (s * (s - a) * (s - b) * (s - c));
			double terulet = Math.Pow(ter, 0.5);
			Console.WriteLine($"A háromszög területe: {terulet}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/
			//8.Kocka térfogata
			/*
			Console.Write("Add meg a kocka élhosszát: ");
			double oldalhossz = Convert.ToDouble(Console.ReadLine());
			double terfogat = Math.Pow(oldalhossz, 3);

			Console.WriteLine($"A kocka térfogata: {terfogat}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//9. Téglatest térfogata:
			/*
			Console.Write("Add meg a kocka élhosszát: ");
			int hosszusag = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a kocka élhosszát: ");
			int szelesseg = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a kocka élhosszát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			int terfogat = hosszusag * szelesseg * magassag;
			Console.WriteLine($"A téglatest térfogata: {terfogat}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//10. Gömb térfogata és felszíne
			/*
			Console.Write("Add meg kör sugarát: ");
			int sugar = Convert.ToInt32(Console.ReadLine());
			double felszin = 4 * Math.PI * Math.Pow(sugar, 2);
			Console.WriteLine($"A gömb felszine: {felszin}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//11.Henger térfogata és felszíne:
			/*
			Console.Write("Add meg a henger sugarát: ");
			int sugar = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a henger magasságát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			double terfogat = Math.Pow(sugar, 2) * Math.PI * magassag;
			Console.WriteLine($"A henger térfogata: {terfogat}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//12. Kúp térfogata
			/*
			Console.Write("Add meg a kúp sugarát: ");
			int sugar = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a kúp magasságát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			double terfogat = Math.Pow(sugar, 2) * Math.PI * magassag / 3;
			Console.WriteLine($"A kúp térfogata: {terfogat}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//13.Kúp felszíne:
			/*
			Console.Write("Add meg a kúp sugarát: ");
			int sugar = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a kúp magasságát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			double felszin = Math.PI * sugar * (sugar + Math.Sqrt(Math.Pow(sugar, 2) + Math.Pow(magassag, 2)));
			Console.WriteLine($"A kúp felszíne: {felszin}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//14.Gúla térfogata:
			/*
			Console.Write("Add meg a gúla területét: ");
			int alapTerulet = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a gúla magasságát: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			int terfogat = alapTerulet * magassag / 3;
			Console.WriteLine($"A gúla térfogata: {terfogat}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//15.Hőmérséklet átalakítás
			/*
			Console.Write("Add meg a hőmérsékletet Celsiusban: ");
			int celsius = Convert.ToInt32(Console.ReadLine());

			int fahrenheit = (celsius * 9 / 5) + 32;
			Console.WriteLine($"Árválva fahrenheit-be: {fahrenheit}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//16.Átlag számítás:
			/*
			List<double> szamok = new List<double>();

			for (int i = 0; i < 5; i++)
			{
				Console.Write("Adj meg egy számot: ");
				double szam = Convert.ToDouble(Console.ReadLine());
				szamok.Add(szam);
			}

			double atlag = szamok.Sum() / szamok.Count();
			Console.WriteLine($"A számok átlaga: {atlag}");
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//17. Páros vagy páratlan:
			/*
			Console.Write("Adj meg egy számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			if (szam % 2 == 0) {
				Console.WriteLine("A megadott szám páros");
			}
			else
			{
				Console.WriteLine("A megadott szám páratlan");
			}
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//18. Hányadik hatvány
			/*
			Console.Write("Add meg az alapot: ");
			double alap = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a kitevőt: ");
			double kitevo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Math.Pow(alap, kitevo));
			Console.WriteLine("Nyomj le entert ");
			Console.ReadLine();
			*/

			//19. Két szám közül a nagyobb kiválasztása


		}
	}
}
