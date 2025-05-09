using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    internal class Jatekos
    {
        public string nev;
        public DateOnly elsodatum;
        public DateOnly utolsoDatum;
        public int suly;
        public int magassag;

        public Jatekos(string nev, DateOnly elsoDatum, DateOnly utolsoDatum, int suly, int magassag)
        {
            this.nev = nev;
            this.elsodatum = elsoDatum;
            this.utolsoDatum = utolsoDatum;
            this.suly = suly;
            this.magassag = magassag;
        }

        public double magassagCentimeterben
        {
            get { return Math.Round(this.magassag * 2.54, 1); }
        }

        public static Jatekos Factory(string sor)
        {
            //"Jim Abbott;1989-04-08;1999-07-21;200;75"
            string[] vag = sor.Split(';');
            return new Jatekos(vag[0], DateOnly.Parse(vag[1]), DateOnly.Parse(vag[2]), int.Parse(vag[3]), int.Parse(vag[4]));
        }

        public bool jatszottE(int ev)
        {
            return ev >= this.elsodatum.Year && ev <= this.utolsoDatum.Year;
        }
    }
}
