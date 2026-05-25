using System.Text;

namespace Kezilabda;

class Kezilabda
{
    
    public string Nev;
    public int Golokszama;
    public int Kapulovesek;
    public int SikeresHetmeteres;
    public int HetmeresProba;
    public int Ketperceskiallitasok;
    public string Poszt;
    public DateTime Szuletesive;
    public int Magassag;
    public string Csapatnev;

    public Kezilabda(string egysor)
    {
        string[] darabok = egysor.Trim().Split(';');
        Nev = darabok[0];
        Golokszama = int.Parse(darabok[1]);
        Kapulovesek = int.Parse(darabok[2]);
        SikeresHetmeteres = int.Parse(darabok[3]);
        HetmeresProba = int.Parse(darabok[4]);
        Ketperceskiallitasok = int.Parse(darabok[5]);
        Poszt = darabok[6];
        Szuletesive = Convert.ToDateTime(darabok[7]);
        Magassag = int.Parse(darabok[8]);
        Csapatnev = darabok[9];
    }
}
class Program
{

    public static List<Kezilabda> adatok = new List<Kezilabda>();
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
        f11();
        f12();
        f13();
        f14();
        f15();
        f16();
        Console.WriteLine("Hello, World!");
    }

    static void beolvasas()
    {
        string[] beolvas = File.ReadAllLines("kezieb.txt", Encoding.UTF8);
        foreach (var item in beolvas)
        {
            adatok.Add(new Kezilabda(item));
        }
    }

    static void f2()
    {
        Console.WriteLine($"2. feladat: A mgayar csapatban {adatok.Count()} mezőnyjátékos szerepelt");
    }

    static void f3()
    {
        Console.WriteLine("3. feladat: Beállók: ");
        foreach (var item in adatok.Where(x => x.Poszt == "beálló").OrderBy(y => y.Nev))
        {
            Console.WriteLine($"\t{item.Nev}");
        }
    }
    static void f4()
    {
        Console.WriteLine("4. feladat: A játékosokat adó csapatok: ");
        foreach (var item in adatok.GroupBy(x => x.Csapatnev).OrderBy(y => y.Key))
        {
            Console.WriteLine($"\t{item.Key}");
        }
    }

    static void f5()
    {
        Console.WriteLine("5. feladat: Öt gólnál többet dobtak:");
        foreach (var item in adatok.Where(x => x.Golokszama > 5).OrderBy(y => y.Nev))
        {
            Console.WriteLine($"\t{item.Nev}");
        }
    }

    static void f6()
    {
        int osszeg =  adatok.Sum(x => x.Golokszama);
        int hetmet = adatok.Sum(x => x.SikeresHetmeteres);
        Console.WriteLine($"6. fleadat: A magyar csapat összesen: {osszeg} ebből {hetmet} hétméterest.");
        Console.WriteLine();
    }

    static void f7()
    {
        Console.WriteLine($"7. feladat: {adatok.Count(x => x.SikeresHetmeteres > 0)} játékos dobott hétméterest.");
    }

    static void f8()
    {
        Console.WriteLine($"8. fealadat: {adatok.Sum(x => x.Ketperceskiallitasok * 2)} perc büntetést kapott a csapat.");
    }

    static void f9()
    {
        Console.WriteLine($"9. feladat: A legfitatalabb játékos: {adatok.OrderByDescending(x => x.Szuletesive).First().Nev}.");
    }

    static void f10()
    {
        Console.WriteLine($"10. feladat: {adatok.Count(x => x.Szuletesive.Year == 1999)} játékos született 1999-ben");
    }

    static void f11()
    {
        Console.WriteLine($"11. feladat: A cspat átlagmagassága {adatok.Average(x => x.Magassag)} cm.");
    }

    static void f12()
    {
        Console.WriteLine($"12. feladat: A csapat átlagéletkora {adatok.Average(x => 2022 - x.Szuletesive.Year):F2} év");
    }

    static void f13()
    {
        Console.WriteLine($"13. feladat: A Balatonfüredi KSE {adatok.Count(x => x.Csapatnev == "Balatonfüredi KSE")} játékost adott a válogatottnak.");
    }

    static void f14()
    {
        Console.WriteLine($"14. feladat: Lékai Máté a {adatok.Where(x => x.Nev == "Lékai Máté").First().Csapatnev}-ben játszik.");
    }

    static void f15()
    {

        bool van = false;
        foreach (var item in adatok)
        {
            if (item.Magassag > 200)
            {
                van = true;
                break;
            }
        }
        if (van)
        {
            Console.WriteLine($"15. feladat: Van olyan játékos, aki 200cm magas");
        }else
        {
            Console.WriteLine($"15. feladat: Nincs olyan játékos, aki 200cm magas");
        }
    }

    static void f16()
    {
        using (var sw = new StreamWriter("magasak.txt"))
        {
            foreach (var item in adatok.Where(y => y.Magassag > adatok.Average(x => x.Magassag)))
            {
                sw.WriteLine($"{item.Nev} {item.Magassag}");
            }
        }

    }
}
