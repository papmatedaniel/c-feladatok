using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {

        //Feladat: Írj egy programot, amely megkérdezi a felhasználót, hogy hány prímszámot szeretne látni, majd kiírja az első N prímszámot.

        Console.Write("Hány prímszámot irassunk ki: ");
        int szam = Convert.ToInt32(Console.ReadLine());
        int szamlalo = 2;

        while (szam != 0)
        {
            
            if (Prime(szamlalo))
            {
                szam--;
                Console.WriteLine(szamlalo);

			}
			szamlalo++;

		}
		Console.ReadKey();
    }

    static bool Prime(int x)
    {
        List<int> lista = new List<int>();
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                lista.Add(i);

			}
        }

        return (lista.Count == 2);
    }



}
