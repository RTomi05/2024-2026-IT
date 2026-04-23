using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyelvvizsga
{
    internal class Nyelv
    {
        public string nyelv;
        public Dictionary<string, int> evek = new Dictionary<string, int>();
        public Nyelv(string nyelv, Dictionary<string, int> evek)
        {
            this.nyelv = nyelv;
            this.evek = evek;
        }

        public Nyelv(string sor)
        {
            string[] vag = sor.Split(';');
            this.nyelv = vag[0];
            for(int i = 1; i < vag.Length; i++)
            {
                evek[(i+2008).ToString()] = int.Parse(vag[i]);
            }
        }
    }
}
