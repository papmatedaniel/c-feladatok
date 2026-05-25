using System.Runtime.CompilerServices;
using System.Text;

namespace Helsinki;
//18:20
//18:50

class Helsinki
{
    public int Helyezes;
    public int Szam;
    public string SportagNev;
    public string VersenyszamNeve;

    public Helsinki(string fajlsor)
    {
        string[] darabok = fajlsor.Trim().Split();
        Helyezes = int.Parse(darabok[0]);
        Szam = int.Parse(darabok[1]);
        SportagNev = darabok[2];
        VersenyszamNeve = darabok[3];

    }
}
class Program
{
    public static List<Helsinki> adatok = new List<Helsinki>();
    static void Main(string[] args)
    {
        beolvasas();
        f3();
        f4();
        f5();
        f6();
        f7();
        f8();
        Console.WriteLine("Hello, World!");
    }

    static void beolvasas()
    {
        string[] beolvas = File.ReadAllLines("helsinki.txt", Encoding.UTF8);
        foreach (var item in beolvas)
        {
            adatok.Add(new Helsinki(item));
        }
    }

    static void f3()
    {
        Console.WriteLine($"3. feladat:\nPontszerző helyezések száma: {adatok.Count()}");
    }

    static void f4()
    {
        Console.WriteLine("4. feladat: ");

        foreach (var item in adatok.GroupBy(x => x.Helyezes).OrderBy(y => y.Key).Take(3))
        {
            Console.WriteLine($"{ new List<string>{"Arany", "Ezüst", "Bronz"}[item.Key-1]} : {item.Count()}");
        }
    }

    static void f5()
    {
        Console.WriteLine("5. feladat: ");
        List<int> valami = new List<int>{7,5,4,3,2,1};
        Console.WriteLine($"Olimpiai pontok száma: {adatok.Sum(x => valami[x.Helyezes-1])}");

    }

    static void f6()
    {
        Console.WriteLine($"6. feladat:");
        int uszas = adatok.Count(x => x.SportagNev == "uszas");
        int torna = adatok.Count(x => x.SportagNev == "torna");
        if (uszas < torna)
        {
            Console.WriteLine($"A torna sportágban szereztek több érmét");
        }
        else if (uszas > torna)
        {
            Console.WriteLine($"A úszás sportágban szereztek több érmét");
        }
        else
        {
            Console.WriteLine($"Egyenlő volt az érmek száma");
        }
    }

    static void f7()
    {
        var sw = new StreamWriter("helsinki2.txt");
        List<int> valami = new List<int>{7,5,4,3,2,1};
        foreach (var item in adatok)
        {
            if (item.SportagNev == "kajakkenu")
            {
                item.SportagNev = "kajak-kenu";
            }
            string sor = $"{item.Helyezes} {item.Szam} {valami[item.Helyezes-1]} {item.SportagNev} {item.VersenyszamNeve}";
            sw.WriteLine(sor);
        }

        sw.Close();

    }

    static void f8()
    {
        Console.WriteLine("8. feladat: ");
        var asd = adatok.OrderByDescending(x => x.Szam).First();
        Console.WriteLine($"Helyezés {asd.Helyezes}");
        Console.WriteLine($"Sportág: {asd.SportagNev}");
        Console.WriteLine($"Versenyszám: {asd.VersenyszamNeve}");
        Console.WriteLine($"Sportolók száma: {asd.Szam}");
    }
}

