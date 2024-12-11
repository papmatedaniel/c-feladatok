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
		static int azonosito;
		static void Main(string[] args)
		{
			f1();
			f2();
			f3();
			//f4();
			//f5();
			f6();
			f7();
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
			SortedDictionary<int, int> athaladasstat = new SortedDictionary<int, int>();
			foreach (var item in adatok)
			{
				if (athaladasstat.ContainsKey(item.azonosito))
				{
					athaladasstat[item.azonosito]++;
				}
				else
				{
					athaladasstat[item.azonosito] = 1;
				}
			}
			string athaladasokfile = "athaladas.txt";
			using (FileStream fs = File.Create(athaladasokfile))
			{

			}
			foreach (var item in athaladasstat)
			{
				string ujsor = $"{item.Key} {item.Value}";
				File.AppendAllText(athaladasokfile, ujsor + Environment.NewLine);
			}


		}
		static void f4()
		{
			Dictionary<int, List<int>> kilepstat = new Dictionary<int, List<int>>();
			foreach (var item in adatok)
			{
				if (kilepstat.ContainsKey(item.azonosito))
				{
					if (item.kibe == "be")
					{
						kilepstat[item.azonosito].Add(1);
					}
					else
					{
						kilepstat[item.azonosito].Add(0);
					}
				}
				else
				{
					if (item.kibe == "be")
					{
						kilepstat[item.azonosito] = new List<int>(1);
					}
					else
					{
						kilepstat[item.azonosito] = new List<int>(0);
					}
				}
				/*
				foreach (var item in kilepstat)
				{
					if (item[kilepstat[item].Count -1 == 0)
					{
						Console.WriteLine();
					}
				}
				*/
			}
		}
		static void f5()
		{
			//Az adott azonosítóhoz társítam a ki és beérkezés dátumát. És a köztes időt amikor bent volt. 
			//A köztes időket összegyűjteném egy statisztikába, és amelyik időpont a legtöbbször szerepel, akkor voltak bent a legtöbben.
			//tulbonyolitottam
			Dictionary<string, List<int>> idopontok = new Dictionary<string, List<int>>();
			foreach (var item in adatok)
			{
				Console.WriteLine($"{item.ora}: {item.perc} - {item.kibe}");
			}
		}
		static void f6()
		{
			Console.WriteLine("Adj meg egy azonosítót: ");
			azonosito = Convert.ToInt32(Console.ReadLine());
		}
		static void f7()
		{
			List<List<string>> bentvolt = new List<List<string>>();
			foreach (var item in adatok)
			{
				string idopont = $"{item.ora}:{item.perc}";
				if (item.kibe == "be")
				{
					Console.WriteLine(idopont);
					bentvolt.Add(new List<string>());
					bentvolt[bentvolt.Count - 1].Add(idopont);
				}
			}
		}
	}
}
