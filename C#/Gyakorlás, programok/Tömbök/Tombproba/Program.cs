namespace Tombproba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[6];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("Írj be egy számot: ");
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            foreach (int i in szamok)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            Console.Write("Adj meg egy számot: ");
            int egyik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int masik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(egyik + masik);

            //int[,] ujTomb = { {}, { } };

        }
    }
}
