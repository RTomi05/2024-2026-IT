namespace jelados
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("jel.txt");
            List<Adat> adatok = new List<Adat>();

            sorok
                .ToList()
                .ForEach(x =>
                {
                    adatok.Add(new Adat(x));
                });
            adatok = sorok.ToList().Select(x => new Adat(x)).ToList();

            Console.WriteLine();
            Console.WriteLine("2. feladat");
            Console.Write("Adja meg a jel sorszámát! ");
            int beSzam = int.Parse(Console.ReadLine());
            Console.WriteLine(adatok[beSzam - 1].koordinatak());
            //Console.WriteLine(adatok.Where((e,i) => i == beSzam - 1).First().koordinatak());

            Console.WriteLine();
            Console.WriteLine("4. feladat\nIdőtartam: {0}",
                                           adatok[0].elteltMasodperc(adatok.Last()));

            Console.WriteLine();
            Console.WriteLine("6. feladat");
            var osszeg = adatok.Skip(1).Select((x, index) => x.tavolsag(adatok[index])).Sum();
            Console.WriteLine($"Elmozdulás {osszeg:0.000} egység"); 

        }
    }
}
