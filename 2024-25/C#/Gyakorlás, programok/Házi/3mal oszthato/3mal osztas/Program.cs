namespace _3mal_osztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("3-mal osztható háromjegyű számok:");

            // 1. megoldás
            for (int i = 100; i < 1000; i++)
            {
                if (i % 3 == 0 && i > 100)
                {
                    Console.Write(i + ";");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();

            // 2. megoldás

            for (int k = 102; k <= 999; k+=3)
            {
                Console.Write(k + ";");
            }

            Console.WriteLine();

            //ABC
            Console.WriteLine();
            for (char betu = 'a'; betu <= 'z'; betu++)
            {
                Console.WriteLine(betu + ";");
            }
        }
    }
}
