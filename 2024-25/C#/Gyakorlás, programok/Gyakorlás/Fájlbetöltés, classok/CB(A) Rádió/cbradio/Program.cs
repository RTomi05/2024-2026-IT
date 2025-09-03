namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("cb.txt");

            int[,] idok = new int[adatok.Length - 1, 2];
            int[] adasok = new int[adatok.Length - 1];
            string[] nevek = new string[adatok.Length - 1];


            for (int i = 1; i < adatok.Length; i++)
            {
                string[] vag = adatok[i].Split(';');
                idok[i - 1, 0] = int.Parse(vag[0]);
                idok[i - 1, 1] = int.Parse(vag[1]);

                adasok[i - 1] = Convert.ToInt32(vag[2]);
                nevek[i - 1] = vag[3];

                //Console.WriteLine(adatok[i]);
            }

            Console.WriteLine($"3. feladat: Bejegyzések száma: {nevek.Length} darab");
            //VAGY  
            Console.WriteLine("3. feladat: Bejegyzések száma: {0} darab", nevek.Length);

            Console.WriteLine();


            Console.Write("4. feladat: ");

            bool voltIlyen = false;

            for (int i = 0; i < adasok.Length; i++)
            {
                if (adasok[i] == 4)
                {
                    voltIlyen = true;
                    break;
                }
            }

            //VAGY

            voltIlyen = false;
            for (int i = 0; i < adasok.Length && !voltIlyen; i++)
            {
                voltIlyen |= adasok[i] == 4;
            }




            if (voltIlyen)
            {
                Console.WriteLine("Volt négy adást indító sofőr.");
            }
            else
            {
                Console.WriteLine("Nem volt négy adást indító sofőr.");
            }

            Console.Write("5. feladat: Kérek egy nevet: ");
            string nev = Console.ReadLine();

            int hivasDb = 0;
            for (int i = 0;i < nevek.Length;i++)
            {
                if (nevek[i] == nev)
                {
                    hivasDb += adasok[i];
                }
            }

            if (hivasDb > 0)
            {
                Console.WriteLine("");
            }
        }
    }
}