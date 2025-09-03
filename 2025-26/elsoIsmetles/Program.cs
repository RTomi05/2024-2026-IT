internal class Program
{
    private static void Main(string[] args)
    {
        //bekérünk egy számot a felhasználótól, és az első 10 többszörösét kiírjuk
        Console.Write("Kérek egy számot: ");
        int szam = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(szam * i);
        }
        Console.WriteLine();



        Console.Write("Kérem a piramis magasságát: ");
        int probaMagassag = int.Parse(Console.ReadLine());
        for (int i = 1; i <= probaMagassag; i++)
        {
            for (int j = probaMagassag; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }



        //piramis építése
        Console.Write("Kérem a piramis magasságát: ");
        int magassag = int.Parse(Console.ReadLine());
        for (int i = 1; i <= magassag; i++)
        {
            for (int j = magassag; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}