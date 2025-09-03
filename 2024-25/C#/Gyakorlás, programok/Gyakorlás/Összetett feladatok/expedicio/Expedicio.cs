using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expedicio
{
    internal class Expedicio
    {
        public int napSorszam;
        public int radioAmator;
        public string feljegyzes;
        public int felnottFarkas =- 1;
        public int kolyokFarkas =- 1;

        public Expedicio(string sor1, string sor2)
        {
            string[] vag = sor1.Split(" ");
            napSorszam = int.Parse(vag[0]);
            radioAmator = int.Parse(vag[1]);
            feljegyzes = sor2;
        }

        public void farkasKeres()
        {
            string[] vag = feljegyzes.Split(" ") [0].Split("/");
            try
            {
                felnottFarkas = Convert.ToInt32(vag[0]);
                kolyokFarkas = Convert.ToInt32(vag[1]);
            }
            catch (Exception)
            {
                //dob egy hibaüzenetet
                //throw; -> megállítja a programot
            }
            
        }
    }
}
