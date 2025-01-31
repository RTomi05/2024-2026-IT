using park;

internal class Program
{
    static void Main(string[] args)
    {
        string[] sorok = File.ReadAllLines("felajanlas.txt");

        List<Adatok> felajanlasok = new List<Adatok>();

        int agyasDb = int.Parse(sorok[0]);

        for (int i = 1; i < sorok.Length; i++)
        {
            felajanlasok.Add(new Adatok(sorok[i],i));
        }

        Console.WriteLine();
        Console.WriteLine($"2. feladat:\nA felajánlások száma: {felajanlasok.Count}");

        Console.WriteLine();

        //A bejárat mindkét oldalán ültetők: 10 34 98 107 115 142 156 160 340 360 378
        Console.WriteLine("3. feladat:");
        Console.Write("A bejárat mindkét oldalán ültetők: ");

        for(int i = 0; i < felajanlasok.Count; i++)
        {
            if (felajanlasok[i].kapuKetOldal)
            {
                Console.Write(felajanlasok[i].sorszam + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        //4. feladat
        Console.Write("4. feladat:\nAdja meg az ágyás sorszámát! ");

        int agyas = int.Parse(Console.ReadLine());



    }
}