using System;
using System.Collections.Generic;
using System.Linq;
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

        }
    }
}
