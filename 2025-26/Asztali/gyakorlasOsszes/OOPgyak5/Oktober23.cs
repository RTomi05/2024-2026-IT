using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak5
{
    internal class Oktober23:IskolaiRendezveny
    {
        private List<string> szereplok;
        public override List<string> Szereplok
        {
            get
            {
                return szereplok;
            }
            set
            {
                szereplok = value;
            }
        }
        public override void Zajlik()
        {
            Console.WriteLine("Igen, zajlik!");
        }
        public override string ToString()
        {
            return
                "A rendezvény neve: " + Nev +
                ", a rendezvény szervezője: " + Rendezo +
                ", a rendezvényben szereplők: " +
                String.Join(", ", Szereplok);
        }
    }
}
