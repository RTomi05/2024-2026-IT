using robot;

internal class Program
{
    static void Main(string[] args)
    {
        string[] sorok = File.ReadAllLines("progs.txt");
        List<Adatok> programok = new List<Adatok>();
        for (int i = 0; i < sorok.Length; i++)
        {
            programok.Add(new Adatok(sorok[i]));
        }

        Console.WriteLine();
        Console.WriteLine("2. feladat: Tanulók száma: {0} fő",programok.Count);

        int darab = 0;
        for (int i = 0; i < programok.Count; i++)
        {
            if (programok[i].hibas())
            {
                darab++;
            }
        }

        Console.WriteLine("3. feladat: Helytelen kódsorozatok száma: {0}",darab);

        StreamWriter ir = new StreamWriter("ivsz.txt");
        for (int i = 0; i < programok.Count; i++)
        {
            if (!programok[i].hibas())
            {
                ir.Write(programok[i].nev + " ");
                ir.WriteLine(programok[i].iranyvaltasok());
            }
        }

        ir.Close();

    }
}