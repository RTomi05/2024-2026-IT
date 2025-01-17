using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    internal class Adatok
    {
        public string nev;
        public string kod;
        public Adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            nev = vag[0];
            kod = vag[1];
        }

        public bool hibas()
        {

            return kod.Replace("E", "").Replace("H", "").Replace("J", "").Replace("B", "").Length != 0;


            //VAGY

            /*

            bool valasz = false;
            for (int i = 0; i < kod.Length; i++)
            {
                if (kod[i] != 'E' && kod[i] != 'H' && kod[i] != 'J' && kod[i] != 'B')
                {
                    valasz = true;
                    break;
                }

            return valasz;
            }

            */
        }

        public int iranyvaltasok()
        {

            int darab = 0;
            for (int i = 1; i < kod.Length; i++)
            {
                if (kod[i] != kod[i - 1])
                {
                    darab++;
                }
            }
            return darab;
        }

        public int[] vegpont()
        {
            int[] koordinata= new int[] {0,0};
            for (int i = 0; i < kod.Length; i++)
            {
                switch (kod[i]) {
                    case 'E': koordinata[1]++; break;
                    case 'H': koordinata[1]--; break;
                    case 'J': koordinata[0]++; break;
                    case 'B': koordinata[0]--; break;
                }
            }

            return koordinata;
        }

        public double uthossz()
        {
            int[] vegpont = this.vegpont();

            return Math.Sqrt(vegpont[0] * vegpont[0] + vegpont[1] * vegpont1]);
        }
    }
}
