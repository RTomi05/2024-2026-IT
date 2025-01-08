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

        }
    }
}
