using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240925
{
	class Program
	{
		static void Main(string[] args)
		{
			//Elágazások
			//Egyirányú
			/*
			if (true)
			{

			}
			*/
			//Kétirányú
			/*
			if (true)
			{

			}
			else
			{

			}
			*/
			//több irányú
			/*
			if (true)
			{

			}
			else if (true)
			{

			}
			else
			{

			}
			*/
			/*
			switch (switch_on)    switch_on: változó
			{
				case érték1:    érték1: változó típusának megfelelő értéke
					utasítások1
					break;
				case érték2:
					utasítások2
					break;
				default:     ide akkor ugrik, ha a változó aktuális értéke nem szerepel a felsorolt értékek között - nem kötelező elem, ez is brake-val zárul
			}
			*/

			//f1();
			//f2();
			//f3();
			/ f5();
			Console.Write("Nyomj entert");
			Console.ReadLine();
		}
		// függvényt a class Programon, belül, Main-en kívül
		static void f1()
		{
			Console.WriteLine("Adj meg egy számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			if (szam > 0)
			{
				Console.WriteLine("pozitív ");
			}
			else
			{
				Console.WriteLine("negatív ");

			}
		}
		static void f2()
		{
			Console.WriteLine("Kérem az évszámot!: ");
			int ev = Convert.ToInt32(Console.ReadLine());
			if (ev % 4 == 0 && ev != 100 || ev % 400 == 0)
			{
				Console.WriteLine("Szököév ");
			}
			else
			{
				Console.WriteLine("Nem Szököév ");
			}

		}
		static void f3()
		{
			Console.WriteLine("Adj meg egy számot: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			if (szam % 2 == 0)
			{
				Console.WriteLine("Páros");
			}
			else
			{
				Console.WriteLine("páratlan");

			}
		}
		static void f4()
		{

		}
		static void f5()
		{
			//A 100 pont a 100%
			Console.WriteLine("Add meg hány százalékos lett a dolgozat");
			int jegy = Convert.ToInt32(Console.ReadLine());
			if (jegy > 60)
			{
				Console.WriteLine("Átment ");
			}
			else
			{
				Console.WriteLine("megbukott");
			}
		}

	}
}
