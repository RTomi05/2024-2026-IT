namespace GyaksziVanda
{
    internal class Program
    {
        //A függvényeket az internal class Program, nevű rész után írjuk.
        //összeadás, ami az osszead névre hallgat és kettő int számot vár, amit visszaad (return)
        
        static int osszead(int egyik, int masik)
        {
            return egyik + masik;
        }

        //A függvény nevével tudjuk meghívni, erre az alábbi alap függvényben van lehetőség.
        static void Main(string[] args)
        {
            //Beírjuk a függvény nevét, és megadjuk a két általunk kiválasztott számot.
            //A függvény elvégzi a dolgát, összeadja a két számot, majd visszaadja (ez a retrun rész feljebb a függvényben)
            Console.WriteLine(osszead(5, 8));
            //Ugyanilyen módon lehet osztani, kivonni, egyéb műveleteket végezni a függvény segítségével.




            //Nézzünk random szám generálást.
            //Alap generátor:
            Random rand = new Random();

            //csináljunk egy szamok nevű tömböt, aminek 10 eleme lesz majd, járjuk be for ciklussal, addig generáljon random számokat, amíg meg nem lesz a 10 generált szám.
            int[] szamok = new int[10];


            for (int i = 0; i < szamok.Length; i++)
            {
                //A rand.Next() egy nemnegatív egész számot fog sorsolni.
                szamok[i] = rand.Next(0, 2000);
            }



            //Ezzel a kis programmal sorsolhatunk random számokat bizonyos meghatározásokkal.
            //mettol -> Mettől sorsoljon
            //meddig -> meddig sorsoljon
            //hany -> hányat sorsoljon

            Console.Write("Mettől sorsoljon számokat? ");
            int mettol = Convert.ToInt32(Console.ReadLine());
            Console.Write("Meddig sorsoljon számokat? ");
            int meddig = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számot sorsoljon? ");
            int hany = Convert.ToInt32(Console.ReadLine());

            //A kapott számokat adja hozzá a tömbhöz

            int[] kapottSzamok = new int[hany];

            for (int i = 0; i < szamok.Length; i++)
            {
                int szam = rand.Next(mettol, meddig);
                szamok[i] = szam;

            }

            //Írja ki a számokat (length -> megnézi, hogy mennyire hosszú a tömb, kiírja minden elemét)

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + ", ");
            }
        }


    }
}
