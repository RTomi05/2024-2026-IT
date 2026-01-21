using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurgenMukodo
{
    internal class Penztarca
    {
        public int osszeg;
        public Penztarca(int osszeg)
        {
            this.osszeg = osszeg;
        }

        public static Penztarca operator-(Penztarca p1, int osszeg)
        {
            return new Penztarca(p1.osszeg - osszeg);
        }

        public static Penztarca operator -(Penztarca p1, Penztarca p2)
        {
            return new Penztarca(p1.osszeg - p2.osszeg);
        }

        public static int operator -(int osszeg, Penztarca p1)
        {
            return osszeg - p1.osszeg;
        }

        public static Penztarca operator +(Penztarca p1, int osszeg)
        {
            return new Penztarca(p1.osszeg + osszeg);
        }

        public static Penztarca operator +(Penztarca p1, Penztarca p2)
        {
            return new Penztarca(p1.osszeg + p2.osszeg);
        }

        public static int operator +(int osszeg, Penztarca p1)
        {
            return osszeg + p1.osszeg;
        }

        public static bool operator <(Penztarca p1, Penztarca p2)
        {
            return p1.osszeg < p2.osszeg;
        }

        public static bool operator >(Penztarca p1, Penztarca p2)
        {
            return p1.osszeg > p2.osszeg;
        }

        public override string ToString()
        {
            return $"A pénztárcában {osszeg} Euro van.";
        }
    }
}
