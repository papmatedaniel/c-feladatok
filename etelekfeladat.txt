using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Etel
{
	public string neve, tipusa;
	public int ara;

	public Etel(string egysor)
	{
		string[] darabok = egysor.Trim().Split('\t');
		neve = darabok[0];
		ara = Convert.ToInt32(darabok[1]);
		tipusa = darabok[2].ToLower();
	}
}

class Program
{
	static List<Etel> etelek = new List<Etel>();

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
		Console.WriteLine("Üss entert a kilépéshez!: ");
		Console.ReadLine();
	}

	static void f1()
	{
		//1. Feladat:
		string[] beolvas = File.ReadAllLines("etelek.txt", Encoding.Default);
		foreach (var item in beolvas)
		{
			etelek.Add(new Etel(item));
		}
	}
	static void f2()
	{
		Console.WriteLine($"\n2. Feladat: Az étterem: {etelek.Count} féle ételt kínál");
	}
	static void f3()
	{
		List<int> levesAr = new List<int>();
		foreach (var item in etelek)
		{
			if (item.tipusa == "leves")
			{
				levesAr.Add(item.ara);
			}
		}
		Console.WriteLine($"\n3. Feladat: A levesek átlagos ára: {levesAr.Sum()/levesAr.Count} ft");
	}
	static void f4()
	{
		int footelSzam = 0;
		foreach (var item in etelek)
		{
			if (item.tipusa == "főétel")
			{
				footelSzam++;
			}
		}
        Console.WriteLine($"\n4. Feladat: Ennyi főétel van: {footelSzam}");
	}
	static void f5()
	{
        Console.WriteLine("\n5. Feladat: Libás ételek");
		foreach (var item in etelek)
		{
			if (item.neve.Contains("liba"))
			{
                Console.WriteLine(item.neve); 
			}
		}
	}
	static void f6()
	{
		int legdragabbAr = 0;
		string legdragabbDesszert = "";
		foreach (var item in etelek)
		{
			if (item.tipusa == "desszert" && legdragabbAr < item.ara)
			{
				legdragabbAr = item.ara;
				legdragabbDesszert = item.neve;
			}
		}
        Console.WriteLine($"\n6. Feladat: A legdrágább desszert: {legdragabbDesszert}");
	}
	static void f7()
	{
        Console.WriteLine("\n7. Feladat: ");
        Console.Write("főétel/tészta?: ");
		string kaja = Console.ReadLine();
		int legkisebbAr = 1000000;
		string etelNeve = "";
		if (kaja == "főétel" || kaja == "tészta")
		{
			foreach (var item in etelek)
			{
				if (item.ara < legkisebbAr && item.tipusa == kaja)
				{
					legkisebbAr = item.ara;
					etelNeve = item.neve;
				}
			}
			Console.WriteLine($"\nA legolcsóbb amit ehetsz {kaja} étel az: {etelNeve} aminek az ára: {legkisebbAr}");
		}

	}
	static void f8()
	{
        Console.WriteLine("\n8. Feladat: Palacsintás ételek");
		foreach (var item in etelek)
		{
			if (item.neve.Contains("palacsinta"))
			{
                Console.WriteLine(item.neve);
			}
		}
	}
	static void f9()
	{
        Console.WriteLine($"\n9. Feladat: Van e kacsás étel, ha igen miaz?");
		bool vane = true;
		foreach (var item in etelek)
		{
			if (item.neve.Contains("kacsa"))
			{
                Console.WriteLine(item.neve);
				vane = false;
			}
		}
		if (vane)
		{
            Console.WriteLine("Az ételek között nincs olyan étel, amibe lenne kacsa felhasználva");
		}
	}
	static void f10()
	{
		string leghosszabbNev = "";
		int leghosszabbNevHossz = 0;
		int szoszam = 0;
		foreach (var item in etelek)
		{
			if (leghosszabbNevHossz < item.neve.Length)
			{
				leghosszabbNev = item.neve;
				leghosszabbNevHossz = item.neve.Length;
				szoszam = item.neve.Split(' ').Length;
			}
		}
        Console.WriteLine($"\n10. Feladat: A leghosszabb nevű étel: {leghosszabbNev} mely {szoszam} szóbol áll");


	}
}
