namespace Random2
{
    internal class Program
    {

        static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

        }
        static Random rand = new Random();
        static int RandomSzam()
        {
            return rand.Next(50, 500) * 2;
        }

        static int[] RandomSzamok(int darab)
        {
            int[] vissza = new int[darab];

            for (int i = 0; i <vissza.Length; i++)
            {
                vissza[i] = RandomSzam();
            }

            return vissza;
        }

        static int[] randomSzam(int szamjegy, int oszto)
        {
            //return rand.Next(50, 500) * 2;
            return rand.Next()
        }



        static void Main(string[] args)
        {
            tombKiir(RandomSzamok(67));
        }

    }

    

    
}

//Random számokat (háromjegyű, páros) generáló program, belerakja egy tömbbe, visszaadja nekünk
