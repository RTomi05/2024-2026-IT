using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace utca_WPF
{
    class KeritesSzin
    {
        public string kod;
        public string nev;
        public SolidColorBrush szin;

        public KeritesSzin(string kod, string nev, SolidColorBrush szin)
        {
            this.kod = kod;
            this.nev = nev;
            this.szin = szin;
        }
    }
}