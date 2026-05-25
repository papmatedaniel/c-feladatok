using System.Text;

namespace Kektura;

//12:00
//12:23
class Kektura
{
    public string Kiindulopont;
    public string Vegpont;
    public double Turahossz;
    public int Emelkedesosszeg;
    public int Lejtesosszeg;
    public string pecsetelohely;

    public Kektura(string egysor)
    {
        string[] darabok = egysor.Trim().Split(';');
        Kiindulopont = darabok[0];
        Vegpont = darabok[1];
        Turahossz = Convert.ToDouble(darabok[2].Replace(',', '.'));
        Emelkedesosszeg = int.Parse(darabok[3]);
        Lejtesosszeg = int.Parse(darabok[4]);
        pecsetelohely = darabok[5];
    }
}

class Program
{

    public static List<Kektura> adatok = new List<Kektura>();
    public static int fejlec;
    static void Main(string[] args)
    {
        beolvasas();
        f3();
        f4();
        f5();
        f7();
        f8();
        Console.WriteLine("Hello, World!");
    }

    static void beolvasas()
    {
        string[] beolvas = File.ReadAllLines("kektura.csv", Encoding.UTF8);
        fejlec = int.Parse(beolvas.First());
        foreach (var item in beolvas.Skip(1))
        {
            adatok.Add(new Kektura(item));
        }
    }

    static void f3()
    {
        Console.WriteLine($"3. feladat: Szakaszok száma: {adatok.Count()} db");
    }

    static void f4()
    {
        Console.WriteLine($"4. feladat: A túra teljes hossza: {adatok.Sum(x => x.Turahossz):F2} km");
    }

    static void f5()
    {
        Console.WriteLine("5. feladat: A legrövidebb szakasz adatai: ");
        var legrovid = adatok.OrderBy(x => x.Turahossz).First();
        Console.WriteLine($"\tKezdet: {legrovid.Kiindulopont}\n\tVége: {legrovid.Vegpont}\n\tTávolság: {legrovid.Turahossz} km");
    }

    static bool HianyosNev(Kektura sor)
    {
        return sor.pecsetelohely == "i" && !sor.Vegpont.Contains("pecsetelohely");
    }

    static void f7()
    {
        Console.WriteLine("7. feladat: Hiányos állomásnevek: ");
        foreach (var item in adatok.Where(x => HianyosNev(x)))
        {
            Console.WriteLine($"\t{item.Vegpont}");
        }
    }
    
    static void f8()
    {
        Console.WriteLine("8. feladat: A túra legmagasabban fekvő végpontja: ");
        int legmagasabbppont = fejlec;
        int jelenlegipont = fejlec;
        string vegpontnev = "";
        foreach (var item in adatok)
        {
            jelenlegipont += (item.Emelkedesosszeg - item.Lejtesosszeg);

            if (jelenlegipont > legmagasabbppont)
            {
                legmagasabbppont = jelenlegipont;
                vegpontnev = item.Vegpont;
            }
        }
        Console.WriteLine($"\tA végpont neve: {vegpontnev}\n\tA végpont tengerszint feletti magassága: {legmagasabbppont} m");
    }
}
