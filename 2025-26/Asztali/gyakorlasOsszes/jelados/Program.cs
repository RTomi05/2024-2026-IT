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

            var megfeleloJel = adatok[beSzam - 1];

            Console.WriteLine($"x={megfeleloJel.x} y={megfeleloJel.y}");
            Console.WriteLine(adatok[beSzam - 1].koordinatak());
            //Console.WriteLine(adatok.Where((e,i) => i == beSzam - 1).First().koordinatak());

            Console.WriteLine();
            Console.WriteLine("4. feladat\nIdőtartam: {0}",
                                           adatok[0].elteltMasodperc(adatok.Last()));

            Console.WriteLine();

            Console.WriteLine("5.feladat");

            int minX = adatok.Min(x => x.x);

            int maxX = adatok.Max(x => x.x);

            int minY = adatok.Min(y => y.y);

            int maxY = adatok.Max(y => y.y);


            int[] tomb = { adatok.Min(x => x.x), adatok.Max(x => x.x), adatok.Min(y => y.y), adatok.Max(y => y.y) };

            var teglalap = new
            {
                balalso = new { x = adatok.Min(x => x.x), y = adatok.Min(y => y.y) },
                jobbFelso = new { x = adatok.Max(x => x.x), y = adatok.Max(y => y.y) }
            };

            Console.WriteLine($"Bal alsó: {teglalap.balalso.x} {teglalap.balalso.y}, jobb felső: {teglalap.jobbFelso.x} {teglalap.jobbFelso.y}");

            Console.WriteLine();
            Console.WriteLine("6. feladat");
            var osszeg = adatok.Skip(1).Select((x, index) => x.tavolsag(adatok[index])).Sum();
            Console.WriteLine($"Elmozdulás {osszeg:0.000} egység");

            Console.WriteLine();
            Console.WriteLine("7. feladat");

            var kimaradtak = adatok
                .Skip(1)
                .Where((adat,i) => adat.kimaradt(adatok[i]).darab > 0)
                .Select(adat => adat.ora + " " + adat.perc + " " + adat.masodperc + " " + adat.kimaradt);

        }
    }
}
