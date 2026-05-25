using System.Text;

namespace Szineszek;


//18:37
//19:11

class Szineszek
{
    
    public string Nev;

    public int Ev;
    public string Csillagjegy;

    public int Dijakszama;

    public Szineszek(string sor)
    {
        string[] darabok = sor.Trim().Trim(';').Split(";");
        Nev = darabok[0];
        Ev = Convert.ToInt32(darabok[1]);
        Csillagjegy = darabok[2];
        if (darabok.Count() == 4 )
        {
            Dijakszama = Convert.ToInt32(darabok[3]);
        }
        else
        {
            Dijakszama = 0;
        }
    }
}


class Program
{

    public static List<Szineszek> adatok = new List<Szineszek>();

    public static Dictionary<string, List<int>> csillagjegyek = new Dictionary<string, List<int>>();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    
        beolvas();
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
    }

    static void beolvas()
    {
        string[] beolvas = File.ReadAllLines("oscar.csv", Encoding.UTF8);

        foreach (var item in beolvas)
        {
            adatok.Add( new Szineszek(item));
        }
    }
    
    static void f2()
    {
        Console.WriteLine($"Színészek száma: {adatok.Count()}");
    }

    static void f3()
    {
        Console.WriteLine($"Oscaros száma: {adatok.Count(x => x.Dijakszama > 0)}");
    }

    static void f4()
    {
        Console.WriteLine($"Nem Oscaros száma: {adatok.Count(x => x.Dijakszama == 0)}");
    }

    static void f5()
    {
        Console.WriteLine($"Oscar összeg: {adatok.Sum(x => x.Dijakszama)}");
    }

    static void f6()
    {
        Console.WriteLine($"Legidősebb színész: {adatok.OrderBy(x => x.Ev).First().Nev}");
    }

    static void f7()
    {
        Console.WriteLine($"Legidősebb poscaros színész: {adatok.Where(y => y.Dijakszama > 0).OrderBy(x => x.Ev).First().Nev}");
    }

    static void f8()
    {

        foreach (var item in adatok)
        {
            if (item.Dijakszama > 0)
            {
                if (!csillagjegyek.ContainsKey(item.Csillagjegy))
                {
                    csillagjegyek[item.Csillagjegy] = new List<int>();
                }
                csillagjegyek[item.Csillagjegy].Add(item.Dijakszama);
            }
        }

        string legnagyobbnev = "";
        int legnagyobbszam = 0;
        foreach (var item in csillagjegyek)
        {
            if (item.Value.Count() > legnagyobbszam)
            {
                legnagyobbszam = item.Value.Count;
                legnagyobbnev = item.Key;
            }
        }
        Console.WriteLine($"A leggyakoribb csillagjegy: {legnagyobbnev}");
    }
    
    static void f9()
    {
        string legfiatalabb = adatok.OrderByDescending(x => x.Ev).First().Nev;
        Console.WriteLine($"A legfitalabb színész: {legfiatalabb}");
    }

    static void f10()
    {
        foreach (var item in csillagjegyek)
        {
            Console.WriteLine($"{item.Key} - {item.Value.Sum()}");
        }
    }

    static void f11()
    {
        // var sw = new StreamWriter("adat.txt");
        // sw.WriteLine("Első adat");
        // sw.WriteLine("Második adat");
        // sw.WriteLine("Harmadik adat");
        // sw.Close();

        var sw = new StreamWriter("dijazottak.csv");
        foreach (var item in adatok)
        {
            if (item.Dijakszama > 0)
            {
                sw.WriteLine($"{item.Nev};{item.Ev};{item.Csillagjegy};{item.Dijakszama}");
            }
        }
        sw.Close();
    }
}
