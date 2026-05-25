using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Etelek;

class Etel
{
    
    public string Nev;
    public int Ar;
    public string Tipus;

    public Etel(string sor)
    {
        string[] darabok = sor.Trim().Split("\t");
        Nev = darabok[0];
        Ar = Convert.ToInt32(darabok[1]);
        Tipus = darabok[2];
    }
}

//17:46
class Program
{
    public static List<Etel> adatok = new List<Etel>();
    static void Main(string[] args)
    {

        beolvasas();
        f2();
        f3();
        f4();
        f5();
        f6();
        f7();
        f8();
        f9();
        f10();
        Console.WriteLine("Hello, World!");

    }
    static void beolvasas()
    {
                
        string[] beolvas = File.ReadAllLines("etelek.txt", Encoding.UTF8);
        Console.WriteLine(beolvas.Length);
        foreach (var item in beolvas)
        {
            adatok.Add( new Etel(item));
        }
    }

    static void f2()
    {
        Console.WriteLine($"Ételek száma: {adatok.Count()}");
    }

    static void f3()
    {
        Console.WriteLine($"A levesek átlagosan: {adatok.Where(x => x.Tipus == "Leves").Average(y => y.Ar)}");
    }

    static void f4()
    {
        Console.WriteLine($"Főételek száma: {adatok.Count(x => x.Tipus == "Főétel")}");
    }

    static void f5()
    {
        foreach (var item in adatok)
        {
            if (item.Nev.ToLower().Contains("liba"))
            {
                Console.WriteLine(item.Nev);
            }
        }
    }
    static void f6()
    {
        Console.WriteLine($"A legdrágább étel {adatok.Where(x => x.Ar == adatok.Max(y => y.Ar)).ToList()[0].Nev}");
    }

    static void f7(){
        Console.WriteLine("Főétel vagy tésza?");
        string? szoveg = Console.ReadLine();
        
        if (szoveg == "Főétel")
        {
            var legolcsobb = adatok.Where(x => x.Tipus == "Főétel").OrderBy(y => y.Ar).First();
            Console.WriteLine($"A legolcsóbb főétel: {legolcsobb.Nev}");
            Console.WriteLine($"A legolcsóbb ára: {legolcsobb.Ar}");
        }else
        {
            var legolcsobbteszta = adatok.Where(x => x.Tipus == "Tészta").OrderBy(y => y.Ar).First();
            Console.WriteLine($"A legolcsóbb főétel: {legolcsobbteszta.Nev}");
            Console.WriteLine($"A legolcsóbb ára: {legolcsobbteszta.Ar}");
            var legolcsobbsalata = adatok.Where(x => x.Tipus == "Saláta").OrderBy(y => y.Ar).First();
            Console.WriteLine($"A legolcsóbb tészta: {legolcsobbsalata.Nev}");
            Console.WriteLine($"A legolcsóbb ára: {legolcsobbsalata.Ar}");
            Console.WriteLine($"ÖSszesen: {legolcsobbteszta.Ar + legolcsobbsalata.Ar}");
        }

    }
    static void f8()
    {
        foreach (var item in adatok)
        {
            if (item.Nev.ToLower().Contains("palacsinta"))
            {
                Console.WriteLine(item.Nev);
            }
        }
    }
    static void f9()
    {
        if (adatok.Any(x => x.Nev.ToLower().Contains("kacsa")))
        {
            Console.WriteLine("Volt olyan étel ami kacsából készült");
        }else
        {
            Console.WriteLine("Nem volt olyan étel ami kacsából készült");
        }
    }

    static void f10()
    {
        var leghosszabb = adatok.OrderByDescending(x => x.Nev.Length);
        Console.WriteLine($"A leghosszabb nevű étel: {leghosszabb.First().Nev} és {leghosszabb.First().Nev.Split().Count()}");
    }

}
