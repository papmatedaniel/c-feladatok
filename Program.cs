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
			Console.WriteLine(beolvas.Length-1);
		}
		static void teljeshossz()
		{
			double szakaszOsszeg = 0;
			foreach (var item in szakaszok)
			{
				szakaszOsszeg += item.hossz;
			}
			Console.WriteLine(szakaszOsszeg);
		}
		static void legrovidebbszakaszadatai()
		{
			string kezdet = "";
			string veg = "";
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
			Console.WriteLine(kezdet);
			Console.WriteLine(veg);
			Console.WriteLine(tavolsag);


		}
	}
}
