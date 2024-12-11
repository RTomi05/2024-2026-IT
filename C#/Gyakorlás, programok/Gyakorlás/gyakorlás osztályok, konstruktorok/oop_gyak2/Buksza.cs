using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oop_gyak2
{
    internal class Buksza
    {
        int penz;

        public string szin;
        
        public int Penz
        {
            get
            {
                return penz;
            }
            set
            {
                penz = value;
            }
        }



        public Buksza(int penz)
        {
            Penz = penz;
        }
        public Buksza(int penz, string szin)
        {
            Penz = penz;
            this.szin = szin;

            
        }

        public override string ToString()
        {
            return $"{szin} buksza, benne {penz} forint.";
        }

    }
}
