using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241204
{


	class Lift
	{
		public int sorszam, indul, cel;
		public string idopont;
		public Lift(string egysor)
		{
			string[] darabok = egysor.Trim().Split();
			idopont = darabok[0];
			sorszam = Convert.ToInt32(darabok[1]);
			indul = Convert.ToInt32(darabok[2]);
			cel = Convert.ToInt32(darabok[3]);

		}
	}
	class Program
	{
		static List<Lift> adatok = new List<Lift>();
		static int kartyaszam;
		static int celszint;
		static void Main(string[] args)
		{
			f1();
			f2();
			f3();
			f4();
			f5();
			f6();
			f7();
			Console.WriteLine("Nyomj entert");
			Console.ReadLine();

		}
		static void f1()
		{
			string[] beolvass = File.ReadAllLines("lift.txt", Encoding.Default);
			foreach (var item in beolvass)
			{
				adatok.Add(new Lift(item));
			}
		}
		static void f2()
		{
			Console.WriteLine($"3. feladat: Összes lifthasználat: {adatok.Count}");
		}
		static void f3()
		{
			Console.WriteLine($"4. Fealadat: Időszak: {adatok[0].idopont} - {adatok[adatok.Count - 1].idopont}");

		}
		static void f4()
		{

			List<int> maxii = new List<int>();
			foreach (var item in adatok)
			{
				maxii.Add(item.cel);
			}
			Console.WriteLine($"5. Feladat: Célszint max: { maxii.Max()}");
		}
		static void f5()
		{
			Console.WriteLine("6. Feladat: ");
			try 
			{	        
					Console.Write("\tKártya száma: ");
					kartyaszam = Convert.ToInt32(Console.ReadLine());

					Console.Write("\n\tCélszint száma: ");
					celszint = Convert.ToInt32(Console.ReadLine());

			}
			catch (Exception)
			{
				kartyaszam = 5;
				celszint = 5;
			}
		}
		static void f6()
		{
			bool nemutaztak = true;
			foreach (var item in adatok)
			{	
				if (item.cel == celszint && item.sorszam == kartyaszam)
				{
					nemutaztak = false;
					Console.WriteLine($"7. Feladaat: A(z) {kartyaszam}. kártyával utaztak a(z) {celszint}. emeletre!");
					break;				
				}
			}
			if (nemutaztak)
			{
				Console.WriteLine($"7. Feladaat: A(z) {kartyaszam}. kártyával nem utaztak a(z) {celszint}. emeletre!");

			}


		}
		static void f7()
		{
			Console.WriteLine("8. feladat: Statisztika");
			Dictionary<string, int> statisztika = new Dictionary<string, int>();
			foreach (var item in adatok)
			{
				if (statisztika.ContainsKey(item.idopont))
				{
					statisztika[item.idopont]++;
				}
				else
				{
					statisztika[item.idopont] = 1;
				}
			}
			foreach (var item in statisztika)
			{
				Console.WriteLine($"\t{item.Key} - {item.Value}x");
			}
		}
	}
}



