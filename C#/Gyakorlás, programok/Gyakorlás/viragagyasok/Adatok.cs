using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park
{
    internal class Adatok
    {
        public int kezd;
        public int veg;
        public string szin;
        public int sorszam;

        public Adatok(string sor, int sorszam)
        {
            string[] vag = sor.Split(" ");

            kezd = int.Parse(vag[0]);
            veg = int.Parse(vag[1]);
            szin = vag[2];
            this.sorszam = sorszam;
        }

        public bool kapuKetOldal
        {
            get
            {
                return kezd > veg;
            }
        }
    }
}
