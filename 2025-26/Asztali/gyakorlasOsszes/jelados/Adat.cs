using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jelados
{
    internal class Adat
    {
        public int ora;
        public int perc;
        public int masodperc;
        public int x;
        public int y;
        public int egeszIdoMasodpercben;
        public Adat(int ora, int perc, int masodperc, int x, int y)
        {
            eltarol(ora, perc, masodperc, x, y);
        }
        public Adat(string sor)
        {
            string[] vag = sor.Split(" ");
            eltarol(Convert.ToInt32(vag[0]),
                    Convert.ToInt32(vag[1]),
                    Convert.ToInt32(vag[2]),
                    Convert.ToInt32(vag[3]),
                    Convert.ToInt32(vag[4]));
        }

        void eltarol(int ora, int perc, int masodperc, int x, int y)
        {
            this.ora = ora;
            this.perc = perc;
            this.masodperc = masodperc;
            this.x = x;
            this.y = y;

            this.egeszIdoMasodpercben = this.ora * 3600 + this.perc * 60 + masodperc;
        }

        public string koordinatak()
        {
            return $"x={x} y={y}";
        }

        public int elteltMasodperc(Adat masik)
        {
            return Math.Abs(this.egeszIdoMasodpercben - masik.egeszIdoMasodpercben);
        }

        public string elteltIdo(Adat masik)
        {
            int mp = elteltMasodperc(masik);
            return $"{mp / 3600}:{mp % 3600 / 60}:{mp / 3600 % 60}";
        }

        public double tavolsag(Adat masik)
        {
            //return Math.Sqrt(Math.Pow(this.x - masik.x, 2) + Math.Pow(this.y - masik.y, 2));
            return Double.Hypot(this.x - masik.x, this.y - masik.y);
        }

        public Elteres kimaradt(Adat masik)
        {
            int dX = Math.Abs(masik.x - this.x) / 10;
            int dY = Math.Abs(masik.y - this.y) / 10;
            int dT = (this.elteltMasodperc(masik) / 60)/5;

            if (dX > dT || dY > dT)
            {
                return new Elteres("koordináta-eltérés", Math.Max(dX, dY));
            }
            else if (dX < dT && dY < dT)
            {
                return new Elteres("időeltérés", dT);
            }
            else
            {
                return new Elteres("", 0);
            }
        }

        //static függvények MEGNÉZÉSE
    }

    class Elteres
    {
        public string tipus;
        public int darab;
        public Elteres(string tipus, int darab)
        {
            this.tipus = tipus;
            this.darab = darab;
        }
    }
}
