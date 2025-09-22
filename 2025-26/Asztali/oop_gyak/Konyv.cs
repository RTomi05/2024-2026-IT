using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyak
{
    internal class Konyv
    {
        public string cim;
        public string szerzo;
        public Konyv(string cim, string szerzo)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            //ngjnwrjgnwrgjrg
        }

        public override string ToString()
        {
            return this.cim + " (" + this.szerzo+")";
        }
    }
}
