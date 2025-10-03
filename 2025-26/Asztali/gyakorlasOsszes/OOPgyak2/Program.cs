namespace OOPgyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Farmer gatya = new Farmer();
            gatya.nyulik();
            gatya.tipus = "Livájsz";
            gatya.anyag = "Farmer";
            gatya.meret = "56";
            Console.WriteLine(gatya);
        }
    }
}
