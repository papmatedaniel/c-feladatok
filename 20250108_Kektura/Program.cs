using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250108
{
	class Szakasz
	{
		public string kiindulNev, vegpontNev, pecsetelohely;
		public int emelkedesOsszeg, lejtesOsszeg;
		public double hossz;
		public Szakasz(string darabok)
		{
			
			string[] egysor = darabok.Trim().Split(';');
			kiindulNev = egysor[0];
			vegpontNev = egysor[1];
			hossz = Convert.ToDouble(egysor[2]);
			emelkedesOsszeg = Convert.ToInt32(egysor[3]);
			lejtesOsszeg = Convert.ToInt32(egysor[4]);
			pecsetelohely = egysor[5];

		}
	}
	class Program
	{
		static string[] beolvas;
		static int tfm;
		static List<Szakasz> szakaszok = new List<Szakasz>();
		static void Main(string[] args)
		{
			beolvasas();
			szakaszokSzama();
			teljeshossz();
			legrovidebbszakaszadatai();
			hianyoselemek();
			magasak();
			fileiras();
			Console.WriteLine("Enter");
			Console.ReadLine();

		}
		static void beolvasas()
		{
			beolvas = File.ReadAllLines("kektura.csv");
			tfm = Convert.ToInt32(beolvas[0]);
			for (int i = 1; i < beolvas.Length; i++)
			{
				szakaszok.Add(new Szakasz(beolvas[i]));
			}

		}
		static void szakaszokSzama()
		{
			Console.WriteLine($"3. feladat: Szakaszok száma: {szakaszok.Count}");
		}
		static void teljeshossz()
		{
			double szakaszOsszeg = 0;
			foreach (var item in szakaszok)
			{
				szakaszOsszeg += item.hossz;
			}
			Console.WriteLine($"4. feladat: A legrövidebb szakasz hossza: {szakaszOsszeg} km");
		}
		static void legrovidebbszakaszadatai()
		{
			Console.WriteLine("5. feladat: A Legrövidebb szakasz adatai: ");
			string kezdet = szakaszok[0].kiindulNev;
			string veg = szakaszok[0].vegpontNev;
			double tavolsag = szakaszok[0].hossz;
			foreach (var item in szakaszok)
			{
				if (item.hossz < tavolsag)
				{
					tavolsag = item.hossz;
					kezdet = item.kiindulNev;
					veg = item.vegpontNev;
				}
			}
			Console.WriteLine($"\tKezedete: {kezdet}");
			Console.WriteLine($"\tVége: {veg}");
			Console.WriteLine($"\tTávolság: {tavolsag} km");



		}
		static bool HianyosNev(string nev, string pecsetelohely)
		{
			return !nev.Contains("pecsetelohely") && pecsetelohely == "i";
		}
		static void hianyoselemek()
		{
			bool nincshianyos = true;
			Console.WriteLine("7. feladat: Hiányos állomásnevek:");
			foreach (var item in szakaszok)
			{
				if (HianyosNev(item.vegpontNev, item.pecsetelohely))
				{
					nincshianyos = false;
					Console.WriteLine($"\t{item.vegpontNev}");
				}
			}
			if (nincshianyos)
			{
				Console.WriteLine("\tNincs hiányos szakasz.");
			}
		}
		static void magasak()
		{
			Dictionary<int, string> magassagok = new Dictionary<int, string>();
			int aktualismagassag = tfm;
			foreach (var item in szakaszok)
			{
				int szintkulonbseg = item.emelkedesOsszeg - item.lejtesOsszeg;
				aktualismagassag += szintkulonbseg;
				magassagok.Add(aktualismagassag, item.vegpontNev);
			}
			Console.WriteLine("8. feladat: A túra legmagasabban fekvő végpontja: ");
			Console.WriteLine($"\tA végpont neve: {magassagok[magassagok.Keys.Max()]}");
			Console.WriteLine($"\tA végpont tergerszint feletti magassága: {magassagok.Keys.Max()} m");
		}
		static void fileiras()
		{
			string kekturafile = "kektura2.csv";
			using (FileStream fs = File.Create(kekturafile)) { }
			File.AppendAllText(kekturafile, tfm + Environment.NewLine);
			foreach (var item in szakaszok)
			{
				string vegpont;
				if (HianyosNev(item.vegpontNev, item.pecsetelohely))
				{
					vegpont = item.vegpontNev + " pecsetelohely";
				}
				else
				{
					vegpont = item.vegpontNev;
				}
				string ujsor = $"{item.kiindulNev};{vegpont};{item.hossz};{item.emelkedesOsszeg};{item.lejtesOsszeg};{item.pecsetelohely}";
				File.AppendAllText(kekturafile, ujsor + Environment.NewLine);
			}

		}
	}
}
