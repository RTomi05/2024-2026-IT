using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belepteto
{
    class Adat
    {
        public string kod;
        public string ido;
        public int esemenyKod;


        public Adat(string kod, string ido, int esemenyKod)
        {
            this.kod = kod;
            this.ido = ido;
            this.esemenyKod = esemenyKod;
        }

        public Adat(string sor)
        {
            string[] vag = sor.Split(" ");

            this.kod = vag[0];
            this.ido = vag[1];
            this.esemenyKod = Convert.ToInt32(vag[2]);
        }

        public static bool operator <(Adat a, string ido)
        {
            return perc(a.ido) < perc(ido);
        }

        public static bool operator >(Adat a, string ido)
        {
            return perc(a.ido) > perc(ido);
        }

        public static bool operator <=(Adat a, string ido)
        {
            return perc(a.ido) <= perc(ido);
        }

        public static bool operator >=(Adat a, string ido)
        {
            return perc(a.ido) >= perc(ido);
        }

        public static bool operator ==(Adat a, string ido)
        {
            return perc(a.ido) == perc(ido);
        }

        public static bool operator !=(Adat a, string ido)
        {
            return perc(a.ido) == perc(ido);
        }

        public static bool operator <(Adat a, int ido)
        {
            return perc(a.ido) < ido;
        }

        public static bool operator >(Adat a, int ido)
        {
            return perc(a.ido) > ido;
        }

        public static bool operator <=(Adat a, int ido)
        {
            return perc(a.ido) <= ido;
        }

        public static bool operator >=(Adat a, int ido)
        {
            return perc(a.ido) >= ido;
        }

        public static bool operator ==(Adat a, int ido)
        {
            return perc(a.ido) == ido;
        }

        public static bool operator !=(Adat a, int ido)
        {
            return perc(a.ido) == ido;
        }


        public static int perc(string ido)
        {
            return (int)TimeSpan.Parse(ido).TotalSeconds;
        }


    }
}