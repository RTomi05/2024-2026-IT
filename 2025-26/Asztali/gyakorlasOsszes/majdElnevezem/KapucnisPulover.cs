using majdElnevezem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak6
{
    internal class KapucnisPulover:Pulover
    {
        public KapucnisPulover(string anyag):base(anyag)
        {

        }
        public override void mosas()
        {
            Console.WriteLine("A pulóver mosása 30 fokon ajánlott.");
        }
        public override string ToString()
        {
            return $"Kapucnis pulóver anyaga: {Anyag}, mérete: {Meret}";
        }
    }
}
