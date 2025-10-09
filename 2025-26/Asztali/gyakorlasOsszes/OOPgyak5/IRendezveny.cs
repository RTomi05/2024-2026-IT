using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak5
{
    internal interface IRendezveny
    {
        string Nev { get; set; }
        string Rendezo { get; set; }
        void Zajlik();
    }
}
