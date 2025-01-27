using kraterek;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        string[] sorok = File.ReadAllLines("felszin_tvesszo.txt");

        List<Krater> kraterek = new List<Krater>();

        for (int i = 0; i < sorok.Length; i++)
        {
            kraterek.Add(new Krater(sorok[i]));
        }

        Console.WriteLine();
        Console.WriteLine("2. feladat \nA kráterek száma: {0}", kraterek.Count());

        Console.WriteLine("3. feladat");
        Console.Write("Kérem egy kráter nevét: ");
        string nev = Console.ReadLine();

        string szoveg = "Nincs ilyen nevű kráter.";
        for (int i = 0; i < kraterek.Count; i++)
        {
            if (kraterek[i].nev == nev)
            {
                szoveg = kraterek[i].ToString();
            }
        }

        Console.WriteLine(szoveg);

        Console.WriteLine("4. feladat");

        Krater legnagyobb = kraterek[0];
        for (int i = 0; i < kraterek.Count; i++)
        {
            if (kraterek[i].r > legnagyobb.r)
            {
                legnagyobb = kraterek[i];
            }
        }
        Console.WriteLine("A legnagyobb kráterek neve és sugara: {0} {1}", legnagyobb.nev, legnagyobb.r);

        Console.WriteLine("6. feladat");
        Console.Write("Kérem egy kráter nevét: ");
        nev = Console.ReadLine();

        int id = -1;
        
        for (int i = 0; i < kraterek.Count; i++)
        {
            if (kraterek[i].nev == nev)
            {
                id = i;
                break;
            }
        }
        if (id == -1)
        {
            Console.WriteLine("Nincs ilyen kráter.");
        }
        else
        {
            for (int i = 0; i < kraterek.Count; i++)
            {
                if (kraterek[i].r + kraterek[id].r < kraterek[id].tavolsag(kraterek[i]))
                {
                    Console.Write(kraterek[i].nev + ", ");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine("7. feladat");

        for (int i = 0; i < kraterek.Count; i++)
        {
            for (int k = 0; k < kraterek.Count; k++)
            {
                if (i != k)
                {
                    if (kraterek[i].benneVan(kraterek[k]))
                    {
                        Console.WriteLine($"A(z) {kraterek[i].nev} kráter tartalmazza a(z) {kraterek[k].nev} krátert.");
                    }
                }
            }
        }

        StreamWriter ir = new StreamWriter("terulet.txt");



        ir.Close();
    }
}