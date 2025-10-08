using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak4
{
    internal interface IEtel
    {
        string Nev { get; set; }
        int Energia { get; set; }

        void Elfogyasztas();
    }
}
