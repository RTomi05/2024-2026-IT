using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace adatokClassGyakorlas
{
    internal class hivas
    {
        public int[] kezdIdo = new int[3];
        public int[] vegIdo = new int[3];
        public hivas(string sor)
        {
            //a sor értéke:  "7 58 33 7 58 47"
            string[] vag = sor.Split(" ");
            kezdIdo[0] = Convert.ToInt32(vag[0]);
            kezdIdo[1] = Convert.ToInt32(vag[1]);
            kezdIdo[2] = Convert.ToInt32(vag[2]);
            vegIdo[3] = Convert.ToInt32(vag[3]);
            vegIdo[4] = Convert.ToInt32(vag[4]);
            vegIdo[5] = Convert.ToInt32(vag[5]);
        }

        public int idoMasodpercbenKezd()
        {
            return kezdIdo[0] * 60 * 60 + kezdIdo[1] * 60 + kezdIdo[2];
        }
        public int idoMasodpercbenVeg()
        {
            return vegIdo[0] * 60 * 60 + vegIdo[1] * 60 + vegIdo[2];
        }
    }
}
