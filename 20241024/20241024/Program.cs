using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241024
{
    class Program
    {
        static void Main(string[] args)
        {
            //szoveg();
            //f1();
            //f2();
            //f3();
            f4();

            Console.WriteLine("Nyomd le az entert:");
            Console.ReadLine();
            
        }
        static void szoveg()
        {
            string sz = "Lorem Ipsum is simply dummy" +
      " text of the printing and typesetting industry." +
      " Lorem Ipsum has been the industry's standard dummy" +
      " text ever since the 1500s, when an unknown printer" +
      " took a galley of type and scrambled it to make a type" +
      " specimen book. It has survived not only five centuries," +
      " but also the leap into electronic typesetting, remaining" +
      " essentially unchanged. It was popularised in the 1960s with" +
      " the release of Letraset sheets containing Lorem Ipsum passages," +
      " and more recently with desktop publishing software like Aldus" +
      " PageMaker including versions of Lorem Ipsum.";

            Console.WriteLine($"A szöveg hossza: {sz.Length}");
            Console.WriteLine($"Kivágás: {sz.Substring(6,11)}");

            //kezdőindex, hossz
            Console.WriteLine();
            Console.WriteLine($"Kicserélés: {sz.Replace('L', 'Y')}");
            Console.WriteLine();
            Console.WriteLine($"Eltávolítás: {sz.Remove(4)}");
            Console.WriteLine();
            Console.WriteLine($"Eltávolítás: {sz.Remove(4,5)}");
            Console.WriteLine();
            Console.WriteLine($"Szóköz lecsapása: {sz.Trim()}");
            Console.WriteLine();
            Console.WriteLine($"Szóköz lecsapása a végéről: {sz.TrimEnd('.')}");
            Console.WriteLine();

            //feldarabolás:
            string[] szavak = sz.Split(' ');
            Console.WriteLine($"A szavak száma: {szavak.Length}");
            Console.WriteLine();
            Console.WriteLine($"Az i indexe: {sz.IndexOf('i')}");
            Console.WriteLine($"Nagybetűs: {sz.ToUpper()}");
            Console.WriteLine();
            Console.WriteLine($"Kisbetűs: {sz.ToLower()}");
            Console.WriteLine();
            Console.WriteLine($"Tartalmazza-e: {sz.Contains('L')}");
            Console.WriteLine();
            Console.WriteLine($"Tartalmazza-e: {sz.Contains('W')}");
            Console.WriteLine();
            Console.WriteLine($"{sz.Count()}");
            int db_e = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                if (sz[i] == 'e')
                {
                    db_e++;
                }
            }
            Console.WriteLine($"Az e betűk száma: {db_e}");
            Console.WriteLine($"Az e betűk száma: {sz.Split('e').Length-1}");
            Console.WriteLine($"Az e betűk száma: {sz.Count(x=>x=='e')}");


        }
        static void f1()
        {
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            for (int i = 0; i < szo.Length; i++)
            {
                Console.Write($"{szo[i]} ");
                Console.WriteLine();
            }
        }
        static void f2()
        {
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            Console.Write("Kérek egy tabubetűt: ");
            char tabu =char.Parse( Console.ReadLine());
            
            for (int i = 0; i < szo.Length; i++)
            {
               if (szo[i]!=tabu)
               {
Console.Write($"{szo[i]}");
               }
                
            }
            Console.WriteLine();
        }
        static void f3()
        {
            Console.WriteLine("Kérek egy szót: ");
            string szo = Console.ReadLine();
            for (int i = 0; i < szo.Length; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(szo[i]);
                }
            }
        }
        static void f4()
        {
            Console.Write("Kérek egy szót: ");
            string szo = Console.ReadLine();
            for (int i = 0; i < szo.Length; i++)
            {
                Console.Write($"{Encoding.ASCII.GetBytes(szo[i])} ");
            }
        }
    }
}
