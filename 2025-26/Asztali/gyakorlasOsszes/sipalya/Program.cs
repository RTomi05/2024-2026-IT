namespace sipalya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Palya p1 = new Palya(20);
            Palya p2 = new Palya(20);
            Palya p3 = new Palya(20);

            Console.WriteLine((p1 + p2).ho);
            var p4 = p1 + p2;
            Console.WriteLine(p4.ho);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 <= p2);
            Console.WriteLine(p1 + p2 <= p2 + p3);
            var p5 = p1 + 100;
            p1 += 100;
            Console.WriteLine(p1.ho);

            p1 *= 2;
        }
    }
}
