using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20241106
{
    class Program
    {
        static string[]kozmondasok;
        static List<string> leghosszabbak = new List<string>();
        static void Main(string[] args)
        {
            
             kozmondasok = File.ReadAllLines("kozmondasok.txt",
                Encoding.Default);

            List<string> km = new List<string>();
            FileStream fs = new FileStream("kozmondasok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            while (!sr.EndOfStream)
            {
                km.Add(sr.ReadLine());
            }
            
            sr.Close();
            fs.Close();

            //f2(km);
            //f3();
            //f4();
            //f5(km);
            //f6(km);
            //f7();
            //f8();
            //f9();
            f10();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }


        static void f2(List<string> lista)
        {
            Console.WriteLine($"2. feladat (listából): A fájl {lista.Count} közmondást tartalmaz.");
            Console.WriteLine($"2. feladat (tömbből): A fájl {kozmondasok.Length} közmondást tartalmaz.");
        }
        static void f3()
        {
            Console.WriteLine("3. feladat");
            foreach (var item in kozmondasok)
            {
                if (item.ToLower().Contains("malacz"))
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void f4()
        {
            int db = 0;
            Console.WriteLine("4. feladat");
            foreach (var item in kozmondasok)
            {
                if (item.ToLower().Contains("ló"))
                {
                    db++;
                }
            }
            Console.WriteLine($"A 'ló' szót {db} darab közmondás tartalmazza.");
        }
        static void f5(List<string> lista)
        {
            //Zsolt megoldása
            int maxh = lista[0].Length;
            string maxkm = lista[0];
            foreach (var item in lista)
            {
                if (item.Length > maxh)
                {
                    maxh = item.Length;
                    maxkm = item;
                }
            }
            Console.WriteLine($"A leghosszabb közmondás {maxh} karakterből áll.");
            Console.WriteLine(maxkm);

            //Gyuri megoldása
            List<int> hossz = new List<int>();
            foreach (var item in lista)
            {
                hossz.Add(item.Length);
            }
            int mh = hossz.Max();
            Console.WriteLine($"A leghosszabb közmondás {mh} karakterből áll.");
            foreach (var item in lista)
            {
                if (item.Length==mh)
                {
                    Console.WriteLine(item);
                    leghosszabbak.Add(item);
                }
            }
        }

        static void f6(List<string> lista)
        {
            List<int> rovid = new List<int>();
            foreach (var item in lista)
            {
                rovid.Add(item.Length);
            }
            int mh = rovid.Min();
            Console.WriteLine($"A legrövidebb közmondás {mh} karakterből áll.");
            foreach (var item in lista)
            {
                if (item.Length == mh)
                {
                    Console.WriteLine(item);                   
                }
            }
        }
        static void f7()
        {
            Console.WriteLine("7. feladat: a leghosszabb közmondás 2. szava: ");
            foreach (var item in leghosszabbak)
            {
                Console.WriteLine(item.Split(' ')[1]);
            }
        }
        static void f8()
        {
            List<int> szavakszama = new List<int>();
            foreach (var item in kozmondasok)
            {
                szavakszama.Add(item.Split(' ').Length);
            }
            int msz = szavakszama.Max();
            Console.WriteLine("8. feladat: A legtöbb szóból álló közmondás:");
            foreach (var item in kozmondasok)
            {
                if (item.Split(' ').Length==msz)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void f9()
        {
            //saját
            int db = 0;
            Console.WriteLine("9. feladat");
            foreach (var item in kozmondasok)
            {
                if (item.ToLower().Contains("ű"))
                {
                    db++;
                }
            }
            Console.WriteLine($"{db} darab 'ű' betű szerepel a fájlban.");

            //nem saját
            string minden = File.ReadAllText("kozmondasok.txt", Encoding.Default);
            int darab = 0;
            foreach (char item in minden)
            {
                if (item=='ű' || item=='Ű')
                {
                    darab++;
                }
            }
            Console.WriteLine($"{darab} darab 'ű' betű szerepel a fájlban.");
        }
        static void f10()
        {
            Console.WriteLine("10. feladat");
            bool vanbenne = false;
            foreach (var item in kozmondasok)
            {
                if (item.ToLower().Contains("krajczár") && item.ToLower().Contains("forint"))
                {
                    vanbenne = true;
                    break;
                }               
            }
            Console.WriteLine(vanbenne);
            
        }
    }
}
