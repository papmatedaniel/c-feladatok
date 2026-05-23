using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241002
{
	class Program
	{
		static void Main(string[] args)
		{
			//tömb - vektor(1 dimenziós)
			// tipus[] nev=new tipus[elemek száma];
			Random rnd = new Random();

			int[] szamok = new int[10];
			szamok[0] = rnd.Next(1, 100);
			for (int i = 1; i < szamok.Length; i++)
			{
				szamok[i] = rnd.Next(1, 100);
			}
			foreach (var item in szamok)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();

			//lista 
			//List<tipus> nev=new List<int>();
			List<int> veletlenek = new List<int>();
			for (int i = 0; i < 10; i++)
			{
				veletlenek.Add(rnd.Next(1, 100));
				
			}
			foreach (var item in veletlenek)
			{
				Console.Write($"{item} ");
			}


			Console.WriteLine();
			Console.WriteLine($"A lista elemszáma: {veletlenek.Count} a lista kapacitása: {veletlenek.Capacity} a lista hetedik eleme: {veletlenek[6]} ");
			Console.WriteLine($"A lista elemeinek összege: {veletlenek.Sum()}");
			Console.WriteLine($"A tömb elemeinek összege: {szamok.Sum()}");
			Console.WriteLine($"A lista elemeinek átlaga: {veletlenek.Average()}");
			Console.WriteLine($"A tömb elemeinek átlaga: {szamok.Average()}");
			Console.WriteLine($"A lista legnagyobb eleme: {veletlenek.Max()}");
			Console.WriteLine($"A tömb legnagyobb eleme: {szamok.Max()}");
			Console.WriteLine($"A lista legkisebb eleme: {veletlenek.Min()}");
			Console.WriteLine($"A tömb legkisebb eleme: {szamok.Min()}");
			Console.WriteLine($"A lista elemeinek száma: {veletlenek.Count()}");
			Console.WriteLine($"A tömb legkisebb eleme: {szamok.Length}");
			Array.Sort(szamok);
			veletlenek.Sort();
			foreach (var item in veletlenek)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
			veletlenek.Reverse();
			foreach (var item in veletlenek)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
			foreach (var item in szamok)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();




			Console.WriteLine("Üsd le az entert");
			Console.ReadLine();
		}
	}
}
