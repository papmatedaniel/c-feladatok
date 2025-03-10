using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241212
{
	class Kezilabda
	{
		public string nev, poszt, szulev, szulhely;
		public int goldb, kapulovdb, sikerhetmeter, hetmeteresprobalk, kiallitas, magassag;
		public Kezilabda(string darabok)
		{
			string[] egysor = darabok.Trim().Split(';');
			nev = egysor[0];
			goldb = Convert.ToInt32(egysor[1]);
			kapulovdb = Convert.ToInt32(egysor[2]);
			sikerhetmeter = Convert.ToInt32(egysor[3]);
			hetmeteresprobalk = Convert.ToInt32(egysor[4]);
			kiallitas = Convert.ToInt32(egysor[5]);
			poszt = egysor[6];
			szulev = egysor[7];
			magassag = Convert.ToInt32(egysor[8]);
			szulhely = egysor[9];


		}
	}
	class Program
	{
		static List<Kezilabda> adatok = new List<Kezilabda>();
		static double atlagmagassag = 0;
		static void Main(string[] args)
		{
			f1();
			f2();
			f3();
			f4();
			f5();
			f6();
			f7();
			f8();
			f9();
			f10();
			f11();
			f12();
			f13();
			f14();
			f15();
			f16();
			Console.WriteLine("ADD meg");
			Console.ReadLine();
		}
		static void f1()
		{
			string[] beolvas = File.ReadAllLines("kezieb.txt", Encoding.UTF8);
			foreach (var item in beolvas)
			{
				adatok.Add(new Kezilabda(item));
			}
		}
		static void f2()
		{
			Console.WriteLine($"2. feladat: A magyar csapatban {adatok.Count} mezőnyjátékos szerepelt");
		}
		static void f3()
		{
			SortedSet<string> beallok = new SortedSet<string>();
			foreach (var item in adatok)
			{
				if (item.poszt == "beálló")
				{
					beallok.Add(item.nev);
				}
			}
			Console.WriteLine("3. feladat: Beállók:");
			foreach (var item in beallok)
			{
				Console.WriteLine($"\t{item}");
			}
		}
		static void f4()
		{

			SortedSet<string> csapatok = new SortedSet<string>();
			foreach (var item in adatok)
			{
				csapatok.Add(item.szulhely);
			}
			Console.WriteLine("4. feladat: A játékosokat adó csapatok:");
			foreach (var item in csapatok)
			{
				Console.WriteLine($"\t{item}");
			}

		}
		static void f5()
		{

			Console.WriteLine("\n5. feladat: Öt gólnál többet dobtak:");
			SortedSet<string> dobasokszama = new SortedSet<string>();
			foreach (var item in adatok)
			{
				if (item.kapulovdb > 5)
				{
					dobasokszama.Add(item.nev);
				}
			}
			foreach (var item in dobasokszama)
			{
				Console.WriteLine($"\t{item}");
			}
		}
		static void f6()
		{
			int osszesgol = 0;
			int hetmeteresek = 0;
			foreach (var item in adatok)
			{
				osszesgol += item.goldb;
				hetmeteresek += item.sikerhetmeter;
			}

			Console.WriteLine($"\n6. feladat: A magyar csapat összesen {osszesgol} gólt lőtt, ebből {hetmeteresek} hétméterest.");
		}
		static void f7()
		{
			int hetszam = 0;
			foreach (var item in adatok)
			{
				if (item.hetmeteresprobalk > 0)
				{
					hetszam++;
				}
			}
			Console.WriteLine($"7. feladat: {hetszam} játékos dobott hétméterest.");
		}
		static void f8()
		{
			int osszbuntetes = 0;
			foreach (var item in adatok)
			{
				if (item.kiallitas > 0)
				{
					osszbuntetes += item.kiallitas;
				}
			}
			Console.WriteLine($"8. feladat: {osszbuntetes * 2} perc büntetést kapott a csapa");
		}
		static void f9()
		{
			int minikivalasztas = 0;
			string miniev = "";
			foreach (var item in adatok)
			{
				string[] szelet = item.szulev.Split('.');
				int osszenap = Convert.ToInt32(szelet[0] + szelet[1] + szelet[2]);
				if (minikivalasztas < osszenap)
				{
					minikivalasztas = osszenap;
					miniev = item.nev;
				}
			}
			Console.WriteLine($"9. feladat: A legfiatalabb játékos {miniev}.");
		}
		static void f10()
		{
			int szulettek1999ben = 0;
			foreach (var item in adatok)
			{
				if (item.szulev.Split('.')[0] == "1999")
				{
					szulettek1999ben++;
				}
			}
            Console.WriteLine($"10. feladat: 1999-ben {szulettek1999ben} játékos született.");
		}
		static void f11()
		{
			int osszmagassag = 0;
			foreach (var item in adatok)
			{
				osszmagassag += item.magassag;
			}
			atlagmagassag = osszmagassag / adatok.Count;
			Console.WriteLine($"11. feladat: A csapat átlagmagassága: {atlagmagassag} cm.");
		}
		static void f12()
		{
			
		double osszev = 0;
		foreach (var item in adatok)
		{
				osszev += 2022-Convert.ToInt32(item.szulev.Split('.')[0]);

			}
			Console.WriteLine($"\n12. feladat: A csapat átlagéletkora: {Math.Round(osszev / adatok.Count, 2)} év.");

		}
		static void f13()
		{
			int balatonfuredjatekosszam = 0;
			foreach (var item in adatok)
			{
				if (item.szulhely == "Balatonfüredi KSE")
				{
					balatonfuredjatekosszam++;
				}
			}
            Console.WriteLine($"13. feladat: A Balatonfüredi KSE {balatonfuredjatekosszam} játékost adott a válogatottnak.");
		}
		static void f14()
		{
			foreach (var item in adatok)
			{
				if (item.nev == "Lékai Máté")
				{
                    Console.WriteLine($"14. feladat: Lékai Máté a {item.szulhely}-ben játszik.");
					break;
				}
			}
		}
		static void f15()
		{
			bool nincs200 = true;
			foreach (var item in adatok)
			{
				if (item.magassag == 200)
				{
					nincs200 = false;
                    Console.WriteLine("15. feladat: Van olyan játékos, aki 200 cm magas.");
					break;
				}
			}
			if (nincs200)
			{
				Console.WriteLine("15. feladat: Nincs olyan játékos, aki 200 cm magas.");
			}
		}
		static void f16()
		{
			string magasakfile = "magasak.txt";
			using (FileStream fs = File.Create(magasakfile)) { }
			foreach (var item in adatok)
			{
				if (item.magassag > atlagmagassag)
				{
					string ujsor = $"{item.nev} {item.magassag}";
					File.AppendAllText(magasakfile, ujsor + Environment.NewLine);
				}
			}
		}
	}
}
