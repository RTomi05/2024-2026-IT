namespace jurgenMukodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penztarca jurgen = new Penztarca(1000);
            Console.WriteLine(jurgen);
            int zsebpenz = 200;
            jurgen = jurgen-zsebpenz;
            Console.WriteLine(jurgen);

            Penztarca maria = new Penztarca(1000);
            if (jurgen > maria)
            {
                jurgen -= maria;
                maria -= maria;
            }
            else
            {
                Console.WriteLine("ELVESZTETTE KÖZPÉNZ JELLEGÉT!");
            }
            Console.WriteLine(jurgen);

            jurgen += 500;
            Console.WriteLine(jurgen);
            jurgen += new Penztarca(1500);
            Console.WriteLine(jurgen);
            jurgen += 500;
            Console.WriteLine(jurgen);
            Console.WriteLine(maria);

            int eddigiAjandek = 23610;
            Penztarca jurgenAdomany = new Penztarca(1000);
            eddigiAjandek += jurgenAdomany;
            jurgen -= jurgenAdomany;
            Console.WriteLine(jurgen);
            Console.WriteLine(eddigiAjandek);

            int Gunter = 12000;
            jurgen -= Gunter;
            Console.WriteLine(jurgen);
        }
    }
}
