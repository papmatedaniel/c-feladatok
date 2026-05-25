using System.Text;

namespace Tanulmanyiverseny;

//22:45
//20 perces endoing cseszekedés

class Versenyzok
{
    
    public int Helyezes;
    public string Nev;
    public string Iskola;
    public string Telepules;
    public double Eredmeny;
    public string Csoport;

    public Versenyzok(string sor)
    {
        
        string[] darabok = sor.Trim().Split("\t");
        Helyezes = Convert.ToInt32(darabok[0]);
        Nev = darabok[1];
        Iskola = darabok[2];
        Telepules = darabok[3];
        Eredmeny = Convert.ToDouble(darabok[4]);
        Csoport = darabok[5];
    }

}
class Program
{

    public static List<Versenyzok> adatok = new List<Versenyzok>();
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //csak linuxon kell!windowson nem
        beolvasas();
        f2();
        f3();
        f3b();
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
        f17();
        f18();
        f19();
        f20();
        f21();
        Console.WriteLine("Hello, World!");
    }

    static void beolvasas()
    {

        string[] beolvas = File.ReadAllLines("eredmenyek.txt", Encoding.GetEncoding(1250));
        foreach (var item in beolvas)
        {
            adatok.Add(new Versenyzok(item));
        }
    }

    static void f2()
    {
        Console.WriteLine($"\n2. Feladat, diákok száma {adatok.Count()}");
    }

    static void f3()
    {
        Console.WriteLine("\n3. Feladat: Szakmacsoportok és tanulóik száma");
        Dictionary<string, int> stat = new Dictionary<string, int>();
        foreach (var item in adatok)
        {
            if (!stat.ContainsKey(item.Csoport))
            {
                stat[item.Csoport] = 0;
            }
            stat[item.Csoport]++;
        }
        foreach (var item in stat)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

    static void f3b()
    {
        Console.WriteLine("\n3. Feladat: Szakmacsoportok és tanulóik száma");
        foreach (var item in adatok.GroupBy(x => x.Csoport))
        {
            Console.WriteLine($"{item.Key} - {item.Count()}");
        }
    }

    static void f4()
    {
        var swGepesz = new StreamWriter("gepesz.txt");
        var swInfo = new StreamWriter("info.txt");
        var swKvedelem = new StreamWriter("kvedelem.txt");

        foreach (var item in adatok)
        {
            string sor = $"{item.Nev}\t{item.Iskola}\t{item.Telepules}";
            if (item.Csoport == "informatika")
            {
                swInfo.WriteLine(sor);
            }
            else if(item.Csoport == "gépész")
            {
                swGepesz.WriteLine(sor);
            }
            else
            {
                swKvedelem.WriteLine(sor);
            }
        }
        swGepesz.Close();
        swInfo.Close();
        swKvedelem.Close();
    }

    static void f5()
    {
        Console.WriteLine("\n5. Feladat: Ábrahám keresztnevű diákok adatai");
        foreach (var item in adatok)
        {
            if (item.Nev.Split()[1].Contains("Ábrahám"))
            {
                Console.WriteLine($"{item.Nev};{item.Csoport};{item.Eredmeny};{item.Helyezes};{item.Iskola};{item.Telepules}");
            }
        }
    }

    static void f6()
    {
		Console.WriteLine("\n6. Feladat");
        //kurvanehéz feladat, 20 perces gondolkodtam rajta hogy lehetne linq, lambdával mert anélkül 50 sorból lenne meg
        foreach (var item in adatok.GroupBy(x => x.Csoport))
        {
            Console.WriteLine(item.Key);
            foreach (var item2 in item.OrderBy(x => x.Helyezes).Take(3))
            {
                Console.WriteLine($"\t{item2.Helyezes} - {item2.Nev}");
            }
        }

        

        //AI megoldás:
        // var legjobbVersenyzok = adatok
        //     .GroupBy(x => x.Csoport)
        //     .Select(g => new 
        //     {
        //         Csoport = g.Key,
        //         Dobogosok = g.OrderBy(x => x.Helyezes).Take(3)
        //     });

        // foreach (var elem in legjobbVersenyzok)
        // {
        //     Console.WriteLine($"Szakmacsoport: {elem.Csoport}");
            
        //     foreach (var versenyzo in elem.Dobogosok)
        //     {
        //         Console.WriteLine($"\t{versenyzo.Helyezes}. hely: {versenyzo.Nev}");
        //     }
        //     Console.WriteLine();
        // }

        //vagy:
        foreach (var s in adatok.GroupBy(x => x.Csoport).SelectMany(g => g.OrderBy(x => x.Helyezes).Take(3)))
        {
            Console.WriteLine($"{s.Csoport} - {s.Helyezes}. hely: {s.Nev}");
        }
    }

    static void f7()
    {
        Console.WriteLine($"\n7. Feladat: Ennyi versenyző volt egerben: {adatok.Count(x => x.Telepules == "Eger")}");
    }

    static void f8()
    {
        Console.WriteLine("\n8. Feladat. Budapesti szakok");
        var valami = adatok.Where(x => x.Telepules == "Budapest").GroupBy(y => y.Csoport);
        foreach (var item in valami)
        {
            Console.WriteLine($"{item.Key} - {item.Count()}");
        }
    }

    static void f9()
    {
        int bp = 0;
        int videk = 0;
        foreach (var item in adatok)
        {
            if (item.Telepules == "Budapest")
            {
                bp++;
            }
            else
            {
                videk++;
            }
        }
        if (bp > videk)
        {
            Console.WriteLine("\n9. Feladat: Budapesten több versenyző volt");
        }else
        {
			Console.WriteLine("\n9. Feladat: Vidéken több versenyző volt");
        }
    }

    static void f10()
    {
        var valami = adatok.Where(x => x.Iskola == "Eötvös" && x.Telepules == "Kaposvár").OrderBy(y => y.Helyezes).First();
        Console.WriteLine($"\n10. Feladat. Kaposvári Eötvös legjobbja: {valami.Nev}");
        var valami2 = adatok.Where(x => x.Iskola == "Eötvös" && x.Telepules == "Budapest").OrderBy(y => y.Helyezes).First();
        Console.WriteLine($"10. Feladat. Budapesti Eötvös legjobbja: {valami2.Nev}");

    }

    static void f11()
    {
        Console.WriteLine("\n11. Feladat: Báthyak adatai: ");
        foreach (var item in adatok)
        {
            if (item.Iskola == "Bláthy")
            {
                foreach (var item2 in item.GetType().GetFields())
                {
                    Console.Write($"{item2.GetValue(item)} ");
                }
                Console.WriteLine();
            }
        }
    }

    static void f12()
    {
        Console.WriteLine("\n12. Feladat. Váci szakversenyzők");
        foreach (var item in adatok.Where(x => x.Telepules == "Vác").GroupBy(y => y.Csoport))
        {
            Console.WriteLine($"{item.Key}");
        }
    }

    static void f13()
    {
        Console.WriteLine("\n13. Feladat: Csongrádi szakmahelyezesek");
        var asd = adatok.Where(x => x.Telepules == "Csongrád").GroupBy(y => y.Csoport);
        foreach (var item in asd)
        {
            Console.WriteLine($"{item.Key}");
            foreach (var item2 in item)
            {
                Console.WriteLine($"\t{item2.Nev} - {item2.Helyezes}");
            }
        }
    }

    static void f14()
    {
        Console.WriteLine("\n14. Feladat");
        int szamlalo = adatok.Count(x => x.Telepules == "Budapest" && x.Iskola == "Eötvös" && x.Csoport == "környezetvédelem");
        Console.WriteLine($"{szamlalo} diák indult");
    }

    static void f15()
    {
        Console.WriteLine("\n15. Feladat");
        foreach (var item in adatok)
        {
            if (item.Telepules == "Dombóvár" || item.Telepules == "Püspökladány")
            {
                Console.WriteLine(item.Nev);
            }
        }
    }

    static void f16()
    {
        Console.WriteLine("\n16 Feladat: ");
        var ganz = adatok.Where(x => x.Iskola == "Ganz");
        Console.WriteLine($"Ganz iskola {ganz.First().Telepules} településen van, {ganz.Count()} diák van itt");
    }

    static void f17()
    {
        Console.WriteLine("\n17. Feladat");
        var legjobb = adatok.OrderByDescending(x => x.Eredmeny).First();
        // var legjobb = adatok.Where(x => x.Eredmeny == adatok.Max(x => x.Eredmeny)).First();
        Console.WriteLine($"{legjobb.Nev} - {legjobb.Csoport} - {legjobb.Iskola}");
    }

    static void f18()
    {
        Console.WriteLine("\n18. Feladat.");
        int molnar = 0;
        int nagy = 0;
        foreach (var item in adatok)
        {
            if (item.Nev.Split()[0] == "Molnár")
            {
                molnar++;
            }
            if (item.Nev.Split()[0] == "Nagy")
            {
                nagy++;
            }
        }
        if (molnar > nagy)
        {
            Console.WriteLine("Molnár vezetéknevűből volt több versenyző");
        }else
        {
            Console.WriteLine("Nagy vezetéknevűből volt több versenyző");
        }
    }

    static void f19()
    {
        Console.WriteLine("\n19. Feladat.");
        Console.WriteLine($"Összesen: {adatok.GroupBy(x => x.Iskola).Count()} iskolából voltak versenyzők");
    }

    static void f20()
    {
        Console.WriteLine("\n20. Feladat");
        var valamiasd = adatok.GroupBy(x => x.Iskola).OrderByDescending(y => y.Count()).First();

        Console.WriteLine($"A legtöbben a {valamiasd.Key}-ból jöttek");
    }

    static void f21()
    {
        var sw = new StreamWriter("resztvevok3.txt");
        foreach (var item in adatok.GroupBy(x => new { x.Iskola, x.Telepules }))
        {
            sw.WriteLine($"{item.Key.Iskola}\t{item.Key.Telepules}\t{item.Count()}");
        } 
        
        sw.Close();

    }
}