using System.Text;

namespace Angolkozmodasok;

class Program
{
    static void Main(string[] args)
    {
        //f1
        List<string> proverbs = new List<string>();
        List<string> kozmondasok = new List<string>();

        string[] beolvas1 = File.ReadAllLines("proverbs.txt", Encoding.UTF8);
        string[] beolvas2 = File.ReadAllLines("kozmondasok.txt", Encoding.UTF8);
        for (int i = 0; i < beolvas1.Length; i++)
        {
            proverbs.Add(beolvas1[i]);
            kozmondasok.Add(beolvas2[i]);
        }

        //f2
        Console.WriteLine($"{proverbs.Count} db angol közmondás van.");
        
        //f3
        int szamlalo = 0;
        foreach (var item in proverbs)
        {
            if (item.ToLower().Contains("all"))
            {
                Console.WriteLine(item);
                szamlalo++;
            }
        }
        Console.WriteLine($"Az all szó {szamlalo}x szerepel");
        
        //f4
        List<string> veletlenek = new List<string>();

        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            veletlenek.Add(proverbs[rnd.Next(1, 30)]);
        }

        //5.
        Console.WriteLine("A");
        //a
        foreach (var item in veletlenek)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("B");

        //b
        string leghosszabb = veletlenek.Max();
        Console.WriteLine(leghosszabb);
        Console.WriteLine(leghosszabb.Length);

        //c
        Console.WriteLine($"c betűk száma: {veletlenek.Sum(x => x.ToLower().Count(y => y == 'c') )}");

        //d
        string maganhangzok = "aeiou";
        Console.WriteLine($"Magánhangzók száma: {veletlenek.Sum(x => x.ToLower().Count(y =>( maganhangzok.Contains(y)) == true) )}");


        //e
        string legrovidebb = "";
        foreach (var item in veletlenek)
        {
            if (item.Split().Count() < legrovidebb.Split().Count())
            {
                legrovidebb = item;
            }
        }
        Console.WriteLine(legrovidebb.Split().Count());

        //f
        bool vane = true;
        foreach (var item in veletlenek)
        {
            if (item.Contains("picture") || item.Contains("gold"))
            {
                Console.WriteLine(item);
                vane = false;
            }
        }
        if (vane)
        {
            Console.WriteLine("nincs ilyen közmondás");
        }

        //g
        veletlenek.Sort();
        foreach (var item in veletlenek)
        {
            Console.WriteLine(item);
        }

        //h
        List<string> kulonbozoek = new List<string>();
        foreach (var item in veletlenek)
        {
            foreach (var szo in item.Split())
            {
                if (!kulonbozoek.Contains(szo))
                {
                    kulonbozoek.Add(szo);
                }
            }
        }
        Console.WriteLine($"{kulonbozoek.Count()} db kulonbozo szo van");
        
        //i
        int osszeg = 0;
        foreach (var item in veletlenek)
        {
            string valami = kozmondasok[proverbs.IndexOf(item)];
            osszeg += valami.Count(y =>( maganhangzok.Contains(y)) == true);
            Console.WriteLine(valami);
        }
        Console.WriteLine(osszeg);
        Console.WriteLine("Hello, World!");



    }
}
