using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koordinatas_operatoros
{
    internal class Pont
    {
        public int x;
        public int y;

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Pont operator +(Pont p1, Pont p2)
        {
            return new Pont(p1.x + p2.x, p1.y + p2.y);
        }

        public static Pont operator -(Pont p1, Pont p2)
        {
            return new Pont(p1.x - p2.x, p1.y - p2.y);
        }

        public static bool operator ==(Pont p1, Pont p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        public static bool operator !=(Pont p1, Pont p2)
        {
            return p1.x != p2.x || p1.y != p2.y;
        }

        public static bool operator >=(Pont p1, Pont p2)
        {
            return p1.Tavolsag() >= p2.Tavolsag();
        }

        public static bool operator <=(Pont p1, Pont p2)
        {
            return p1.Tavolsag() <= p2.Tavolsag();
        }

        public double Tavolsag()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public static Pont operator +(Pont p1, int p2)
        {
            return new Pont(p1.x + p2, p1.y + p2);
        }

        public static Pont operator -(Pont p1, int p2)
        {
            return p1 + p2 *-1;
        }



        public override string ToString()
        {
            return $"(X = {x}, Y = {y})";
        }
    }
}
