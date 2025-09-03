namespace tantargyi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egész szám bekérése, listába készítsünk annyi 1 - 5 véletlenszámot -> átlag
            Random rand = new Random();
            List<int> szamok = new List<int>();
            string tantargy = "alma";
            int szam = 0;
            while (tantargy != "")
            {
                Console.Write("Kérem a tantárgy nevét: ");
                tantargy = Console.ReadLine();
                if (tantargy == "")
                {
                    break;
                }
                else
                {
                    Console.Write("Kérem az érdemjegyek számát: ");
                    szam = int.Parse(Console.ReadLine());
                    for (int i = 0; i < szam; i++)
                    {
                        int veletlenSzam = rand.Next(1, 6);
                        szamok.Add(veletlenSzam);
                    }
                }
            }
            Console.WriteLine("Számok egy sorban: " + string.Join(", ", szamok));
            double atlag = szamok.Average();
            Console.WriteLine("Az érdemjegyek átlaga: " + atlag);

        }
    }
}
