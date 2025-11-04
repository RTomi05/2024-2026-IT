namespace sebesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("ut.txt");

            List<Adatok> adatLista = new List<Adatok>();

            int teljesUtHossz = int.Parse(sorok[0]);

            bool varosban = false;

            for (int i = 1; i < sorok.Length; i++)
            {
                adatLista.Add(new Adatok(sorok[i]));
                adatLista[i-1].isTelepules();
            }


            Console.WriteLine("2.feladat");

            for (int i = 0; i < adatLista.Count; i++)
            {
                if (adatLista[i].isTelepules())
                {
                    Console.WriteLine(adatLista[i].jelzes);
                }
            }

        }
    }
}
