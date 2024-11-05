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

        static int RandomSzam(int szamjegy, int oszto)
        {
            //return rand.Next(50, 500) * 2;
            /*
            Console.Write("Add meg hány számjegyű számokat kérsz: ");
            szamjegy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Add meg mennyivel legyenek oszthatók a számok: ");
            oszto = Convert.ToInt32(Console.ReadLine());*/

            int also = (int)Math.Pow(10, szamjegy - 1) / oszto;
            int felso = (int)Math.Pow(10, szamjegy) / oszto;
            
            return rand.Next(also, felso) * oszto;
            
        }
        



        static void Main(string[] args)
        {
            tombKiir(RandomSzamok(67));
            
        }

    }

    

    
}

//Random számokat (háromjegyű, páros) generáló program, belerakja egy tömbbe, visszaadja nekünk
