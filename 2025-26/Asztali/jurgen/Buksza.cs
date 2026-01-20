using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurgen
{
    internal class Buksza
    {
        //pénztárca -> objektum
        //készpénz -> szám

        public int penz;
        public Buksza(int penz)
        {
            this.penz = penz;
        }

        public static Buksza operator -(Buksza buksza, int kPenz)
        {
            return new Buksza(buksza.penz - kPenz);
        }

        public static Buksza operator +(Buksza buksza, int kPenz)
        {
            return new Buksza(buksza.penz + kPenz);
        }

        public static Buksza operator -(Buksza buksza, Buksza buksza2)
        {
            return new Buksza(buksza.penz - buksza2.penz);
        }

        public static Buksza operator +(Buksza buksza, Buksza buksza2)
        {
            return new Buksza(buksza.penz + buksza2.penz);
        }

        public static bool operator >(Buksza Jurgenbuksza, Buksza buksza2)
        {
            return Jurgenbuksza.penz > buksza2.penz;
        }

        public static bool operator <(Buksza Jurgenbuksza, Buksza buksza2)
        {
            return Jurgenbuksza.penz < buksza2.penz;
        }



        public override string ToString()
        {
            return $"A pénztárcában {this.penz} euró van.";
        }
    }

    
}
