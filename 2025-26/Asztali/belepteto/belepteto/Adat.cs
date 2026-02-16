using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belepteto
{
    internal class Adat
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
            this.esemenyKod = int.Parse(vag[2]);
        }
    }
}
