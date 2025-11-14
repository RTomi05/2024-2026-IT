using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metHU
{
    internal class Adatok
    {
        //BP 0000 VRB02 23
        public string telepules;
        public string ido;
        public string szeliranyEsErosseg;
        public int homerseklet;

        public Adatok(string sor)
        {
            string[] vag = sor.Split(' ');

            eltarol(vag[0], vag[1], vag[2], int.Parse(vag[3]));
        }

        public Adatok(string telepules, string ido, string szeliranyEsErosseg, int homerseklet)
        {
            eltarol(telepules, ido, szeliranyEsErosseg, homerseklet);
        }
        void eltarol(string telepules, string ido, string szeliranyEsErosseg, int homerseklet)
        {
            this.telepules = telepules;
            this.ido = ido;
            this.szeliranyEsErosseg = szeliranyEsErosseg;
            this.homerseklet = homerseklet;
        }
    }
}