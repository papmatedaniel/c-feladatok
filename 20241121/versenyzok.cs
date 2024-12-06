using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

class Versenyzo
{
	public int helyezes, eredmeny;
	public string neve, iskola, telepules, szakmacsoport;
	public Versenyzo(string egysor)
	{
		string[] darabok = egysor.Trim().Split('\t');
		helyezes = Convert.ToInt32(darabok[0]);
		neve = darabok[1];
		iskola = darabok[2];
		telepules = darabok[3];
		eredmeny = Convert.ToInt32(darabok[4]);
		szakmacsoport = darabok[5];
	}
}

class Program
{
	static List<Versenyzo> versenyzok = new List<Versenyzo>();
	static void Main(string[] args)
	{
		f1();
		f2();
		f3();
		f4();
		f5();
		//f6();
		f6_2Megoldas();
		f7();
		f8();
		f9();
		f10();
		f11();
		f12();
		f13();
		f14();
		f15();
		f16();
		f17();
		f18();
		f19();
		f20();
		f21();
		Console.WriteLine("\nNyomj entert: ");
		Console.ReadKey();
	}
	static void f1()
	{
		string[] beolvas = File.ReadAllLines("eredmenyek.txt", Encoding.Default);
		foreach (var item in beolvas)
		{
			versenyzok.Add(new Versenyzo(item));
		}
	}
	static void f2()
	{
		Console.WriteLine($"2. Feladat: {versenyzok.Count}");
	}
	static void f3()
	{
		Dictionary<string, int> versenyekstatisztika = new Dictionary<string, int>();
		foreach (var item in versenyzok)
		{
			if (versenyekstatisztika.ContainsKey(item.szakmacsoport))
			{
				versenyekstatisztika[item.szakmacsoport]++;

			}
			else
			{
				versenyekstatisztika[item.szakmacsoport] = 1;
			}
		}
		Console.WriteLine("3 Feladat: Szakmacsoportok és tanulóik száma");
		foreach (var item in versenyekstatisztika)
		{
			Console.WriteLine($" {item.Key} : {item.Value}");
		}
	}
	static void f4()
	{
		List<(string, string)> fileEsSzakma = new List<(string, string)> { ("gepesz.txt", "gépész"), ("info.txt", "informatika"), ("kvedelem.txt", "környezetvédelem") };
		foreach (var szak in fileEsSzakma)
		{
			using (FileStream fs = File.Create(szak.Item1))
			{

			}
			foreach (var item in versenyzok)
			{
				if (item.szakmacsoport == szak.Item2)
				{
					string ujsor = $"{item.neve}\t{item.iskola}\t{item.telepules}";
					File.AppendAllText(szak.Item1, ujsor + Environment.NewLine);
				}
			}
		}
	}
	static void f5()
	{
		Console.WriteLine("5. Feladat: Ábrahám keresztnevű diákok adatai");
		foreach (var item in versenyzok)
		{
			if (item.neve.Split()[1] == "Ábrahám")
			{
				Console.WriteLine($"{item.helyezes} {item.neve} {item.iskola} {item.telepules} {item.eredmeny} {item.szakmacsoport} ");
			}
		}
	}
	static int maximumkivalasztas(List<Object> lista)
	{
		int maxi = 0;
		foreach (var item in lista)
		{
			if (Convert.ToInt32(item) > maxi)
			{
				maxi = Convert.ToInt32(item);
			}
		}
		return maxi;
	}
	static void f6()
	{
		Console.WriteLine("6. Feladat");
		Dictionary<string, List<Object>> dobogosok = new Dictionary<string, List<object>>();
		List<string> szakmak = new List<string> { "gépész", "informatika", "környezetvédelem" };
		foreach (var szakma in szakmak)
		{ 
			string szakmanevek = szakma + "nevek";
			string szakmajegyek = szakma + "jegyek";
			dobogosok.Add(szakmanevek, new List<object>());
			dobogosok.Add(szakmajegyek, new List<object>());
			foreach (var item in versenyzok)
			{
				if (item.szakmacsoport == szakma)
				{
					dobogosok[szakmanevek].Add(item.neve);
					dobogosok[szakmajegyek].Add(item.helyezes);
				}

			}

			int szakmajegyekmaxi = dobogosok[szakmajegyek].IndexOf(maximumkivalasztas(dobogosok[szakmajegyek]));
			dobogosok[szakmajegyek].Remove(dobogosok[szakmajegyek][szakmajegyekmaxi]);
			dobogosok[szakmanevek].Remove(dobogosok[szakmanevek][szakmajegyekmaxi]);

		}
		
		int gépészjegydobogos = dobogosok["gépészjegyek"].IndexOf(maximumkivalasztas(dobogosok["gépészjegyek"]));
		int informatikajegydobogos = dobogosok["informatikajegyek"].IndexOf(maximumkivalasztas(dobogosok["informatikajegyek"]));
		int környezetvédelemjegydobogos = dobogosok["környezetvédelemjegyek"].IndexOf(maximumkivalasztas(dobogosok["környezetvédelemjegyek"]));

		Console.WriteLine($"A gépészek között a dobogós: {dobogosok["gépésznevek"][gépészjegydobogos]}");
		Console.WriteLine($"Az informatikusok között a dobogós: {dobogosok["informatikanevek"][informatikajegydobogos]}");
		Console.WriteLine($"A környezetvédők között a dobogós: {dobogosok["környezetvédelemnevek"][környezetvédelemjegydobogos]}");

	}
	static void f6_2Megoldas()
	{
        Console.WriteLine("6. Feladat. A szakmacsoportok dobogósai. ");
		Dictionary<string, List<Tuple<string, int>>> dobogosok2 = new Dictionary<string, List<Tuple<string, int>>>();
		List<string> szakmak = new List<string> { "gépész", "informatika", "környezetvédelem" };
		foreach (var szakma in szakmak)
		{
			dobogosok2.Add(szakma, new List<Tuple<string, int>>());
			foreach (var item in versenyzok)
			{
				if (item.szakmacsoport == szakma) 
				{ 
					dobogosok2[szakma].Add(new Tuple<string, int>(item.neve, item.helyezes)); 
				}
			}
			dobogosok2[szakma].Sort((a, b) => a.Item2.CompareTo(b.Item2));
            Console.WriteLine($"{szakma}: {(dobogosok2[szakma][dobogosok2[szakma].Count - 2]).Item1}");
		}
	}
	static void f7()
	{
		int egerversenyzok = 0;
		foreach (var item in versenyzok)
		{
			if (item.telepules == "Eger")
			{
				egerversenyzok++;
			}
		}
		Console.WriteLine($"7. Feladat: {egerversenyzok}");
	}
	static void f8()
	{
        Console.WriteLine("8. Feladat. Budapesti szakok");
		Dictionary<string, int> budapestiversenyzok = new Dictionary<string, int>();
		foreach (var item in versenyzok)
		{
			if (item.telepules == "Budapest")
			{
				if (budapestiversenyzok.ContainsKey(item.szakmacsoport))
				{
					budapestiversenyzok[item.szakmacsoport]++;
				}
				else
				{
					budapestiversenyzok[item.szakmacsoport] = 1;
				}
			}
		}
		foreach (var item in budapestiversenyzok)
		{
            Console.WriteLine($"{item.Key} : {item.Value}");
		}
	}
	static void f9()
	{
		int bp = 0, videk = 0;
		foreach (var item in versenyzok)
		{
			if (item.szakmacsoport == "környezetvédelem")
			{
				if (item.telepules == "Budapest")
				{
					bp++;
				}
				else
				{
					videk++;
				}
			}
		}
		if (bp > videk)
		{
            Console.WriteLine("9. Feladat: Budapesten több versenyző volt");
		}
		else
		{
			Console.WriteLine("9. Feladat: Vidéken több versenyző volt");
		}
	}
	static void f10()
	{
		int bpTop = 0, kaposvarTop = 0;
		string bpNev = "", kaposvarNev = "";
		foreach (var item in versenyzok)
		{
			if (item.iskola == "Eötvös")
			{
				if (item.telepules == "Budapest" && bpTop < item.helyezes)
				{
					bpTop++;
					bpNev = item.neve;
				}
				if (item.telepules == "Kaposvár" && kaposvarTop < item.helyezes)
				{
					kaposvarTop++;
					kaposvarNev = item.neve;
				}
			}
		}
        Console.WriteLine($"10. Feladat. Kaposvári Eötvös legjobbja: {kaposvarNev}, Budapest legjobbja: {bpNev}");
	}
	static void f11()
	{
        Console.WriteLine("11. Feladat: Báthyak adatai: ");
		foreach (var item in versenyzok)
		{
			if (item.iskola == "Bláthy")
			{
                Console.WriteLine($"{item.helyezes}, {item.neve}, {item.iskola}, {item.telepules}, {item.szakmacsoport}");
			}
		}
	}
	static void f12()
	{
        Console.WriteLine("12. Feladat. Váci szakversenyzők");
		HashSet<string> VáciSzakmak = new HashSet<string>();
		foreach (var item in versenyzok)
		{
			if (item.telepules == "Vác")
			{
				VáciSzakmak.Add(item.szakmacsoport);
			}
		}
		foreach (var item in VáciSzakmak)
		{
            Console.WriteLine(item);
		}
	}
	static void f13()
	{
        Console.WriteLine("\n13. Feladat: Csongrádi szakmahelyezesek");
		Dictionary<string, List<int>> csongradiHelyezesek = new Dictionary<string, List<int>>();
		foreach (var item in versenyzok)
		{
			if (item.telepules == "Csongrád")
			{
				if (csongradiHelyezesek.ContainsKey(item.szakmacsoport))
				{
					csongradiHelyezesek[item.szakmacsoport].Add(item.helyezes);
				}
				else
				{
					csongradiHelyezesek.Add(item.szakmacsoport, new List<int>());
					csongradiHelyezesek[item.szakmacsoport].Add(item.helyezes);

				}
			}
		}
		foreach (var item in csongradiHelyezesek)
		{
			Console.Write($"\n{item.Key}: ");
			foreach (var item2 in item.Value)
			{
				Console.Write(item2 + ", ");
			}

		}
	}
	static void f14()
	{
        Console.WriteLine("\n14. Feladat");
		int bpetövös = 0;
		foreach (var item in versenyzok)
		{
			if (item.iskola == "Eötvös" && item.telepules == "Budapest")
			{
				bpetövös++;
			}
		}
        Console.WriteLine($"{bpetövös} diák indult");
	}
	static void f15()
	{
        Console.WriteLine("15. Feladat");
		foreach (var item in versenyzok)
		{
			if (item.telepules == "Dombóvár" || item.telepules == "Püspökladány")
			{
				Console.WriteLine(item.neve);
			}
		}
	}
	static void f16()
	{
        Console.WriteLine("16 Feladat: ");
		string ganziskola = "";
		int tanszama = 0;
		foreach (var item in versenyzok)
		{
			if (item.iskola == "Ganz")
			{
				ganziskola = item.telepules;
				tanszama++;
			}
		}
        Console.WriteLine($"Ganz iskola {ganziskola} településen van, {tanszama} diák van itt");
	}
	static void f17()
	{
        Console.WriteLine("17. Feladat");
		string legjobbiskola = "";
		string legjobbszakma = "";
		int legjobbszazalek = 0;
		foreach (var item in versenyzok)
		{
			if (item.eredmeny > legjobbszazalek)
			{
				legjobbszazalek = item.eredmeny;
				legjobbszakma = item.szakmacsoport;
				legjobbiskola = item.iskola;
			}
		}
        Console.WriteLine(legjobbiskola);
		Console.WriteLine(legjobbszakma);
		Console.WriteLine(legjobbszazalek);

	}
	static void f18()
	{
        Console.WriteLine("18. Feladat.");
		int molnar = 0;
		int nagy = 0;
		foreach (var item in versenyzok)
		{
			if (item.neve.Split()[0] == "Molnár")
			{
				molnar++;
			}
			if (item.neve.Split()[0] == "Nagy")
			{
				nagy++;
			}
		}
		if (nagy > molnar)
		{
            Console.WriteLine("Nagy vezetéknevűből volt több versenyző");
		}
		else
		{
            Console.WriteLine("Molnár vezetéknevűből volt több versenyző.");
		}
	}
	static void f19()
	{
        Console.WriteLine("19. Feladat.");
		HashSet<string> iskolakszama = new HashSet<string>();
		foreach (var item in versenyzok)
		{
			iskolakszama.Add(item.iskola);
		}
        Console.WriteLine($"Összesen {iskolakszama.Count} iskolából voltak versenyzők");
	}
	static void f20()
	{
        Console.WriteLine("20. Feladat");
		Dictionary<string, int> iskolakversenyzoi = new Dictionary<string, int>();
		foreach (var item in versenyzok)
		{
			if (iskolakversenyzoi.ContainsKey(item.iskola))
			{
				iskolakversenyzoi[item.iskola]++;
			}
			else
			{
				iskolakversenyzoi[item.iskola] = 1;

			}
		}
		int legtobbisk = 0;
		string legtobbisknev = "";
		foreach (var item in iskolakversenyzoi)
		{
			if (item.Value > legtobbisk)
			{
				legtobbisk = item.Value;
				legtobbisknev = item.Key;
			}
		}
		Console.WriteLine($"A legtöbben a {legtobbisknev}-ból jöttek."); 
	}
	static void f21()
	{
		Dictionary<string, int> iskolakk = new Dictionary<string, int>();
		foreach (var item in versenyzok)
		{
			string uj = item.iskola + '\t' + item.telepules;
			if (iskolakk.ContainsKey(uj))
			{
				iskolakk[uj]++;
			}
			else
			{
				iskolakk[uj] = 1;
			}
		}
		string szakFile = "resztvevok.txt";
		using (FileStream fs = File.Create(szakFile))
		{

		}
		foreach (var item in iskolakk)
		{
			string ujsor = $"{item.Key.Split('\t')[0]}\t{item.Key.Split('\t')[1]}\t{item.Value}";
			File.AppendAllText(szakFile, ujsor + Environment.NewLine);
		}
	}
}
