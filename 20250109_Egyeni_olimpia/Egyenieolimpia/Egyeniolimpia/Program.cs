using System.Text;

namespace Egyeniolimpia;

//12:27
//13:01

class Versenyzok
{
    public string Nev;
    public int Szulev;
    public int Olimpiaev;
    public string Helyszin;
    public string Sportag;
    public string Versenyszam;

    public Versenyzok(string egysor)
    {
        string[] darabok = egysor.Trim().Split(',');
        Nev = darabok[0];
        Szulev = int.Parse(darabok[1]);
        Olimpiaev = int.Parse(darabok[2]);
        Helyszin = darabok[3];
        Sportag = darabok[4];
        Versenyszam = darabok[5];
    }
}
class Program
{
    public static List<Versenyzok> adatok = new List<Versenyzok>();
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
        Console.WriteLine("Hello, World!");
    }

    static void beolvasas()
    {
        string[] beolvas = File.ReadAllLines("egyeni.csv", Encoding.UTF8);
        foreach (var item in beolvas)
        {
            adatok.Add(new Versenyzok(item));
        }
    }

    static void f2()
    {
        Console.WriteLine($"2. feladat: Egyéni bajnokok száma: {adatok.Count()}");
    }

    static void f3(){
        Console.WriteLine("3. feladat: Magasugrás, távolugrás");
        foreach (var item in adatok.Where(x => x.Versenyszam == "magasugrás" || x.Versenyszam == "távolugrás"))
        {
            Console.WriteLine(item.Nev);
        }
    }

    static void f4()
    {
        Console.WriteLine("4. feladat: kalapácsvetés");
        foreach (var item in adatok.Where(x => x.Versenyszam == "kalapácsvetés"))
        {
            Console.WriteLine($"\t{item.Nev} -{item.Olimpiaev}");
        }
    }

    static void f5()
    {
        Console.WriteLine("5. feladat: sokszoros");

        var sw = new StreamWriter("sokszoros.txt");
        foreach (var item in adatok.Where(x => x.Nev == "Kárpáti Rudolf" || x.Nev == "Kovács Pál").OrderBy(y => y.Nev))
        {
            sw.WriteLine($"{item.Helyszin};{item.Nev};{item.Olimpiaev};{item.Sportag};{item.Szulev};{item.Versenyszam}");
        }
        sw.Close();
    }

    static void f6()
    {
        Console.WriteLine("6. Keleti Ágnes eredményei");
        foreach (var item in adatok.Where(x => x.Nev == "Keleti Ágnes"))
        {
            Console.WriteLine($"\t{item.Versenyszam}");
        }
    }

    static void f7()
    {
        string nevlegkesobbi = adatok.OrderByDescending(x => x.Szulev).First().Nev;
        string nevlegkorabbi = adatok.OrderBy(x => x.Szulev).First().Nev;
        Console.WriteLine($"7. feladat: Legkésőbbi: {nevlegkesobbi}, legkorábbi: {nevlegkorabbi}");
    }

    static void f8()
    {
        Console.WriteLine("8. feladt, 1996 szuletesuek");
        bool zaszlo = true;
        foreach (var item in adatok.Where(x => x.Szulev == 1996))
        {
            Console.WriteLine(item.Nev);
            zaszlo = false;
        }
        if (zaszlo)
        {
            Console.WriteLine("Senki nem született 1996-ban");
        }

    }

    static void f9()
    {
        Console.WriteLine($"9. feladat: 2012 aranyérmesek: {adatok.Count(x => x.Olimpiaev == 2012)}");
    }

    static void f10()
    {
        Console.WriteLine($"10. feladat: Lólengés: {adatok.Where(x => x.Versenyszam == "lólengés").GroupBy(y => y.Nev).Count()}");
    }

    static void f11()
    {
        Console.WriteLine("11. feladat: lólengés bajnokai");
        foreach (var item in adatok.Where(x => x.Versenyszam == "lólengés").GroupBy(y => y.Nev))
        {
            Console.WriteLine($"\t{item.Key}");
        }
    }

    static void f12()
    {
        Console.WriteLine("12. feladat: ");
        foreach (var item in adatok.Where(x => x.Szulev == 1981 && x.Helyszin == "Sydney"))
        {
            Console.WriteLine($"\t{item.Nev}");
        }
    }

    static void f13()
    {
        Console.WriteLine($"13. fleadat: Legtöbb olimpiai győztes: {adatok.GroupBy(x => x.Nev).OrderByDescending(y => y.Count()).First().First().Nev}");
    }

    static void f14()
    {
        int aranyermeks = adatok.Count(x => x.Versenyszam == "úszás");
        int uszok = adatok.Where(x => x.Versenyszam == "úszás").GroupBy(y => y.Nev).Count();

        Console.WriteLine($"14. feladat: uszobajnokokszama: {uszok}, aranymerkeszama: {aranyermeks}");
    }
}
