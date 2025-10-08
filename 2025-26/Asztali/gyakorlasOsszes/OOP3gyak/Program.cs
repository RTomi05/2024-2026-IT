namespace OOP3gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kampanyfilm kf = new Kampanyfilm();
            Console.WriteLine(kf.Tipus);
            kf.mutat();
            Console.WriteLine(kf);
        }
    }
}
