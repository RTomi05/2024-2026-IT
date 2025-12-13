using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace godor
{
    internal class Godor
    {
        public List<Melyseg> melysegek;
        public Godor()
        {
            melysegek = new List<Melyseg>();
        }

        public void Add(Melyseg melyseg)
        {
            melysegek.Add(melyseg);
        }
    }
}
