using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    internal class Utasok
    {
        public string kategoria;
        public int tulelok;
        public int eltuntek;
        public Utasok(string sor)
        {
            //"gyerekek-masodosztaly;24;0"
            string[] vag = sor.Split(';');

            kategoria = vag[0];
            tulelok = Convert.ToInt32(vag[1]);
            eltuntek = Convert.ToInt32(vag[2]);
        }
    }
}
