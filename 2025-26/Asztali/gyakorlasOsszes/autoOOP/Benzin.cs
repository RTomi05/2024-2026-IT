using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoOOP
{
    internal abstract class Benzin:Auto
    {
        public string nev { get; set; }
        public void dudal()
        {
            Console.WriteLine("Tütűűűűű!");
        }

        abstract public void vilagit();
    }
}
