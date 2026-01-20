namespace jurgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buksza bukszaJurgen = new Buksza(100);
            Console.WriteLine(bukszaJurgen);
            bukszaJurgen = bukszaJurgen - 30;
            Console.WriteLine($"A hansi kért pénzt. {bukszaJurgen}");
            bukszaJurgen = bukszaJurgen - 50;
            Console.WriteLine(bukszaJurgen);
            Buksza bukszaMaria = new Buksza(700);
            Console.WriteLine(bukszaMaria);

            if (bukszaJurgen < bukszaMaria)
            {
                Console.WriteLine("HOL A PÉNZ?!");
            }
            else
            {
                bukszaJurgen = bukszaJurgen - bukszaMaria;
                Console.WriteLine(bukszaJurgen);
                Console.WriteLine("JÓL ÁLL A SORAINKNAK!");
            }
        }
    }
}
