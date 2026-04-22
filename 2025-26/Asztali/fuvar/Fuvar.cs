using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuvar
{
    internal class Fuvar
    {
        public int azonosito;
        public string indulas;
        public int idotartam;
        public double tavolsag;
        public double viteldij;
        public double borravalo;
        public string fizetesimod;

        public Fuvar(int azonosito, string indulas, int idotartam, double tavolsag, double viteldij, double borravalo, string fizetesimod)
        {
            this.azonosito = azonosito;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetesimod = fizetesimod;
        }

        public Fuvar(string sor)
        {
            string[] vag = sor.Split(';');
            this.azonosito = int.Parse(vag[0]);
            this.indulas = vag[1];
            this.idotartam = int.Parse(vag[2]);
            this.tavolsag = double.Parse(vag[3]);
            this.viteldij = double.Parse(vag[4]);
            this.borravalo = double.Parse(vag[5]);
            this.fizetesimod = vag[6];
        }

        public double tavolsagKmben
        {
           get
            {
                return this.tavolsag * 1.6;
            }
        }

        public override string ToString()
        {
            return
            this.azonosito + ";" +
            this.indulas + ";" +
            this.idotartam + ";" +
            this.tavolsag + ";" +
            this.viteldij + ";" +
            this.borravalo + ";" +
            this.fizetesimod + ";";
        }
    }
}
