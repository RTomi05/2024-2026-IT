using System.Threading.Tasks.Dataflow;

namespace DatumGenerator
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {

            string[] honapok = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"};
            int[] napokSzama = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //datumCsinalo(/*ide kell két paraméter*/);
            EvSzam();

            int jo = 0;

            while (jo != 1)
                {
                Console.Write("Adjon meg egy számot 10 és 100 között: ");
                int randomka = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (randomka >= 10 && randomka <= 100)
                {
                    jo++;
                    Console.WriteLine("A számod " + randomka + ", megfelelő.");
                }
                else
                {
                    Console.WriteLine("A számod " + randomka + ", nem megfelelő.");
                }
                
            }
        }
        
        static string datumCsinalo(int[] ho, int[] nap)
        {

            int kerdeses = 0;
            int hoSzam = rand.Next(1, 13);

            for (int i = 0; i < nap.Length; i++)
            {
                kerdeses = nap[i];
            }

            int kapottNap = rand.Next(0, kerdeses);
            string Ho = Convert.ToString(ho[hoSzam]);
            //Ez miért nem jó :D

            Console.WriteLine(kerdeses);



        }
        static void EvSzam()
        {
            int ezazev = rand.Next(1924, 2024);
            Console.WriteLine(ezazev);

            string[] megfeleloadatszerkezet = {};
            string ujDatum = ezazev + Ho;

            megfeleloadatszerkezet[0] = ujDatum;
            Console.WriteLine(megfeleloadatszerkezet);
            
        }
        

               
    }
}
