namespace valtozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int egeszSzam = 2;
            float lebegoPontos;
            double d1, d2;

            Console.WriteLine(egeszSzam + 10);
            egeszSzam += 10;
            egeszSzam /= 5;
            egeszSzam %= 5;
            Console.WriteLine(egeszSzam);



            lebegoPontos = 12;
            lebegoPontos /= 5;
            Console.WriteLine("lebegő: " + lebegoPontos);


            d1 = 1;
            d2 = 2;

            d1 += 1.1;
            Console.WriteLine(d1);



            decimal dec = 12;

            string szo = "ALMAFA ÁGA";

            char c = 'q';
            Console.WriteLine(c);
            c++;
            Console.WriteLine(c);
        }
    }
}
