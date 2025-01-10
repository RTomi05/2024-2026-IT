using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class Feladat
    {
        List<Adatok> autok = new List<Adatok>();

        public Feladat()
        {
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
        }
        void feladat1()
        {
            string[] sorok = File.ReadAllLines("jeladas.txt");

            for (int i = 0; i < sorok.Length; i++)
            {
                autok.Add(new Adatok(sorok[i]));
            }
        }

        public void feladat2()
        {
            Console.WriteLine("2.feladat:");
            Console.WriteLine("Az utolsó jeladás időpontja {0}:{1}, a jármű rendszáma {2}",
                autok[autok.Count-1].ora,
                autok[autok.Count - 1].perc,
                autok[autok.Count - 1].rendszam);
        }

        void feladat3()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine("Az első jármű: {0}", autok[0].rendszam);

            Console.Write("Jeladásainak időpontjai: ");
            

            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].rendszam == autok[0].rendszam)
                {
                    Console.Write(autok[i].ido() + " ");
                }
            }

            Console.WriteLine();
        }

        void feladat4()
        {
            Console.WriteLine("4. feladat");
            Console.Write("Kérem, adja meg az órát: ");
            int ora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem, adja meg a percet: ");
            int perc = Convert.ToInt32(Console.ReadLine());

            int darab = 0;

            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].check(ora, perc))
                {
                    darab++;
                }
            }

            Console.WriteLine("A jeladások száma: {0}", darab);
        }

        void feladat5()
        {
            Console.WriteLine("5. feladat");
            int legnagyobb = 0;
            for (int i = 0; i < autok.Count;i++)
            {
                if (autok[i].sebesseg > legnagyobb)
                {
                    legnagyobb = autok[i].sebesseg;
                }
            }

            Console.WriteLine("A legnagyobb sebesség km/ h: {0}",legnagyobb);
            Console.Write("A járművek: ");

            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].sebesseg == legnagyobb)
                {
                   Console.Write(autok[i].rendszam + " ");
                }
            }
            Console.WriteLine();
        }

        void feladat6()
        {
            Console.WriteLine("6. feladat");
            Console.Write("Kérem, adja meg a rendszámot: ");
            string rendszam = Console.ReadLine();

            double megtettUt = 0;
            Adatok elozo = new Adatok("q",6,0,0); 

            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].rendszam == rendszam)
                {
                    if (elozo.rendszam == "q")
                    {

                    }
                    else
                    {
                        megtettUt += autok[i].ut(elozo);
                        Console.WriteLine("{0} {1} km",autok[i].ido(),megtettUt);
                    }
                   
                    elozo = autok[i];
                }
            }
        }
    }
}
