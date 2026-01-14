using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sipalya
{
    internal class Palya
    {
        public int ho;
        public Palya(int ho)
        {
            this.ho = ho;
        }

        public static Palya operator +(Palya p1, Palya p2)
        {
            return new Palya(p1.ho + p2.ho);
        }

        public static Palya operator +(Palya p1, int vastagsag)
        {
            return new Palya(p1.ho + vastagsag);
        }

        public static int operator +(int vastagsag, Palya p1)
        {
            return p1.ho + vastagsag;
        }
        public static Palya operator -(Palya p1, Palya p2)
        {
            return new Palya(p1.ho - p2.ho);
        }

        public static Palya operator -(Palya p1, int p2)
        {
            return new Palya(p1.ho - p2);
        }

        public static Palya operator -(int p1, Palya p2)
        {
            return new Palya(p1 - p2.ho);
        }

        public static bool operator <(Palya p1, Palya p2)
        {
            return p1.ho < p2.ho;
        }

        public static bool operator >(Palya p1, Palya p2)
        {
            return p1.ho > p2.ho;
        }

        public static bool operator <=(Palya p1, Palya p2)
        {
            return p1.ho <= p2.ho;
        }

        public static bool operator >=(Palya p1, Palya p2)
        {
            return p1.ho >= p2.ho;
        }

        public static bool operator ==(Palya p1, Palya p2)
        {
            return p1.ho == p2.ho;
        }

        public static bool operator !=(Palya p1, Palya p2)
        {
            return p1.ho != p2.ho;
        }

        public static Palya operator *(Palya p1, int p2)
        {
            return new Palya(p1.ho * p2);
        }
    }
}
