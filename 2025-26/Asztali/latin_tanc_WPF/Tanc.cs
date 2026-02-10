using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latin_tanc_WPF
{
    internal class Tanc
    {
        public string tancNev;
        public string lany;
        public string fiu;

        public Tanc(List<string>adat)
        {
            tancNev = adat[0];
            lany = adat[1];
            fiu = adat[2];
        }
    }
}
