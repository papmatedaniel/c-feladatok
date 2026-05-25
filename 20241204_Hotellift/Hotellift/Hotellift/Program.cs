using System.Text;

namespace Hotellift;

//17:48
//18:19
class Lift
{
    
    public DateTime Datum;
    public int Kartyasorszam;
    public int Induloszint;
    public int Celszint;

    public Lift(string egysor)
    {
        string[] darabok = egysor.Trim().Split();

        string[] datumja = darabok[0].Trim('.').Split('.');

        Datum = new DateTime(int.Parse(datumja[0]), int.Parse(datumja[1]), int.Parse(datumja[2]));
        Kartyasorszam = int.Parse(darabok[1]);
        Induloszint = int.Parse(darabok[2]);
        Celszint = int.Parse(darabok[3]);
    }
}
class Program
{
    public static List<Lift> adatok = new List<Lift>();
    static void Main(string[] args)
    {
        beolvas();
        f3();
        f4();
        f5();
        f67();
        f8();
        Console.WriteLine("Hello, World!");
    }

    static void beolvas()
    {
        string[] fileja = File.ReadAllLines("lift.txt", Encoding.Default);
        foreach (var item in fileja)
        {
            adatok.Add( new Lift(item));
        }
    }

    static void f3()
    {
        Console.WriteLine($"3. feladat: Összes lifthasználat: {adatok.Count()}");
    }
    static void f4()
    {
        Console.WriteLine($"4. feladat: Időszak: {adatok.First().Datum.ToString("yyyy.MM.dd")} - {adatok.Last().Datum.ToString("yyyy.MM.dd")}");
    }

    static void f5()
    {
        Console.WriteLine($"5. feladat: Célszint max: {adatok.Max(x => x.Celszint)}");
    }

    static void f67()
    {
        Console.WriteLine("6. fealadat");
        int kszam;
        int cszint;
        Console.Write("\tKártya száma: ");
        try
        {
            kszam = int.Parse(Console.ReadLine());        
        }
        catch (System.Exception)
        {
            
            kszam = 5;
        }
        Console.Write("\n\tCélszint száma: ");
        try
        {
            cszint = int.Parse(Console.ReadLine());        
        }
        catch (System.Exception)
        {
            
            cszint = 5;
        }

        bool utaztak = false;
        foreach (var item in adatok)
        {
            if (item.Celszint == cszint && item.Kartyasorszam == kszam)
            {
                utaztak = true;
                break;
            }
        }
        if (!utaztak)
        {
            Console.WriteLine($"\nA(z) {kszam}. kártyával nem utaztak a(z) {cszint}. emeletre");
        }
        else
        {
            Console.WriteLine($"\nA(z) {kszam}. kártyával  utaztak a(z) {cszint}. emeletre!");
        }
    }

    static void f8()
    {
        Console.WriteLine("8. feladat: Statisztika");
        foreach (var item in adatok.GroupBy(x => x.Datum))
        {
            Console.WriteLine($"\t{item.Key.ToString("yyyy.MM.dd")} - {item.Count()}x");
        }
    }
}
