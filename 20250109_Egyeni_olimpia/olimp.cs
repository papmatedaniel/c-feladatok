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
		static void f2()
		{
            Console.WriteLine("2. feladat");
			HashSet<string> egyedi = new HashSet<string>();
			foreach (var item in adatok)
			{
				egyedi.Add(item.nev);
			}
			Console.WriteLine(egyedi.Count);
		}
		static void f3()
		{
            Console.WriteLine("\n3. feladt");
			HashSet<string> magasagras = new HashSet<string>();
			HashSet<string> tavolugras = new HashSet<string>();

			foreach (var item in adatok)
			{
				if (item.versenyszam == "magasugrás")
				{
					magasagras.Add(item.nev);
				}
				if (item.versenyszam == "távolugrás")
				{
					tavolugras.Add(item.nev);
				}
			}
            Console.WriteLine("Magasugrás olimpikonok");
			foreach (var item in magasagras)
			{
                Console.WriteLine(item);
			}
			Console.WriteLine("Távolugrás olimpikonok");
			foreach (var item in tavolugras)
			{
				Console.WriteLine(item);
			}


		}
		static void f4()
		{
			Console.WriteLine("\n4. feladat");
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
			string filenev = "sokszoros.txt";
			using (FileStream fs = File.Create(filenev)) { }
			foreach (var item in adatok)
			{
				if (item.nev == "Kárpáti Rudolf" || item.nev == "Kovács Pál")
				{
					string ujsor = $"{item.nev}\t{item.szulev}\t{item.olimpiaev}\t{item.hely}\t{item.sport}\t{item.versenyszam}";
					File.AppendAllText(filenev, ujsor + Environment.NewLine);
				}
			}
		}
		static void f6()
		{
			Console.WriteLine("\n6 Feladat");
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
			Console.WriteLine("\n7. feladat");
			Dictionary<int, string> szulevnev = new Dictionary<int, string>();
			foreach (var item in adatok)
			{
				if (!szulevnev.ContainsKey(item.szulev))
				{
					szulevnev.Add(item.szulev, item.nev);
				}
			}
			string legkorabbineve = szulevnev[szulevnev.Keys.Min()];
			string legkesobbineve = szulevnev[szulevnev.Keys.Max()];
			Console.WriteLine($"Legkorábban született bajnok: {legkorabbineve}");
			Console.WriteLine($"legkésőbb született bajnok: {legkesobbineve}");


		}
		static void f8()
		{
			Console.WriteLine("\n8. feladat");
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
			Console.WriteLine("\n9. feladat");
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
			Console.WriteLine("\n10. feladat");
			int lolenges = 0;
			foreach (var item in adatok)
			{
				if (item.versenyszam == "lólengés")
				{
					lolenges++;
				}
			}
			Console.WriteLine($"lólengés: {lolenges}");
            //Console.WriteLine($"lólengés: {adatok.Count(item => item.versenyszam == "lólengés")}");
		}
		static void f11()
		{
            Console.WriteLine("\n11. feladat");
			HashSet<string> lolengesek = new HashSet<string>();
			foreach (var item in adatok)
			{
				if (item.versenyszam == "lólengés")
				{
					lolengesek.Add(item.nev);
				}
			}
			foreach (var item in lolengesek)
			{
                Console.WriteLine(item);
			}
		}
		static void f12()
		{
            Console.WriteLine("\n12. feladat");
			foreach (var item in adatok)
			{
				if (item.szulev == 1981 && item.hely == "Sydney")
				{
                    Console.WriteLine(item.nev);
				}
			}
		}
		static void f13()
		{
            Console.WriteLine("\n13. feladat");
			Dictionary<string, int> gyozelmek = new Dictionary<string, int>();
			foreach (var item in adatok)
			{
				if (gyozelmek.ContainsKey(item.nev))
				{
					gyozelmek[item.nev] += 1;
				}
				else
				{
					gyozelmek[item.nev] = 1;
				}
			}
			int legnagyobbertek = gyozelmek.Values.Max();
			foreach (var item in gyozelmek)
			{
				if (item.Value == legnagyobbertek)
				{
                    Console.WriteLine(item.Key);
				}
			}
		}
		static void f14()
		{
            Console.WriteLine("\n14. feladat");
			int ermeksza = 0;
			HashSet<string> nevek = new HashSet<string>();
			foreach (var item in adatok)
			{
				if (item.sport == "úszás")
				{
					nevek.Add(item.nev);
					ermeksza++;
				}
			}
            Console.WriteLine($"Úszó bajnokok száma: {nevek.Count}");
            Console.WriteLine($"Érmek száma: {ermeksza}");
		}
	}
	  
}