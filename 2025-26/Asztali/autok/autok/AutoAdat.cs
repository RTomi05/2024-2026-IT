using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    class AutoAdat
    {
        public string rendszam;
        public int ora;
        public int perc;
        public int sebesseg;

        public AutoAdat(string rendszam, int ora, int perc, int sebesseg)
        {
            this.rendszam = rendszam;
            this.ora = ora;
            this.perc = perc;
            this.sebesseg = sebesseg;
        }

        public AutoAdat(string sor)
        {
            string[] vag = sor.Split("\t");

            this.rendszam = vag[0];
            this.ora = int.Parse(vag[1]);
            this.perc = int.Parse(vag[2]);
            this.sebesseg = int.Parse(vag[3]);
        }
    }
}
