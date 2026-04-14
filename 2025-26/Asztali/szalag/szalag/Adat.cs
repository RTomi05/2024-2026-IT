using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalag
{
    class Adat
    {
        public int ido;
        public int honnan;
        public int hova;
        public int tomeg;

        public Adat(int ido, int honnan, int hova, int tomeg)
        {
            this.ido = ido;
            this.honnan = honnan;
            this.hova = hova;
            this.tomeg = tomeg;
        }

        public Adat(string sor)
        {
            string[] sorok = sor.Split(" ");
            this.ido = int.Parse(sorok[0]);
            this.honnan = int.Parse(sorok[1]);
            this.hova = int.Parse(sorok[2]);
            this.tomeg = int.Parse(sorok[3]);
        }
    }
}
