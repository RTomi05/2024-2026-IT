using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizibicikli
{
    internal class Kolcsonzes
    {
        public string Nev;
        public string Jarmu;
        public int OraKi;
        public int PercKi;
        public int OraBe;
        public int PercBe;

        public Kolcsonzes(string sor)
        {
            string[] sorok = sor.Split(";");
            Nev = sorok[0];
            Jarmu = sorok[1];
            OraKi = int.Parse(sorok[2]);
            PercKi = int.Parse(sorok[3]);
            OraBe = int.Parse(sorok[4]);
            PercBe = int.Parse(sorok[5]);
        }

        public Kolcsonzes(string nev, string jarmu, int oraki, int percki, int orabe, int percbe)
        {
            Nev = nev;
            Jarmu = jarmu;
            OraKi = oraki;
            PercKi = percki;
            OraBe = orabe;
            PercBe = percbe;
        }

        public string idoKi()
        {
            return $"{this.OraKi}:{this.PercKi:00}";
        }
        public string idoBe()
        {
            return $"{this.OraBe}:{this.PercBe:00}";
        }

        public string idoTartam()
        {
            return $"{idoKi()} - {idoBe()}";
        }

        public bool kintvan(string idopont)
        {
            //10:19

            int percbenKi = this.OraKi * 60 + this.PercKi;

            int percbenBe = this.OraBe * 60 + this.PercBe;

            string[] vag = idopont.Split(":");

            int percbenIdopont = int.Parse(vag[0]) * 60 + int.Parse(vag[1]);

            return percbenKi <= percbenIdopont && percbenBe >= percbenIdopont;

        }

        public int Ar()
        {
            int percbenKi = this.OraKi * 60 + this.PercKi;

            int percbenBe = this.OraBe * 60 + this.PercBe;

            int idoTartam = percbenBe - percbenKi;

            return (idoTartam / 30 + 1) * 2400;
        }
    }
}
