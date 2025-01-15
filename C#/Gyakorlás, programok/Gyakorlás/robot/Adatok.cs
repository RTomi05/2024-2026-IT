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
        }

        public int iranyvaltasok()
        {

            int darab = 0;
            for (int i = 0; i < kod.Length; i++)
            {
                if (kod[i] != kod[i - 1])
                {
                    darab++;
                }
            }
            return darab;
        }
    }
}
