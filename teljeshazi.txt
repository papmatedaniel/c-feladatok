using System;
using System.IO;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		//1. Feladat
		string basePath = AppDomain.CurrentDomain.BaseDirectory; 
		string kozmondasokPath = Path.Combine(basePath, "kozmondasok.txt"); 
		string proverbsPath = Path.Combine(basePath, "proverbs.txt"); 
		string[] kozmondasok = File.ReadAllLines(kozmondasokPath); 
		string[] proverbs = File.ReadAllLines(proverbsPath);

		f2(proverbs);
		f3(proverbs);
		var veletlen = f4(proverbs);
		f5a(veletlen);
		f5b(veletlen);
		f5c(veletlen);
		Console.WriteLine("\n5. Feladat d) ");
		f5d(veletlen);
		f5e(veletlen);
		f5f(veletlen);
		f5g(veletlen);
		f5h(veletlen);
		var veletlenMagyar = f5i(veletlen, proverbs, kozmondasok);
		f5j(veletlenMagyar);
		Console.WriteLine("Üss entert a kilépéshez!: ");
		Console.ReadLine();
	}


	static void f2(string[] proverbs)
	{
		Console.WriteLine("\n2. Feladat.");
		Console.WriteLine($"Összesen {proverbs.Length} db. közmondást tartalmaz a file.");
	}

	static void f3(string[] proverbs)
	{
		Console.WriteLine("\n3. Feladat");
		int allSzamlalo = 0;
		foreach (string item in proverbs)
		{
			if (item.ToLower().Contains("all"))
			{
				Console.WriteLine(item);
				allSzamlalo++;
			}
		}
		Console.WriteLine($"{allSzamlalo} db. közmondásban szerepel az 'all' szó.");
	}

	static List<string> f4(string[] proverbs)
	{
		//4. Feladat
		List<string> veletlenek = new List<string>();
		Random rnd = new Random();
		for (int i = 0; i < 5; i++)
		{
			int szam = rnd.Next(proverbs.Length);
			veletlenek.Add(proverbs[szam]);
		}
		return veletlenek;
	}

	static void f5a(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat, a)");
		foreach (var item in veletlenek)
		{
			Console.WriteLine(item);
		}
	}

	static void f5b(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat b) ");
		int legnagyobbHossz = 0;
		string leghosszabb = "";

		foreach (var item in veletlenek)
		{
			if (item.Length > legnagyobbHossz)
			{
				legnagyobbHossz = item.Length;
				leghosszabb = item;
			}
		}
		Console.WriteLine($"A leghosszabb mondás: '{leghosszabb}' mely {legnagyobbHossz} karakterből áll.");
	}

	static void f5c(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat c) ");
		int betuSzamlalo = 0;
		foreach (var item in veletlenek)
		{
			foreach (var karakter in item)
			{
				if (karakter.ToString().ToLower() == "t")
				{
					betuSzamlalo++;
				}
			}
		}
		Console.WriteLine($"Összesen {betuSzamlalo} db 't' betű szerepel a kiválasztott mondásokban.");
	}

	static void f5d(List<string> veletlenek)
	{
		string maganhangzok = "aeiou";
		int maganhangzoSzamlalo = 0;

		foreach (var item in veletlenek)
		{
			foreach (var karakter in item)
			{
				if (maganhangzok.Contains(karakter.ToString().ToLower()))
				{
					maganhangzoSzamlalo++;
				}
			}
		}
		Console.WriteLine($"Összesen {maganhangzoSzamlalo} db magánhangzó van az 5 random közmondásban.");
	}

	static void f5e(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat e) ");
		int legrovidebbHossz = 1000;
		string legrovidebbMondas = "";

		foreach (string item in veletlenek)
		{
			if (item.Length < legrovidebbHossz)
			{
				legrovidebbHossz = item.Length;
				legrovidebbMondas = item;
			}
		}
		int szavakszama = legrovidebbMondas.Split().Length;

		Console.WriteLine($"A legrövidebb mondás: '{legrovidebbMondas}' mely {szavakszama - 2} szóból áll.");
	}

	static void f5f(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat f)");
		bool vane = true;
		foreach (string item in veletlenek)
		{
			if (item.Contains("gold") || item.Contains("picture"))
			{
				Console.WriteLine(item);
				vane = false;
				break;
			}
		}

		if (vane)
		{
			Console.WriteLine("Nincs a mondásokban 'picture' vagy 'gold' szó.");
		}
	}

	static void f5g(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat g)");
		veletlenek.Sort();
		foreach (string item in veletlenek)
		{
			Console.WriteLine(item);
		}
	}

	static void f5h(List<string> veletlenek)
	{
		Console.WriteLine("\n5. Feladat h)");
		HashSet<string> kulonbozoSzavak = new HashSet<string>();
		char[] irasjelek = { '.', ',', '!', '?', ';', ':' };

		foreach (string item in veletlenek)
		{
			foreach (string szo in item.Split())
			{
				string tisztitottSzo = szo.TrimEnd(irasjelek).ToLower();
				kulonbozoSzavak.Add(tisztitottSzo);
			}
		}
		Console.WriteLine($"Összesen {kulonbozoSzavak.Count-1} különböző szó szerepel a random mondásokban.");
	}
	static List<string> f5i(List<string> veletlenek, string[] proverbs, string[] kozmondasok)
	{
		Console.WriteLine("\n5. Feladat i)");

		List<string> veletlenekMagyar = new List<string>();
		foreach (string item in veletlenek)
		{
            Console.WriteLine(kozmondasok[Array.IndexOf(proverbs, item)]);
			veletlenekMagyar.Add(kozmondasok[Array.IndexOf(proverbs, item)]);
		}
		return veletlenekMagyar;
	}
	static void f5j(List<string> veletlenekMagyar)
	{
		Console.WriteLine("\n5. Feladat j)");

		f5d(veletlenekMagyar);
	}

}
