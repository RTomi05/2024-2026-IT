using System.Reflection.Metadata.Ecma335;

namespace fuggvenygyak
{
    internal class Program
    {

        //összeadás

        static double osszead(double egyik, double masik)
        {
            return egyik + masik;
        }

        //osztás

        static double eloszt(double egyik, double masik)
        {
            return egyik / masik;
        }

        //a paraméterként kapott egész számokat összeadja, és kiírja a végeredményt

        static void szumma(int[] szamok)
        {
            int osszeg = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine(osszeg);
        }





        static void Main(string[] args)
        {
            //összeadás

            Console.WriteLine(osszead(1, 2));
            Console.WriteLine(osszead(-1, 2));
            Console.WriteLine(osszead(1, 2.4));

            //osztás

            Console.WriteLine(eloszt(2, 1));
            Console.WriteLine(eloszt(2, 2));
            Console.WriteLine(eloszt(2, 4));
            Console.WriteLine(eloszt(2.5, 1.2));
            Console.WriteLine(kiiras(5));




        }
        //függvény, ami kap egy egyjegyű pozitív számot, majd szövegesen visszaadja annak a számnak a nevét
        // ha negatív a szám, írja ki, hogy túl kicsi, ha 9-nél nagyobb, írja ki, hogy túl nagy

        static int kiiras(int egyJegyu)
        {
            egyJegyu = 0;
            Console.Write("Adj meg egy számot: ");
            egyJegyu = Convert.ToInt32(Console.ReadLine());

            if (egyJegyu < 0)
                Console.WriteLine("Kisebb, mint 0.");

            else if (egyJegyu > 9)
                Console.WriteLine("Nagyobb, mint 9.");
                    
            return egyJegyu;
        }

        





        //függvény, ami a paraméterként kapott egyjegyű pozitív egész számot szövegesen kiírja a konzolba



    }
}
