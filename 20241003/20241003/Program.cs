using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241003
{
	class Program
	{
		static void Main(string[] args)
		{
			//f1();
			//f2();
			//f3();
			//f4();
			//f5();
			//f6();
			//f7();
			//f8();
			//f9();
			Console.WriteLine("Nyomj le entert.");
			Console.ReadLine();

		}
		static void f1()
		{
			/*1. Olvass be pár számot (ha kell, a darabszámot is kérje be a program), majd írd 
			ki a páratlanok számát!*/

			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}
			int paratlanok = 0;
			foreach (var item in szamok)
			{
				if (item % 2 == 1)
				{
					paratlanok++;
				}
			}
			Console.WriteLine($"Összesen {paratlanok} páratlan számot adtál meg");
		}
		static void f2()
		{
			/*
			 2. Olvass be egy pár számot (ha kell, a darabszámot is kérje be a program), majd 
			írd ki a párosok összegét!
			  */

			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			int parosok = 0;
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				if (szam % 2 == 0)
				{
					parosok += szam;
				}
			}

			Console.WriteLine($"A páros számok összege: {parosok}");
		}
		static void f3()
		{
			/*
			3. Olvass be egy pár számot (ha kell, a darabszámot is kérje be a program), majd 
			írd ki a párosokat a képernyőre, a sorszámukkal együtt, vagyis hogy hányadiknak 
			olvastad be őket!
			 */
			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}

			foreach (var item in szamok)
			{
				if (item % 2 == 0)
				{

					Console.WriteLine($"A {item} szám páros, és {szamok.IndexOf(item)} helyen adtad meg");

				}
			}
			//Console.WriteLine($"Összesen {paratlanok} páratlan számot adtál meg");

		}
		static void f4()
		{
			/*
			4. Olvass be egész számokat egy tömbbe/listába (ha kell, a darabszámot is kérje 
			be a program), majd kérj be egy egész számot. Keresd meg a tömbben az első 
			ilyen egész számot, majd írd ki a tömbindexét. Ha a tömbben nincs ilyen szám, 
			írd ki, hogy a beolvasott szám nincs a tömbben.
			 */

			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}
			Console.Write("Adj meg egy bónusz számot: ");
			int bennevane = Convert.ToInt32(Console.ReadLine());
			if (szamok.Contains(bennevane))
			{
				Console.WriteLine($"A bónusz szám a {szamok.IndexOf(bennevane)} helyen áll");
			}
			else
			{
				Console.WriteLine("A bónusz szám nincs a tömben");
			}


		}
		static void f5()
		{
			/*
			5. Olvass be egész számokat egy tömbbe/listába (ha kell, a darabszámot is kérje 
			be a program), majd kérj be egy egész számot, és mondd meg, hogy hányszor 
			szerepel a tömbben.
			 */

			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}
			Console.Write("Adj meg egy bónusz számot: ");
			int bennevane = Convert.ToInt32(Console.ReadLine());
			int szamlalo = 0;
			if (szamok.Contains(bennevane))
			{
				foreach (var item in szamok)
				{
					if (bennevane == item)
					{
						szamlalo++;
					}
				}
			}
			if (szamlalo == 0)
			{
				Console.WriteLine("A bónusz szám nincs a tömben");
			}
			else
			{
				Console.WriteLine($"A bónusz szám {szamlalo} alkalommal szerepel a listában");
			}
		}
		static void f6()
		{
			/*
			6. Olvasd be egy tömbbe/listába az osztály tanulóinak keresztneveit (ha kell, a 
			darabszámot is kérje be a program). Mondd meg, hogy egy adott keresztnevű 
			tanulóból hány jár az osztályba (a keresett nevet is kérje be a program).
			 */
			Console.Write("Hány tanuló jár az osztláyba?: ");
			int tanulokSzama = Convert.ToInt32(Console.ReadLine());
			List<string> tanuloNevek = new List<string>();
			for (int i = 0; i < tanulokSzama; i++)
			{
				Console.WriteLine("Add meg a tanuló keresztnevét: ");
				string tanuloNev = Console.ReadLine();
				tanuloNevek.Add(tanuloNev);
			}

			Console.Write("Melyik keresztnevet keresed?: ");
			string bennevane = Console.ReadLine();
			int szamlalo = 0;
			if (tanuloNevek.Contains(bennevane))
			{
				foreach (var item in tanuloNevek)
				{
					if (bennevane == item)
					{
						szamlalo++;
					}
				}
			}
			if (szamlalo == 0)
			{
				Console.WriteLine("A keresett név  nem szerepel az osztályban");
			}
			else
			{
				Console.WriteLine($"A keresett név {szamlalo} alkalommal szerepel az osztályban");
			}

		}
		static void f7()
		{
			/*
			7. Olvass be egész számokat egy tömbbe/listába (ha kell, a darabszámot is kérje 
			be a program), majd add meg a legkisebb és a legnagyobb szám különbségét!
			 */
			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}
			Console.WriteLine($"A lista legnagyobb száma: {szamok.Max()} a legkisebb pedig: {szamok.Min()}, a legnagyobb és legkisebb különbsége: {szamok.Max() - szamok.Min()}");

		}
		static void f8()
		{
			/*
			8. Olvass be egész számokat egy tömbbe/listába (ha kell, a darabszámot is kérje 
			be a program), majd írd ki a számokat nagyság szerint növekvő sorrendben.
			*/
			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}
			Console.WriteLine("A megadott számok növekvő sorrendben: ");
			szamok.Sort();
			foreach (var item in szamok)
			{
				Console.WriteLine(item);
			}



		}
		static void f9()
		{
			/*
			9. Olvass be egész számokat egy tömbbe/listába (ha kell, a darabszámot is kérje 
			be a program), majd írd ki a számokat nagyság szerint csökkenő sorrendben
			*/
			Console.Write("Hány számot akarsz beolvasni?: ");
			int hanyszam = Convert.ToInt32(Console.ReadLine());
			List<int> szamok = new List<int>();
			for (int i = 0; i < hanyszam; i++)
			{
				Console.Write("Adj meg egy számot: ");
				int szam = Convert.ToInt32(Console.ReadLine());
				szamok.Add(szam);
			}
			Console.WriteLine("A megadott számok csökkenő sorrendben: ");
			szamok.Sort();
			szamok.Reverse();
			foreach (var item in szamok)
			{
				Console.WriteLine(item);
			}
		}
	}
}
