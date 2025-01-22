using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futar
{
    internal class Fuvar
    {
        public int nap;
        public int fuvarSzam;
        public int km;

        public Fuvar(string sor)
        {
            string[] vag = sor.Split(" ");

            nap = Convert.ToInt32(vag[0]);
            fuvarSzam = Convert.ToInt32(vag[1]);
            km = Convert.ToInt32(vag[2]);
        }
    }
}
