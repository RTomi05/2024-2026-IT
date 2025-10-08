using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak4
{
    internal class Muzliszelet:Desszert
    {
        public Muzliszelet() { }

        public override void Elfogyasztas()
        {
            Console.WriteLine($"Mmm, ez a {Nev} nagyon finom!");
        }
    }
}
