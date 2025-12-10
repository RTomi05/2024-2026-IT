using System.Runtime.InteropServices;

namespace godor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("melyseg-godrok.txt");
            List<Melyseg> melysegek = new List<Melyseg>();

            sorok.ToList()
                .ForEach(x => melysegek.Add(new Melyseg(int.Parse(x))));

            Console.WriteLine("1. feladat:");
            Console.WriteLine($"A fájl adatainak száma: {melysegek.Count}");
            Console.WriteLine();

            Console.WriteLine("2. feladat:");
            Console.WriteLine("Adjon meg egy távolságértéket!");
            int tavolsag = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ezen a helyen a felszín {melysegek[tavolsag - 1].melyseg} méter mélyen van.");
            Console.WriteLine();

            Console.WriteLine("3. feladat:");

            double szazalek = melysegek.Where(x => x.melyseg == 0).Count() / (double)melysegek.Count;

            Console.WriteLine($"Az érintetlen terület aránya {szazalek * 100:0.00}%.");

            File.WriteAllLines("godrok.txt", string.Join("", melysegek
                                           .Select(x => x.melyseg))
                                           .Split("0")
                                           .Where(x => x.Length > 0));
            Console.WriteLine();

            Console.WriteLine($"5. feladat \r\nA gödrök száma: {File.ReadAllLines("godrok.txt").Length}");
            //Console.WriteLine(eredmeny);
        }
    }
}