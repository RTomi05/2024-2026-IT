using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace koordinatas_operatoros
{
    internal class Pont3D : Pont
    {
        public int z;
        public Pont3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
