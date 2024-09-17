namespace Ciklusos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat Egytől százig minden egész számot kiírni
            int szam = 0;

            Console.WriteLine("1. feladat");
            while (szam != 100)
            {
                szam++;
                Console.Write(szam.ToString() + ";");
            }

            Console.WriteLine("");

            //2. feladat 1 - 100-ig, kétjegyű

            Console.WriteLine("2. feladat");

            //Na ez hogy van te jó ég
            for (int i = 10; i < 100; i++)
            {
                Console.Write(i.ToString() + ";");
            }
            //Óh, mükszik

            Console.WriteLine("");

            //3. feladat 1 - 100-ig minden második szám

            Console.WriteLine("3. feladat");
            int ujszam = 1;
            while (ujszam < 100)
            {
                ujszam += 2;
                Console.Write(ujszam.ToString() + ";");
            }

            Console.WriteLine("");

            //4. feladat bekérés, amíg nem 10
            Console.WriteLine("4. feladat");
            int bekert = 0;
            while (bekert != 10)
            {
                Console.Write("Adj meg egy egész számot: ");
                bekert = Convert.ToInt32(Console.ReadLine());
                if (bekert == 10)
                {
                    break;
                }
            }
        }
    }
}
