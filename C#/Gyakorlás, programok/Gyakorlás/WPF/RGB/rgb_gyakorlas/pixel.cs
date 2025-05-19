using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb_gyakorlas
{
    internal class Pixel
    {
        public int r;
        public int g;
        public int b;

        public Pixel(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public string rgbkod()
        {

            return $"RGB({this.r},{this.g},{this.b})";
        }

        public int komponensOsszeg()
        {
            return this.r + this.g + this.b;
        }

        public bool vilagos()
        {
            return komponensOsszeg() > 600;
        }

    }
}
