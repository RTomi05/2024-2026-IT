namespace szorzotabla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szorzótábla:");
            Console.WriteLine();
            
            for (int k = 0; k <= 10; k++)
            {
                int ujsor = 0;
                for (int elso = 0; elso <= 10; elso++)
                {
                    if (elso == 0)
                    {

                    }
                    else
                    {
                        if (k == 0)
                        {

                        }
                        else
                        {
                            Console.Write(k * elso + "; ");
                            ujsor++;
                        }
                        
                        
                    }
                    if (ujsor == 10)
                    {
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
