using System.Security.Cryptography;

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
                if(adatLista[i - 1].isTelepules())
                {
                    varosban = true;
                }
                if (adatLista[i - 1].jelzes == "]")
                {
                    varosban = false;
                }

                adatLista[i - 1].varosban = varosban;
            }


            Console.WriteLine("2. feladat");

            for (int i = 0; i < adatLista.Count; i++)
            {
                if (adatLista[i].isTelepules())
                {
                    Console.WriteLine(adatLista[i].jelzes);
                }
            }

            Console.WriteLine(string.Join("\n", adatLista
                .Where(e => e.isTelepules())
                .Select(e => e.jelzes)));
            ;
            Console.WriteLine();


            Console.WriteLine("3.feladat");
            Console.Write("Adja meg a vizsgált szakasz hosszát km-ben! ");
            double beKm = Convert.ToDouble(Console.ReadLine());
            for(int i = 0; i < adatLista.Count; i++)
            {
                if (adatLista[i].km <= beKm*1000)
                {
                    Console.WriteLine(adatLista[i].km);
                }
            }

            Console.WriteLine(adatLista
                .Where(e => e.km <= beKm * 1000)
                .Min(e => e.sebessegHatar()));


            Console.WriteLine();


            Console.WriteLine("4. feladat");
            int varosKezdet = 0;
            double varosKm = 0;
            for (int i = 0; i < adatLista.Count; i++)
            {
                if (adatLista[i].isTelepules())
                {
                    varosKezdet = adatLista[i].km;
                }

                if (adatLista[i].jelzes == "]")
                {
                    varosKm += adatLista[i].km - varosKezdet;
                }
            }


            Console.WriteLine("{0:0.00%}",adatLista
                 .Where(e => e.isTelepules() || e.isVarosVege())
                 .Select(e => e.km)
                 .Chunk(2)
                 .Select(e => e[1] - e[0])
                 .Sum() / (double)teljesUtHossz
                 );


            Console.WriteLine($"Az út {varosKm/teljesUtHossz:0.00%} vezet településen belül.");



            Console.WriteLine();
            Console.WriteLine("5. feladat");
            Console.Write("Adja meg egy települést nevét! ");
            //Varos010
            string varosBe = Console.ReadLine();

            int varosKezdoIndex = 0;
            int varosVegIndex = 0;
            for (int i = 0; i < adatLista.Count; i++)
            {
                if (adatLista[i].jelzes == varosBe)
                {
                    varosKezdoIndex = i;
                    int kezdoKm = adatLista[i].km;
                    Console.WriteLine(i);
                    int tablaDb = 0;

                    while (!adatLista[i].isVarosVege())
                    {
                        if(adatLista[i].isKorlatozoTabla())
                        {
                            tablaDb++;
                        }
                        i++;
                        
                    }

                    varosVegIndex = i;
                    int varosHossz = adatLista[i].km - kezdoKm;
                    Console.WriteLine($"A sebességkorlátozó táblák száma: {tablaDb}");
                    Console.WriteLine($"Az út hossza a településen belül: {varosHossz} méter");
                    break;
                }
            }

            //LinQ
            var vKezdet = adatLista.Where(adat => adat.jelzes == varosBe).First();
            var vVeg = adatLista.Where(adat => adat.isVarosVege() && adat.km > vKezdet.km).First();
            var tablak = adatLista
                    .Where(adat => adat.km > vKezdet.km
                    && adat.km < vVeg.km
                    && adat.isKorlatozoTabla())
                    .Count();
            Console.WriteLine($"A sebességkorlátozó táblák száma: {tablak}");
            Console.WriteLine("Az út hossza a településen belül: {0} méter", vVeg.km - vKezdet.km);

            Console.WriteLine();
            Console.WriteLine("6. feladat");
            int kovetkezoVarosIndex = -1;
            for (int i = varosVegIndex + 1; i < adatLista.Count; i++)
            {
                if (adatLista[i].isTelepules())
                {
                    kovetkezoVarosIndex = i;
                    break;
                }
            }
<<<<<<< HEAD
            int kovetkezoVarosTavolsag = teljesUtHossz;
            if(kovetkezoVarosIndex > -1)
            {
                kovetkezoVarosTavolsag = adatLista[kovetkezoVarosIndex].km - adatLista[varosVegIndex].km;
            }
            //Console.WriteLine(kovetkezoVarosTavolsag);

            int elozoVarosVege = -1;
            int elozoVarosEleje = -1;
            for (int i = varosKezdoIndex-1; i >= 0; i--)
            {
                if (adatLista[i].isVarosVege())
                {
                    elozoVarosVege = i;
                    //break;
                }
                if(adatLista[i].isTelepules())
                {
                    elozoVarosEleje = i;
                    break;
                }
            }
            int elozoVarosTavolsag = teljesUtHossz;
            if (elozoVarosVege > -1)
            {
                elozoVarosTavolsag = adatLista[varosKezdoIndex].km - adatLista[elozoVarosVege].km ;
            }
            //Console.WriteLine(adatLista[elozoVarosEleje].jelzes);

            if(elozoVarosTavolsag >= kovetkezoVarosTavolsag)
            {
                Console.WriteLine($"A legközelebbi település: {adatLista[elozoVarosEleje].jelzes}");
            }
            else
            {
                Console.WriteLine($"A legközelebbi település: {adatLista[kovetkezoVarosIndex].jelzes}");
            }
=======
            int koveketkezoVarosTavolsag = teljesUtHossz;
            if(kovetkezoVarosIndex > -1)
            {
                koveketkezoVarosTavolsag = adatLista[kovetkezoVarosIndex].km - adatLista[varosVegIndex].km;
            }
            //Console.WriteLine(kovetkezoVarosTavolsag);

            //valami hiányzik :D

            var kovetkezoV = adatLista.Where(adat => adat.isTelepules() && adat.km > vVeg.km).First();
            var elozoV = adatLista.Where(adat => adat.isTelepules() && adat.km < vKezdet.km).Last();

>>>>>>> 4081968b37fbfb5e24cfbf364c2472cc583d5055
        }
    }
}
