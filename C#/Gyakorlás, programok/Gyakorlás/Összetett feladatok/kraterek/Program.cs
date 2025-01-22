using kraterek;

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
        Console.WriteLine("2. feladat \nA kráterek száma: {0}",kraterek.Count());

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

    }
}