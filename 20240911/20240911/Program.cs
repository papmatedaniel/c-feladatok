using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240911
{
	class Program
	{
		static void Main(string[] args)
		{

			// Trapéz területe:
			/*
			Console.Write("Addj meg egy szót: ");
			string szo = Console.ReadLine();
			Console.WriteLine("A bekért szó: " + szo);
			Console.WriteLine("A bekért szó: {0}", szo);
			Console.WriteLine($"A bekért szó: {szo}");
			*/

			// 1. Négyzet kerülete és területe

			/*
			Console.Write("Add meg a négyzet oldalát: ");
			int szam = Convert.ToInt32(Console.ReadLine());
			int kerulet = szam * 4;
			int terulet = szam * szam;
			Console.WriteLine($"A kerület: {kerulet}");
			Console.WriteLine($"A terület: {terulet}");
			*/

			//2. Trapéz területe
			/*
			Console.Write("Add meg a trapáz felső alapját: ");
			int felsoAlap = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a trapáz alsó alapját: ");
			int alsoAlap = Convert.ToInt32(Console.ReadLine());
			Console.Write("Add meg a trapáz magasságűt: ");
			int magassag = Convert.ToInt32(Console.ReadLine());

			int terulet = ((alsoAlap + felsoAlap) * magassag) / 2;
			Console.Write($"A trapéz területe: {terulet}");

			*/
			/*
			int a;
			Console.Write("Adj meg egy egész számot: ");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine(a);
			Console.Write("Adj meg egy valós számot: ");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine(b);

			Console.WriteLine($"{a} + {b} = {a + b}");
			Console.WriteLine($"{a} - {b} = {a - b}");
			Console.WriteLine($"{a} * {b} = {a * b}");
			Console.WriteLine($"{a} / {b} = {a / b}");
			Console.WriteLine($"{a} % {b} = {Convert.ToDouble(a) / b}");


			Console.WriteLine("Üsd le az entert: ");
			Console.ReadLine();
			*/
		}
	}
}
