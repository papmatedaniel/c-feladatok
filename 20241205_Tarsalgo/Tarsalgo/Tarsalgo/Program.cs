using System.Text;

namespace Tarsalgo;
//18:36
//19:40

class Tarsalgo
{
    public int Ora;
    public int Perc;
    public int Azon;
    public string Irany;

    public Tarsalgo(string egysor)
    {
        string[] darabok = egysor.Trim().Split();
        Ora = int.Parse(darabok[0]);
        Perc = int.Parse(darabok[1]);
        Azon = int.Parse(darabok[2]);
        Irany = darabok[3];
    }
}
class Program
{

    public static List<Tarsalgo> adatok = new List<Tarsalgo>();
    static void Main(string[] args)
    {
        beolvasas();
        f2();
        f3();
        f4();
        f5();
        f678();
        Console.WriteLine("Hello, World!");
    }

    static void beolvasas()
    {
        string[] beolvas = File.ReadAllLines("ajto.txt", Encoding.UTF8);
        foreach (var item in beolvas)
        {
            adatok.Add( new Tarsalgo(item));
        }
    }
    
    static void f2()
    {
        Console.WriteLine($"Az első belépő azonosítója: {adatok.Where(x => x.Irany == "be").First().Azon}");
        Console.WriteLine($"Az utolsó belépő azonosítója: {adatok.Where(x => x.Irany == "ki").Last().Azon}");
    }

    static void f3()
    {
        var sw = new StreamWriter("athaladas.txt");
        foreach (var item in adatok.GroupBy(x => x.Azon).OrderBy(y => y.Key))
        {
            sw.WriteLine($"{item.Key} {item.Count()}");
        }
        sw.Close();
    }

    static void f4()
    {
        Console.Write("4. feladat\nA végén a társalgóban voltak: ");
        foreach (var item in adatok.GroupBy(x => x.Azon).Where(z => z.Last().Irany == "be").OrderBy(y => y.Key))
        {
            Console.Write($"{item.Key} ");
        }
    }
    
    static void f5()
    {
        //SZAR, ÉRTELMEZHETETLEN FELADAT
        int aktualisletszam = 0;
        int maxletszam = 0;
        Tarsalgo? maxidopont = null;
        foreach (var item in adatok)
        {
            if (item.Irany == "be")
            {
                aktualisletszam++;
            }else
            {
                aktualisletszam--;
            }

            if (aktualisletszam > maxletszam)
            {
                maxletszam = aktualisletszam;
                maxidopont = item;
            }
        }


        if (maxidopont != null)
        {
            Console.WriteLine($"5. feladat\nPéldául {maxidopont.Ora}:{maxidopont.Perc} voltak a legtöbben");
        }

    }

    static void f678()
    {
        Console.Write("6. feladat\nAdja meg a személy azonosítóját! ");
        int azonja = int.Parse(Console.ReadLine());
        int osszbentvolt = 0;
        string bentvagykint = "";
        int kezdet = 0;
        int veg = 0;
        foreach (var item in adatok.Where(x => x.Azon == azonja))
        {

            if (item.Irany == "be")
            {
                bentvagykint = "be";
                kezdet = 60 * item.Ora + item.Perc;
                Console.Write($"{item.Ora}:{item.Perc}-");
            }else
            {
                bentvagykint = "ki";
                veg = 60 * item.Ora + item.Perc;
                Console.Write($"{item.Ora}:{item.Perc}\n");
                osszbentvolt += (veg - kezdet);
            }
        }

        //hulladék csapda!!
        if (bentvagykint == "be")
        {
            Console.Write("\n"); // Ha "be"-vel fejeződött be, a kötőjel után zárunk egy újsorral a konzolon
            veg = 15 * 60; // 15:00 = 900 perc
            osszbentvolt += (veg - kezdet);
        }

        Console.WriteLine($"8. feladat\nA(z) {azonja} személy összesen {osszbentvolt} percet volt bent, a megfigyelés végén {(bentvagykint == "be" ? "bent tartózkodott" : "kint tartózkodott")}.");
    }
}
