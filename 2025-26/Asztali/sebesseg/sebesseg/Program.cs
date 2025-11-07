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

            Console.WriteLine();
            Console.WriteLine("6. feladat");
            int kovetkezoVarosIndex = -1;
            for (int i = varosVegIndex+1; i < adatLista.Count; i++)
            {
                if (adatLista[i].isTelepules())
                {
                    kovetkezoVarosIndex = i;
                    break;
                }
            }
        }
    }
}
