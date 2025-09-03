namespace Ciklusoktarhaza
{
    internal class Program
    {

        static Random rand = new Random();
        static void Main(string[] args)
        {
            elsoFuggveny();
            masodikFuggveny();
            harmadikFuggveny();
            negyedikFuggveny(rand.Next(20));
            otodikFuggveny("hehe");
            hatodikFuggveny(rand.Next(60));
            hetedikFuggveny("hehe", "haha");
            nyolcadikFuggveny();
            kilencedikFuggveny();
            tizedikFuggveny();
            Console.WriteLine();

            Console.WriteLine();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Első for ciklus.");
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Második for ciklus.");
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Harmadik for ciklus.");
                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Negyedik for ciklus.");
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ötödik for ciklus.");
            }

            Console.WriteLine();

            string[] tomb = ["Igen", "Nem"];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            Console.WriteLine();

            int[] tombSzamok = [1,2,3,4,5];

            foreach (int i in tombSzamok)
            {
                if (i < tombSzamok.Length)
                {
                    Console.Write(i + ", ");
                }

                else
                {
                    Console.Write(i);
                }            
            }

            Console.WriteLine();

            int elsoValtozo = 0;

            while (elsoValtozo != 5)
            {

                for (int i = 0; i < 5; i++)
                {
                    elsoValtozo++;
                }

                if (elsoValtozo == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Első változós while jó!");
                }
            }

            Console.WriteLine();

            string elsoString = "alma";
            int gyumolcs = 0;

            while (elsoString != "banán")
            {
                gyumolcs++;

                if (gyumolcs == 5)
                {
                    elsoString = "banán";
                    Console.WriteLine("Ha kiírja a banánt, akkor jó!");
                    Console.WriteLine(elsoString);
                }
            }

            while (gyumolcs != 10)
            {
                Console.WriteLine("Még nem elég a szám." + "(" + gyumolcs + ")");
                gyumolcs++;

                if (gyumolcs == 10)
                {
                    Console.WriteLine("Elég a szám.");
                }
            
            }

            Console.WriteLine("Elég volt");
            
        }

        static void elsoFuggveny()
        {
            Console.WriteLine("Első függvény");
        }

        static void masodikFuggveny()
        {
            Console.WriteLine("Második függvény");
        }
        static void harmadikFuggveny()
        {
            Console.WriteLine("Harmadik függvény");
        }
        static int negyedikFuggveny(int szam1)
        {
            return szam1;
        }

        static string otodikFuggveny(string szoveg1)
        {
            return szoveg1;
        }
        static int hatodikFuggveny(int szam2)
        {
            return szam2;
        }

        static string hetedikFuggveny(string szoveg2, string szoveg21)
        {
            return szoveg2 + " " + szoveg21;
        }

        static void nyolcadikFuggveny()
        {

            Console.WriteLine("Ez a nyolcadik függvény");
        }

        static void kilencedikFuggveny()
        {
            Console.WriteLine("Ez a kilencedik függvény.");
        }

        static void tizedikFuggveny()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i < 10)
                {
                    Console.Write(i + ", ");
                }

                else
                {
                    Console.Write(i);
                }
                
            }
         
        }
    }
}
