namespace gyakorlas1_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változatok
            //elso();
            masodik();
            
        }

        static void elso()
        {
            Console.WriteLine("Számkitalálós játék 1.0 Version");
            Console.WriteLine();

            Random rand = new Random();
            int szam = rand.Next(1, 30);

            int lepesek = 0;

            int beirtSzam = 0;

            Console.WriteLine("Melyik számra gondoltam?");
            while (beirtSzam != szam)
            {
                beirtSzam = Convert.ToInt32(Console.ReadLine());
                lepesek++;

                if (beirtSzam < szam)
                {
                    Console.WriteLine("A szám nagyobb, mint a beírt.");
                }

                else if (beirtSzam > szam)
                {
                    Console.WriteLine("A szám kisebb, mint a beírt.");
                }

                else if (beirtSzam == szam)
                {
                    Console.WriteLine("Eltaláltad" + " " + lepesek + " " + "lépésből.");

                }
            }

            Console.WriteLine();
        }

        static void masodik()
        {
            int szamom;
            int pcszam = 0;

            //Random
            Random rand = new Random();
            

            Console.Write("Számom: ");
            szamom = Convert.ToInt32(Console.ReadLine());

            while (szamom != pcszam)
            {

                pcszam = rand.Next(1, 30);

                if (szamom < pcszam)
                {
                    Console.WriteLine("A szám kisebb, mint a pc-s");
                }

                else if (szamom > pcszam)
                {
                    Console.WriteLine("A szám nagyobb, mint a pc-s");
                }

                else if (szamom == pcszam)
                {
                    Console.WriteLine("Eltaláltad.");
                }
            }
        }


        // Számkitalálós játék

        //1. változat
        //A pc gondol egy számra előre beállított keretek között, majd ki kell találni a számot!
        //A gép ad segítséget, hogy kisebb vagy nagyobb számra gondolt!
        //Hány lépésből sikerült kitalálni?

        //2. változat
        // A felhasználó gondol egy számra és a gépnek kell kitalálnia!
    }
}
