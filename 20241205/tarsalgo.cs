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
		static bool nemvoltbentavegen = true;
		static List<string> hanyperc = new List<string>();

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
			Console.WriteLine("2. feladat");
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
			Console.WriteLine("\n4. feladat");
			SortedDictionary<int, List<int>> kilepstat = new SortedDictionary<int, List<int>>();
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
			}
			Console.Write("A végén a társalgóban voltak: ");
			foreach (var item in kilepstat)
			{
				if (item.Value[item.Value.Count - 1] == 1)
				{
					Console.Write($" {item.Key} ");

				}
			}
            Console.WriteLine();
		}
		static void f5()
		{
			Console.WriteLine("\n5. feladat");
			int hanyanbent = 0;
			int maxi = 0;
			string maxiidopont = "";
			foreach (var item in adatok)
			{
				if (item.kibe == "be")
				{
					hanyanbent++;
				}
				else
				{
					hanyanbent--;
				}
				if (hanyanbent > maxi)
				{
					maxi = hanyanbent;
					maxiidopont = item.ora + ":" + item.perc;
				}
			}
			Console.WriteLine($"Például {maxiidopont}-kor voltak a legtöbben a társalgóban.");

		}
		static void f6()
		{
			Console.WriteLine("\n6. feladat");
			Console.Write("Adja meg a személy azonosítóját! ");
			azonosito = Convert.ToInt32(Console.ReadLine());
		}
		static void f7()
		{
			Console.WriteLine("\n7. feladat");
			List<List<string>> bentvolt = new List<List<string>>();
			foreach (var item in adatok)
			{
				if (item.azonosito == azonosito)
				{
					string idopont = $"{item.ora}:{item.perc}";
					if (item.kibe == "be")
					{
						bentvolt.Add(new List<string>());
						bentvolt[bentvolt.Count - 1].Add(idopont);
					}
					else
					{
						bentvolt[bentvolt.Count - 1].Add(idopont);
					}
				}

			}
			foreach (var item in bentvolt)
			{
				if (item.Count == 2)
				{
					hanyperc.Add($"{item[0]}-{item[1]}");
					Console.WriteLine($"{item[0]}-{item[1]}");
				}
				else
				{
					string utolsoidopont = $"{adatok[adatok.Count - 1].ora}:{adatok[adatok.Count - 1].perc}";
					nemvoltbentavegen = false;
					hanyperc.Add($"{item[0]}-{utolsoidopont}");
					Console.WriteLine($"{item[0]}-");
				}

			}

		}
		static void f8()
		{
            Console.WriteLine("\n8. feladat.");
			int osszesbentoltottido = 0;
			foreach (var item in hanyperc)
			{
				int ora1 = Convert.ToInt32(item.Split("-")[0].Split(":")[0]) * 60;
				int perc1 = Convert.ToInt32(item.Split("-")[0].Split(":")[1]);
				int percosszeg1 = ora1 + perc1;
				int ora2 = Convert.ToInt32(item.Split("-")[1].Split(":")[0]) * 60;
				int perc2 = Convert.ToInt32(item.Split("-")[1].Split(":")[1]);
				int percosszeg2 = ora2 + perc2;
				osszesbentoltottido += percosszeg2 - percosszeg1;
			}
			if (nemvoltbentavegen)
			{
				Console.WriteLine($"A(z) {azonosito}. személy összesen {osszesbentoltottido + 1} percet volt bent, a megfigyelés végén nem volt a társalgóban");

			}
			else
			{
				Console.WriteLine($"A(z) {azonosito}. személy összesen {osszesbentoltottido + 1} percet volt bent, a megfigyelés végén a társalgóban volt.");

			}

		}
	}
}
