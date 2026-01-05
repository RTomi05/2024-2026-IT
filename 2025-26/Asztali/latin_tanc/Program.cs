namespace latin_tanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            var adatok = File.ReadAllLines("tancrend.txt");
            List <Tanc> tancok = new List<Tanc>();
            var adatok2Chunk = adatok.Chunk(3).ToList();
            //for

            foreach (var adat in adatok2Chunk)
            {
                tancok.Add(new Tanc(adat.ToList()));
            }

            //írassa ki a képernyőre, hogy melyik volt az elsőként és melyik az utolsóként bemutatott
            //tánc neve!


            Console.WriteLine("2. feladat");
            Console.WriteLine($"Elsőként bemutatott tánc: {tancok[0].tancNev}\nUtolsóként bemutatott tánc: {tancok[tancok.Count-1].tancNev}");

            Console.WriteLine();
            //Hány pár mutatta be a sambát? A választ jelenítse meg a képernyőn!
            Console.WriteLine("3. feladat");
            int sambaSzamlalo = 0;
            sambaSzamlalo = tancok.Where(x => x.tancNev == "samba").Count();
            Console.WriteLine($"{sambaSzamlalo} pár mutatott be sambát.");

            Console.WriteLine();

            Console.WriteLine("4. feladat");
            // Írassa ki a képernyőre, hogy Vilma mely táncokban szerepelt!
            var VilmaBugi = tancok.Where(x => x.lany == "Vilma").Select(x => x.tancNev).ToList();

            Console.WriteLine("Vilma a következő táncokban szerepelt:");
            foreach (var tanc in VilmaBugi)
            {
                Console.WriteLine(tanc);
            }

            Console.WriteLine();

            Console.WriteLine("5. feladat");
            /*Kérje be egy tánc nevét, majd írassa ki a képernyőre, hogy az adott táncot Vilma kivel
            mutatta be! Például ha a bekért tánc a samba, és Vilma párja Bertalan volt, akkor
            „A samba bemutatóján Vilma párja Bertalan volt.” szöveg jelenjen meg!
            Ha Vilma az adott tánc bemutatóján nem szerepelt, akkor azt írja ki a képernyőre, hogy
            „Vilma nem táncolt samba-t.”.
            */
            string bekertTancNev = "";
            Console.Write("Kérem a tánc nevét: ");
            bekertTancNev = Console.ReadLine();
            var VilmaKivel = tancok.Where(x => x.tancNev == bekertTancNev && x.lany == "Vilma");/*.Select(x => x.fiu).FirstOrDefault();*/
        }
    }
}
