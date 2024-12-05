using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241205
{
	class Szinhaz
	{
		public int ora, perc, azonosito;
		public string kibe;
		public Szinhaz(string egysor)
		{
			string[] darabok = egysor.Split();
			ora = Convert.ToInt32(darabok[0]);
			perc = Convert.ToInt32(darabok[1]);
			azonosito = Convert.ToInt32(darabok[2]);
			kibe = darabok[3];

		}
	}
	class Program
	{
		static List<Szinhaz> adatok = new List<Szinhaz>();
		static void Main(string[] args)
		{
			f1();
			f2();
			Console.WriteLine("Nyomj entert");
			Console.ReadLine();
		}
		static void f1()
		{
			string[] beolvas = File.ReadAllLines("ajto.txt", Encoding.Default);
			foreach (var item in beolvas)
			{
				adatok.Add(new Szinhaz(item));
			}
		}
		static void f2()
		{
			Console.WriteLine("2. Feladat");
			foreach (var item in adatok)
			{
				Console.WriteLine(item.kibe);
			}

			int elsoBelepo = -1;
			int utolsoKilepo = -1;
			foreach (var item in adatok)
			{
				if (elsoBelepo == -1 && item.kibe == "be")
				{
					elsoBelepo = item.azonosito;
				}
				if (item.kibe == "ki")
				{
					utolsoKilepo = item.azonosito;
				}
			}
			Console.WriteLine($"Az első belépő: {elsoBelepo}");
			Console.WriteLine($"Az utolsó kilépő: {utolsoKilepo}");


		}
		static void f3()
		{

		}
	}
}
