namespace Ciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("2. feladat:");
            int k = 1;
            while (k <= 10)
            { 
                Console.WriteLine(k);
                k++;
            }

            Console.WriteLine();

            Console.WriteLine("3. feladat:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine();
            Console.WriteLine("4. feladat:");
            
            for (int i = 10;  i > 0; i--)
            {
                Console.WriteLine(i);
            }


            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(11 - i);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(11 - i);
            }


            // prímtényezős
            Console.WriteLine();
            Console.WriteLine("5. feladat:");

            int szam = 20;
            Console.Write("Adj meg egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
            int oszto = 2;
            while (szam > 1)
            {
                if (szam % oszto == 0)
                {
                    Console.WriteLine(oszto);
                    szam /= oszto;
                }

                else
                {
                    oszto++;
                }
            }
            
        }
    }
}
