using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jelados
{
    internal class Adat
    {
        public int ora;
        public int perc;
        public int masodperc;
        public int x;
        public int y;
        public Adat(int ora, int perc, int masodperc, int x, int y)
        {
            eltarol(ora, perc, masodperc, x, y);
        }
        public Adat(string sor)
        {
            string[] vag = sor.Split(" ");
            eltarol(Convert.ToInt32(vag[0]),
                    Convert.ToInt32(vag[1]),
                    Convert.ToInt32(vag[2]),
                    Convert.ToInt32(vag[3]),
                    Convert.ToInt32(vag[4]));
        }

        void eltarol(int ora, int perc, int masodperc, int x, int y)
        {
            this.ora = ora;
            this.perc = perc;
            this.masodperc = masodperc;
            this.x = x;
            this.y = y;
        }
    }
}
