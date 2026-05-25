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
		f6();
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
		// Windows vagy Linux?
		bool isWindows = Path.DirectorySeparatorChar == '\\';

		// Windows → 1250, Linux → UTF-8
		Encoding encoding = isWindows
			? Encoding.GetEncoding(1250)
			: Encoding.UTF8;

		string[] beolvas = File.ReadAllLines("eredmenyek.txt", encoding);

		foreach (var item in beolvas)
		{
			versenyzok.Add(new Versenyzo(item));
		}
	}

	static void f2()
	{
		Console.WriteLine($"\n2. Feladat: {versenyzok.Count}");
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
		Console.WriteLine("\n3 Feladat: Szakmacsoportok és tanulóik száma");
		foreach (var item in versenyekstatisztika)
		{
			Console.WriteLine($"{item.Key} - {item.Value}");
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
		Console.WriteLine("\n5. Feladat: Ábrahám keresztnevű diákok adatai");
		foreach (var item in versenyzok)
		{
			if (item.neve.Split()[1] == "Ábrahám")
			{
				Console.WriteLine($"{item.helyezes} {item.neve} {item.iskola} {item.telepules} {item.eredmeny} {item.szakmacsoport} ");
			}
		}
	}
	static int minimumkivalasztas(List<Object> lista)
	{
		int mini = Convert.ToInt32(lista[0]);
		foreach (var item in lista)
		{
			if (Convert.ToInt32(item) < mini)
			{
				mini = Convert.ToInt32(item);
			}
		}
		return mini;
	}
	static void f6()
	{
		Console.WriteLine("\n6. Feladat");
		Dictionary<string, List<Object>> dobogosok = new Dictionary<string, List<object>>();
		foreach (var item in versenyzok)
		{ 
			string szakmanevek = item.szakmacsoport.ToString() + "nevek";
			string szakmajegyek = item.szakmacsoport.ToString() + "jegyek";
			if (!dobogosok.ContainsKey(szakmanevek))
			{
				dobogosok.Add(szakmanevek, new List<object>());
				dobogosok.Add(szakmajegyek, new List<object>());
			}
			dobogosok[szakmanevek].Add(item.neve);
			dobogosok[szakmajegyek].Add(item.helyezes);
		}
		foreach (var item in  new List<string> { "gépész", "informatika", "környezetvédelem" })
		{
			Console.WriteLine(item);
			for (int i = 0; i < 3; i++)
			{
				int szakmajegyekmaxi = dobogosok[item + "jegyek"].IndexOf(minimumkivalasztas(dobogosok[item + "jegyek"]));
				Console.WriteLine($"\t{i+1} {dobogosok[item + "nevek"][dobogosok[item + "jegyek"].IndexOf(minimumkivalasztas(dobogosok[item + "jegyek"]))]}");
				dobogosok[item + "jegyek"].Remove(dobogosok[item + "jegyek"][szakmajegyekmaxi]);
				dobogosok[item + "nevek"].Remove(dobogosok[item + "nevek"][szakmajegyekmaxi]);
			}
		}
	}
	static void f6_2Megoldas()
	{
        Console.WriteLine("\n6. Feladat. A szakmacsoportok dobogósai. ");
		Dictionary<string, SortedList<int, string>> dobogosok2 = new Dictionary<string, SortedList<int, string>>();
		List<string> szakmak = new List<string> { "gépész", "informatika", "környezetvédelem" };
		foreach (var szakma in szakmak)
		{
			dobogosok2[szakma] = new SortedList<int, string>();
			foreach (var item in versenyzok)
			{
				if (item.szakmacsoport == szakma) 
				{ 
					dobogosok2[szakma].Add(item.helyezes, item.neve);
				}
			}
			Console.WriteLine($"{szakma}:");
			Console.WriteLine($"\t{dobogosok2[szakma].Values[0]}");
			Console.WriteLine($"\t{dobogosok2[szakma].Values[1]}");
			Console.WriteLine($"\t{dobogosok2[szakma].Values[2]}");
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
		Console.WriteLine($"\n7. Feladat: Ennyi versenyző volt egerben: {egerversenyzok}");
	}
	static void f8()
	{
        Console.WriteLine("\n8. Feladat. Budapesti szakok");
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
            Console.WriteLine("\n9. Feladat: Budapesten több versenyző volt");
		}
		else
		{
			Console.WriteLine("\n9. Feladat: Vidéken több versenyző volt");
		}
	}
	static void f10()
	{
		int bpTop = 10000, kaposvarTop = 10000;
		string bpNev = "", kaposvarNev = "";
		foreach (var item in versenyzok)
		{
			if (item.iskola == "Eötvös")
			{
				if (item.telepules == "Budapest" && bpTop > item.helyezes)
				{
					bpTop = item.helyezes;
					bpNev = item.neve;
				}
				if (item.telepules == "Kaposvár" && kaposvarTop > item.helyezes)
				{
					kaposvarTop = item.helyezes;
					kaposvarNev = item.neve;
				}
			}
		}
        Console.WriteLine($"\n10. Feladat.\nKaposvári Eötvös legjobbja: {kaposvarNev}\n Budapest legjobbja: {bpNev}");
	}
	static void f11()
	{
        Console.WriteLine("\n11. Feladat: Báthyak adatai: ");
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
        Console.WriteLine("\n12. Feladat. Váci szakversenyzők");
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
        Console.WriteLine("\n\n14. Feladat");
		int bpetövös = 0;
		foreach (var item in versenyzok)
		{
			if (item.iskola == "Eötvös" && item.telepules == "Budapest" && item.szakmacsoport == "környezetvédelem")
			{
				bpetövös++;
			}
		}
        Console.WriteLine($"{bpetövös} diák indult");
	}
	static void f15()
	{
        Console.WriteLine("\n15. Feladat");
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
        Console.WriteLine("\n16 Feladat: ");
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
        Console.WriteLine("\n17. Feladat");
		string legjobbiskola = "";
		string legjobbszakma = "";
		string legjobbnev = "";
		int legjobbszazalek = 0;
		foreach (var item in versenyzok)
		{
			if (item.eredmeny > legjobbszazalek)
			{
				legjobbszazalek = item.eredmeny;
				legjobbszakma = item.szakmacsoport;
				legjobbiskola = item.iskola;
				legjobbnev = item.neve;
			}
		}
		Console.WriteLine(legjobbnev);
		Console.WriteLine(legjobbszakma);
        Console.WriteLine(legjobbiskola);
		Console.WriteLine(legjobbszazalek);

	}
	static void f18()
	{
        Console.WriteLine("\n18. Feladat.");
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
        Console.WriteLine("\n19. Feladat.");
		HashSet<string> iskolakszama = new HashSet<string>();
		foreach (var item in versenyzok)
		{
			iskolakszama.Add(item.iskola);
		}
        Console.WriteLine($"Összesen {iskolakszama.Count} iskolából voltak versenyzők");
	}
	static void f20()
	{
        Console.WriteLine("\n20. Feladat");
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
