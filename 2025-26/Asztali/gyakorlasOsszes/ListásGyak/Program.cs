namespace ListásGyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szamok sz1 = new Szamok(new int[] { 1, 2, 3, 4, 5, 2, 3 });

            Szamok sz2 = new Szamok(new int[] { 2, 3, 6, 8 });

            Console.WriteLine(sz1 + sz2);

            Console.WriteLine(sz1);
            Console.WriteLine(sz1 + 200);

            Console.WriteLine(sz1 + 120 + sz2);
            Console.WriteLine(sz1 - sz2);
            Console.WriteLine(sz1 - 2);
        }
    }
}
