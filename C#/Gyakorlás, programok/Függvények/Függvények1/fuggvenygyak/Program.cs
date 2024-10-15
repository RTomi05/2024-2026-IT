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
        }
    }
}
