using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250116
{
	class Helsinki
	{
		public int helyezes, sportoloKszama;
		public string sportag, versenyszam;

		public Helsinki(string egysor)
		{
			string[] darabok = egysor.Trim().Split();
			helyezes = Convert.ToInt32(darabok[0]);
			sportoloKszama = Convert.ToInt32(darabok[1]);
			sportag = darabok[2];
			versenyszam = darabok[3];
		}
	}
	class Program
	{
		static Dictionary<int, int> statok = new Dictionary<int, int> { {1,0}, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 } };
		static List<Helsinki> adatok = new List<Helsinki>();
		static void Main(string[] args)
		{
			beolvasas();
			f3();
			f4();
			f5();
			f6();
			f7();
			f8();
			Console.WriteLine("Nyomj entert");
			Console.ReadLine();
		}
		static void beolvasas()
		{
			string[] beolvas = File.ReadAllLines("helsinki.txt", Encoding.UTF8);
			foreach (var item in beolvas)
			{
				adatok.Add(new Helsinki(item));
			}
		}
		static void f3()
		{
			Console.WriteLine("3. feladat: ");
			Console.WriteLine($"Pontszerző helyezések száma: {adatok.Count}");
		}
		static void f4()
		{
			Dictionary<int, int> statisztika = new Dictionary<int, int>();
			Console.WriteLine("4. feladat: ");
			foreach (var item in adatok)
			{
				if (statisztika.ContainsKey(item.helyezes))
				{
					statisztika[item.helyezes] += 1;
				}
				else
				{
					statisztika[item.helyezes] = 1;
				}
			}
			foreach (var item in statisztika)
			{
					statok[item.Key] += item.Value;
			}
            Console.WriteLine($"Arany: {statok[1]}");
			Console.WriteLine($"Ezüst: {statok[2]}");
			Console.WriteLine($"Bronz: {statok[3]}");
            Console.WriteLine($"Összesen: {statok[1] + statok[2] + statok[3]}");

		}
		static void f5()
		{
			Console.WriteLine("5. feladat");
			Console.WriteLine($"Olimpiai pontok száma: {statok[1] * 7 + statok[2] * 5 + statok[3] * 4 + statok[4] * 3 + statok[5] * 2 + statok[6]}");
		}
		static void f6()
		{
			Console.WriteLine("6. feladat: ");
			int valtozo = 0;
			foreach (var item in adatok)
			{
				if (item.sportag == "uszas")
				{
					valtozo++;
				}
				if (item.sportag == "torna")
				{
					valtozo--;
				}
			}
			if (valtozo < 0)
			{
				Console.WriteLine("Torna sportágban szereztek több érmet");
			}
			else if (valtozo > 0)
			{
				Console.WriteLine("Úszás sportágban szereztek több érmet");
			}
			else
			{
				Console.WriteLine("Egyenlő volt az érmek száma");
			}
		}
		static void f7()
		{
			string filenev = "helsinki2.txt";
			using (FileStream fs = File.Create(filenev)) { }
			foreach (var item in adatok)
			{
				string sportag;
				if (item.sportag == "kajakkenu" || item.sportag == "kajak-kenu")
				{
					sportag = "kajak-kenu";
				}
				else
				{
					sportag = item.sportag;
				}

				string ujsor = $"{item.helyezes} {item.sportoloKszama} {sportag} {item.versenyszam}\n";
				File.AppendAllText(filenev, ujsor);
			}
		}
		static void f8()
		{
			Console.WriteLine("8. feladat");
			int legnagyobb = adatok.Max(item => item.sportoloKszama);
			int indexe = adatok.FindIndex(item => item.sportoloKszama == legnagyobb);
			Console.WriteLine($"Helyezés: {adatok[indexe].helyezes}");
			Console.WriteLine($"Sportág: {adatok[indexe].sportag}");
			Console.WriteLine($"Versenyszám: {adatok[indexe].versenyszam}");
			Console.WriteLine($"Sportolók száma: {legnagyobb}");
			/*
			foreach (var item in adatok)
			{
				if (item.sportoloKszama == legnagyobb)
				{
					Console.WriteLine($"Helyezés: {item.helyezes}");
					Console.WriteLine($"Sportág: {item.sportag}");
					Console.WriteLine($"Versenyszám: {item.versenyszam}");
					Console.WriteLine($"Sportolók száma: {legnagyobb}");
					break;
				}
			}
			*/
		}
	}
}
