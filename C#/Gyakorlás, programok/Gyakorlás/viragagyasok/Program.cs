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

        Console.WriteLine("3. feladat:");
        Console.Write("A bejárat mindkét oldalán ültetők:");
    }
}