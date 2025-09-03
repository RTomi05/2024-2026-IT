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

        Adatok legnagyobb = programok[0];

        for (int i = 0;i < programok.Count; i++)
        {
            if(!programok[i].hibas())
            {
                legnagyobb = programok[i];
                break;
            }
        }


        for (int i = 1;i < programok.Count;i++)
        {
            if (!programok[i].hibas() && programok[i].uthossz() > legnagyobb.uthossz())
            {
                legnagyobb = programok[i];
            }
        }

        Console.WriteLine("5. feladat: Legtávolabbra jutó robot programját készítette: {0}",legnagyobb.nev);
        //EEHHEEEJJEEJJEEHHBJ

        Console.WriteLine("EEHHEEEJJEEJJEEHHBJ");
        string kod = "EEHHEEEJJEEJJEEHHBJ";
        int[] hosszok = new int[4];
        hosszok[0] = kod.Length - kod.Replace("E","").Length;
        hosszok[1] = kod.Length - kod.Replace("H", "").Length;
        hosszok[2] = kod.Length - kod.Replace("J", "").Length;
        hosszok[3] = kod.Length - kod.Replace("B", "").Length;

        string rovidKod = "";
        if (hosszok[0] > hosszok[1])
        {
            for (int i = 0; i < hosszok[0] - hosszok[1]; i++)
            {

            }
        }

    }
}