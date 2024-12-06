using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;


class Szinesz
{
	public string nev, csillJegy;
	public int ev, oscardijaSzama;

	public Szinesz(string egysor)
	{
		string[] darabok = egysor.Trim().Split(";");
		nev = darabok[0];
		ev = Convert.ToInt32(darabok[1]);
		csillJegy = darabok[2];
		if (darabok[3] == "")
		{
			oscardijaSzama = 0;
		}
		else
		{
			oscardijaSzama = Convert.ToInt32(darabok[3]);
		}
		

	}
}

class Program
{
	static List<Szinesz> szineszek = new List<Szinesz>();

	static void Main(string[] args)
	{
		f1();
		f2();
		f345();
		f6();
		f7();
		f8();
		f9();
		f10();
		Console.WriteLine("Nyomj entert: ");
		Console.ReadKey();
	}
	static void f1()
	{
		string[] beolvas = File.ReadAllLines("oscar.csv", Encoding.UTF8);
		foreach (var item in beolvas)
		{
			szineszek.Add(new Szinesz(item));
		}
	}
	static void f2()
	{
        Console.WriteLine($"2. Feladat: Színészek száma: {szineszek.Count}");
	}
	static void f345()
	{
		int oszkszinszam = 0;
		int oszkdijszama = 0;
		int nemkapott = 0;
		foreach (var item in szineszek)
		{
			if (item.oscardijaSzama > 0)
			{
				oszkszinszam++;
				oszkdijszama += item.oscardijaSzama;
			}
			else
			{
				nemkapott++;
			}
		}
        Console.WriteLine($"3. Feladat: Oscar díjas színészek száma: {oszkszinszam}");
		Console.WriteLine($"4. Feladat: Ennyien nem kaptak oscart: {nemkapott}");
		Console.WriteLine($"5. Feladat: Ennyi oscar díjat osztottak ki: {oszkdijszama}");

	}
	static void f6()
	{
		int legidlsebbSzineszSzülEve = 2000;
		string legidosebbSzineszNeve = "";
		foreach (var item in szineszek)
		{
			if (item.ev < legidlsebbSzineszSzülEve)
			{
				legidlsebbSzineszSzülEve = item.ev;
				legidosebbSzineszNeve = item.nev;
			}
		}
        Console.WriteLine($"6. Feladat: A legidősebb színész: {legidosebbSzineszNeve}");
	}
	static void f7()
	{
		int legidlsebbSzineszSzülEve = 2000;
		string legidosebbSzineszNeve = "";
		foreach (var item in szineszek)
		{
			if (item.ev < legidlsebbSzineszSzülEve && item.oscardijaSzama > 0)
			{
				legidlsebbSzineszSzülEve = item.ev;
				legidosebbSzineszNeve = item.nev;
			}
		}
		Console.WriteLine($"7. Feladat: A legidősebb Oscardíjas színész: {legidosebbSzineszNeve}");
	}
	static void f8()
	{
		int legtobbOszkardij = 0;
		string legtobbOszkardijasSzinesCsillagJegye= "";
		foreach (var item in szineszek)
		{
			if (item.oscardijaSzama > legtobbOszkardij)
			{
				legtobbOszkardij = item.oscardijaSzama;
				legtobbOszkardijasSzinesCsillagJegye = item.csillJegy;
			}
		}
		Console.WriteLine($"8. Feladat: A legtöbb oszkárdíjas színész csillagjegye: {legtobbOszkardijasSzinesCsillagJegye}");
	}
	static void f9()
	{
		int legfiatalabbSzineszSzülEve = 0;
		string legfiatalabbSzineszCsillagjegye = "";
		foreach (var item in szineszek)
		{
			if (item.ev > legfiatalabbSzineszSzülEve)
			{
				legfiatalabbSzineszSzülEve = item.ev;
				legfiatalabbSzineszCsillagjegye = item.csillJegy;
			}
		}
		Console.WriteLine($"9. Feladat: A legfiatalabb színész csillagjegye: {legfiatalabbSzineszCsillagjegye}");
	}
	static void f10()
	{
		Dictionary<string, int> statisztika = new Dictionary<string, int>();
		foreach (var item in szineszek)
		{
			if (statisztika.ContainsKey(item.csillJegy))
			{
				statisztika[item.csillJegy] += item.oscardijaSzama;
			}
			else
			{
				statisztika[item.csillJegy] = item.oscardijaSzama;
			}
		}
        Console.WriteLine("10. Feladat.");
		foreach (var item in statisztika)
		{
            Console.WriteLine($"{item.Key} : {item.Value} ");
		}
	}


}
