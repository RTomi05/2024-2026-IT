using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak2
{
    internal abstract class Nadrag:IRuha
    {
        public string tipus { get; set; }
        public string anyag { get; set; }
        public string meret { get; set; }
        public abstract void nyulik();
        public override string ToString()
        {
            return "Típus: " + tipus + ", " + "anyag: " + anyag + ", méret: " + meret ;
        }
    }
}
