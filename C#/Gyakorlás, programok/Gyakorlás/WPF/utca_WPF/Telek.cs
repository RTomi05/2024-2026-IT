using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace utca_WPF
{
    class Telek
    {
        public bool paros;
        public int szelesseg;
        public KeritesSzin kerites;

        public Telek(bool paros, int szelesseg, KeritesSzin kerites)
        {
            this.paros = paros;
            this.szelesseg = szelesseg;
            this.kerites = kerites;
        }
    }
}