using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3gyak
{
    internal class Kampanyfilm:Video
    {
        public override void mutat()
        {
            Console.WriteLine("Kampányfilm megy");
        }

        public override string ToString()
        {
            return "A kampányfilmhez kapcsolódó dolgok osztálya";
        }
    }
}
