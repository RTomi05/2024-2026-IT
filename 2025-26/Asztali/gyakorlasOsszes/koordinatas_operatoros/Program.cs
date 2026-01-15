namespace koordinatas_operatoros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Pont p1 = new Pont(10, 10);
            Pont p2 = new Pont(10, 20);
            Pont p3 = new Pont(20, 20);
            Pont p4 = new Pont(-10, -10);
            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p4);
            Console.WriteLine(p1 - p4);
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 != p2);
            Console.WriteLine(p2 <= p3);

            Console.WriteLine(p1 - 10);

            Pont3D p5 = new Pont3D(10, 10, 10);
            Console.WriteLine(p5);
        }
    }
}
