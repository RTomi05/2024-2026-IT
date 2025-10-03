using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak2
{
    internal interface IRuha
    {
        string tipus { get; set; }
        string anyag { get; set; }
        string meret { get; set; }
        public void nyulik();
    }
}
