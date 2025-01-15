using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250109
{
	class Bajnok
	{
		public string nev, hely, sport, versenyszam;
		public int szulev, olimpiaev;
		public Bajnok(string egysor)
		{
			string[] darabok = egysor.Trim().Split('\t');
			nev = darabok[0];
			szulev = Convert.ToInt32(darabok[1]);
			olimpiaev = Convert.ToInt32(darabok[2]);
			hely = darabok[3];
			sport = darabok[4];
			versenyszam = darabok[5];
		}
	}

	class Program
	{
		public static List<Bajnok> adatok = new List<Bajnok>();
		static void Main(string[] args)
		{
			beolvas();
			f1();
			//f2();
			f4();
			f6();
			f7();
			f8();
			f9();
			f10();
			Console.WriteLine("Nyomj entert");
			Console.ReadLine();
		}
		static void beolvas()
		{
			string[] beolvasas = File.ReadAllLines("egyeni.txt", Encoding.Default);
			foreach (var item in beolvasas)
			{
				adatok.Add(new Bajnok(item));
			}
		}
		static void f1()
		{
			Console.WriteLine(adatok.Count);
		}
		static void f2()
		{
			HashSet<string> egyedi = new HashSet<string>();
			foreach (var item in adatok)
			{
				egyedi.Add(item.nev);
			}
			Console.WriteLine(egyedi.Count);
		}
		static void f3()
		{
			Dictionary<int, string> magasugras = new Dictionary<int, string>();
			Dictionary<int, string> tavolugras = new Dictionary<int, string>();
			/*
			foreach (var item in adatok)
			{
				if (item.versenyszam == "magasugrás")
				{
					magasugras.Add(item.)
				}
			}
			*/
			//Mi alapján rangsoroljuk a versenyzőket?
		}
		static void f4()
		{
			Console.WriteLine("4. feladat");
			foreach (var item in adatok)
			{
				
				if (item.versenyszam == "kalapácsvetés")
				{
					Console.WriteLine($"{item.nev} - {item.olimpiaev}");
				}
				
			}
		}
		static void f5()
		{
			//file írás
		}
		static void f6()
		{

			Console.WriteLine("6 Feladat");
			foreach (var item in adatok)
			{
				if (item.nev == "Keleti Ágnes")
				{
					Console.WriteLine(item.versenyszam);
				}
			}
		}
		static void f7()
		{
			Console.WriteLine("7. feladat");
			Dictionary<int, string> szulevnev = new Dictionary<int, string>();
			foreach (var item in adatok)
			{
				if (szulevnev.ContainsKey(item.szulev))
				{
					szulevnev.Add(item.szulev, item.nev);
				}
			}

			//string legkorabbanszuletett = szulevnev[szulevnev.Keys()]
			int legkorabbiev = 2013;
			string legkorabbinev = "";
			int legkesobbiev = 0;
			string legkesobbinev = "";
			foreach (var item in adatok)
			{
				if (item.szulev < legkorabbiev)
				{
					legkorabbiev = item.szulev;
					legkorabbinev = item.nev;
				}
				if (item.szulev > legkesobbiev)
				{
					legkesobbiev = item.szulev;
					legkesobbinev = item.nev;
				}
			}
			Console.WriteLine($"Legkorábban született bajnok: {legkorabbinev}");
			Console.WriteLine($"legkésőbb született bajnok: {legkesobbinev}");


		}
		static void f8()
		{
			Console.WriteLine("8. feladat");
			bool nemszuletett = true;
			foreach (var item in adatok)
			{
				if (item.szulev == 1966)
				{
					Console.WriteLine(item.nev);
					nemszuletett = false;
				}
			}
			if (nemszuletett)
			{
				Console.WriteLine("1966-ban nem született senki.");
			}
		}
		static void f9()
		{
			Console.WriteLine("9. feladat");
			int szamlalo2012 = 0;
			foreach (var item in adatok)
			{
				if (item.olimpiaev == 2012)
				{
					szamlalo2012++;
				}
			}
			Console.WriteLine($"2012-ben {szamlalo2012}-en kaptak aranyérmet");
		}
		static void f10()
		{
			Console.WriteLine("10. feladat");
			int lolenges = 0;
			foreach (var item in adatok)
			{
				if (item.versenyszam == "lólengés")
				{
					lolenges++;
				}
			}
			Console.WriteLine($"lólengés {lolenges}");
		}
	}

}
