namespace operatorokFelulirasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szam sz1 = new Szam(12);
            Szam sz2 = new Szam(30);
            Szam sz3 = sz1 + sz2;
            Console.WriteLine(sz3);

            Szam sz4 = sz1 + 3;
            Console.WriteLine(sz4);
            Szam sz5 = sz1 + (-1);
            Console.WriteLine(sz5);

            var sz6 = 2 + sz2;
            Console.WriteLine(sz6);

            //sz1++;
            Console.WriteLine(++sz1);
            Console.WriteLine(sz1++);

            var sz7 = 2.5 + sz2;
            Console.WriteLine(sz7);

            var sz8 = 4 - sz2;
            Console.WriteLine(sz8);
        }
    }
}
