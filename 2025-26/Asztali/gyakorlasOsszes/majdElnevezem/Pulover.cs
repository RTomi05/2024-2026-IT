using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majdElnevezem
{
    internal abstract class Pulover:IRuha
    {
        private string anyag;
        
        public Pulover(string anyag)
        {
            this.anyag = anyag;
        }
        public string Anyag
        {
            get
            {
                return anyag;
            }
        }

        private string meret;
        public string Meret
        {
            get
            {
                return meret;
            }
            set
            {
                meret = value;
            }
        }

        abstract public void mosas();
    }
}
