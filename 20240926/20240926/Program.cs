using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240926
{
	class Program
	{
		static void Main(string[] args)
		{


			//ciklusok();
			//f1();
			//f2();
			//f3();
			//f6();
			//f8();
			//f12();
			//f13();
			//f14();
			f18();
			Console.WriteLine("Nyomj entert: ");
			Console.ReadLine();




		}
		static void ciklusok()
		{
			/*
			//előírt lépésszámú, növekvényes, számlálós, for
			for (int i = 0; i < 5; i++) //int i = 0 ciklus változó inicializálása, deklarálása
			{//ciklusmag                // i < 5 ciklusban maradás feltétele
										//i++ léptető 

			}
			*/
			/*
			//elől tesztelős
			while (true)
			{

			}
			*/
			/*
			//hátul tesztelős
			do
			{

			} while (true);
			*/
			/*
			//bejáró ciklus
			foreach (var item in collection)
			{

			}
			*/

			// 15 feladat
			/*
			for (int i = 1; i <= 144; i++)
			{
				if (144 % i == 0)
				{
					Console.Write($"{i} ");
				}
			}
			Console.WriteLine();


			int cv = 1;
			while (cv <= 144)
			{
				if (144 % cv== 0)
					Console.Write($"{cv} ");
				cv++;
			}
			Console.WriteLine();
			int cv2 = 1;
			do
			{
				if (144 % cv2 == 0)
				{
					Console.Write($"{cv2} ");
				}
				cv2++;
			} while (cv2<=144);
			*/
		}

		static void f1()
		{
			//1. Írasd ki a számokat 1-től 20-ig!

			for (int i = 1; i < 21; i++)
			{
				Console.WriteLine(i);
			}

			for (int i = 1; i < 21; i++)
			{
				Console.Write($"{i} ");
			}

		}
		static void f2()
		{
			//2.Írasd ki a számokat ciklussal 15 - 92 - ig egymás mellé!

			for (int i = 15; i < 93; i++)
			{
				Console.Write($"{i} ");
			}
		}
		static void f3()
		{
			for (int i = 1; i < 31; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write($"{i} ");
				}
			}
			for (int i = 1; i < 31; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		static void f4()
		{
			Console.WriteLine("Adj meg egy pozitív számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i <= szam; i++)
			{
				Console.Write($"{i} ");
			}

		}
		static void f5()
		{
			Console.WriteLine("Adj meg egy pozitív számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i <= szam; i++)
			{
				Console.WriteLine(i);
			}

		}
		static void f6()
		{
			for (int i = 1; i <= 15; i++)
			{
				Console.WriteLine(Math.Pow(i, 2));
			}
		}
		static void f7()
		{
			for (int i = 100; i < 401; i++)
			{
				if (i % 4 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		static void f8()
		{
			for (int i = 30; i < 101; i+=9)
			{
				Console.WriteLine(i);
			}
		}
		static void f9()
		{
			for (int i = 150; i >= 40; i-= 12)
			{
				Console.WriteLine(i);
			}
		}
		static void f10()
		{
			for (int i = 100; i >= -100; i--)
			{
				if (i % 9 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		static void f11()
		{
			for (int i = -30; i < 31; i+=5)
			{
				Console.WriteLine(i);
			}
		}
		static void f12()
		{
			int szam = 3;
			for (int i = 1; i < 17; i++)
			{
				Console.WriteLine(szam);
				szam *= i;
			}
		}
		static void f13()
		{
			int szam = 2;
			for (int i = 1; i < 17; i++)
			{
				Console.WriteLine(szam);
				szam *= i;
			}
		}
		static void f14() {
			//hiba
			int szam = 7;
			for (int i = 1; i < 26; i++)
			{
				szam *= i;
				if (szam % 4 == 0)
				{
					Console.WriteLine(szam);
				}

			}
		}
		static void f15()
		{
			for (int i = 1; i < 145; i++)
			{
				if (144 % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		static void f16()
		{
			Console.WriteLine("Adj meg egy számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= szam; i++)
			{
				if (szam % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		static void f17()
		{
			Console.WriteLine("Adj meg egy számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			int osszeg = 0;
			for (int i = 1; i <= szam; i++)
			{
				if (szam % i == 0)
				{
					osszeg += i;
				}
			}
			Console.WriteLine(osszeg);
		}
		static void f18()
		{
			
			for (int i = 10; i < 100; i++)
			{
				string szoveg = Convert.ToString(i);
				int osszeg = 0;
				foreach (var item in szoveg)
				{
					osszeg += Convert.ToInt32(item);
					if (osszeg == 10)
					{

						Console.WriteLine(i);
					}
				}
			}
			
			/*
			string szoveg = "alma";
			foreach (var item in szoveg)
			{
				Console.WriteLine(item);
			}
			*/
		}
	}
}
