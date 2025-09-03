namespace Ran3
{

    /*Három szám bekérése:
        1. Mettől
        2. Meddig
        3. Hányat
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Mettől sorsoljon számokat? ");
            int mettol =Convert.ToInt32(Console.ReadLine());
            Console.Write("Meddig sorsoljon számokat? ");
            int meddig = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számot sorsoljon? ");
            int hany = Convert.ToInt32(Console.ReadLine());

            int[] szamok = new int[hany];

            for (int i = 0; i < szamok.Length; i++)
            {
                int szam = rand.Next(mettol, meddig);
                szamok[i] = szam;
                
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + ", ");
            }
        }
    }
}