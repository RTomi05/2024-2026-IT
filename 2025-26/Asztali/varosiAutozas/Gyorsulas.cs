using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varosiAutozas
{
    internal class Gyorsulas
    {
        public int kezdes;
        public int veg;
        public int sebesseg;
        public Gyorsulas elozo;

        public Gyorsulas(int kezdes, int veg, int sebesseg)
        {
            this.kezdes = kezdes;
            this.veg = veg;
            this.sebesseg = sebesseg;
        }

        public Gyorsulas(string sor)
        {
            string[] adatok = sor.Split("\t");
            this.kezdes = int.Parse(adatok[0]);
            this.veg = int.Parse(adatok[1]);
            this.sebesseg = int.Parse(adatok[2]);
        }

        public Gyorsulas(string sor, Gyorsulas elozo)
        {
            string[] adatok = sor.Split("\t");
            this.kezdes = int.Parse(adatok[0]);
            this.veg = int.Parse(adatok[1]);
            this.sebesseg = int.Parse(adatok[2]);
            this.elozo = elozo;
        }
        public double gyorsulas()
        {
            return (sebesseg - elozo.sebesseg) / (veg - kezdes);
        }

        public double pillanatnyiSebesseg(int idopont)
        {
            if(idopont >= kezdes && idopont <= veg)
            {
                return elozo.sebesseg + (gyorsulas() * (idopont - kezdes));
            }
            else if(idopont > elozo.veg && idopont <= veg)
            {
                return elozo.sebesseg;
            }    
            return -1;
        }
    }
}
