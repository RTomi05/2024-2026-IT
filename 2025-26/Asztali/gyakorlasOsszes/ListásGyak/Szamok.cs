using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListásGyak
{
    internal class Szamok
    {
        List<int> szamok;

        public Szamok(int[] szamok)
        {
            this.szamok = new List<int>(szamok);
        }

        public static Szamok operator +(Szamok egyik, int masik)
        {
            List<int> szamok = new List<int>(egyik.szamok);
            szamok.Add(masik);
            return new Szamok(szamok.ToArray());
        }

        public static Szamok operator +(Szamok egyik, Szamok masik)
        {
            var szamok = new List<int>(egyik.szamok);

            foreach (int szam in masik.szamok)
            {
                szamok.Add(szam);
            }
            return new Szamok(szamok.ToArray());
        }
        public static int operator +(int szam, Szamok szamok)
        {
            /*
            int osszeg = 0;
            foreach(int egySzam in szamok.szamok)
            {
                osszeg += egySzam;
            }*/
            return szam + szamok.szamok.Sum();
        }

        public static Szamok operator -(Szamok egyik, Szamok masik)
        {
            List<int> ujSzamok = new List<int>(egyik.szamok);

            for(int i = 0; i < masik.szamok.Count; i++)
            {
                ujSzamok.Remove(masik.szamok[i]);
            }
            return new Szamok(ujSzamok.ToArray());
        }

        public static Szamok operator -(Szamok egyik, int masik)
        {
            List<int> ujSzamok = new List<int> (egyik.szamok);
            ujSzamok.Remove(masik);
            return new Szamok(ujSzamok.ToArray());
        }

        public static int operator -(int szam, Szamok szamok)
        {
            return szam - szamok.szamok.Sum();
        }

        public static Szamok operator *(Szamok egyik, Szamok masik)
        {
            List <int> ujSzamok = new List<int>();

            if(egyik.szamok.Count < masik.szamok.Count)
            {
                for (int i = 0; i < egyik.szamok.Count; i++)
                {

                    /*
                     * 1,2
                     * 1,2,3,4
                     * eredmény: 1,4
                     */

                    ujSzamok.Add(egyik.szamok[i] * masik.szamok[i]);
                }
            }
            else
            {
                for (int i = 0; i < masik.szamok.Count; i++)
                {
                    ujSzamok.Add(egyik.szamok[i] * masik.szamok[i]);
                }
            }

            //Második megoldás
            int meddig = Math.Min(egyik.szamok.Count, masik.szamok.Count);
            for (int i = 0; i < meddig; i++)
            {
                ujSzamok.Add(egyik.szamok[i] * masik.szamok[i]);
            }

            //Harmadik megoldás
            for (int i = 0; i < meddig; i++)
            {
                try
                {
                    ujSzamok.Add(egyik.szamok[i] * masik.szamok[i]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    //Üres
                }

            }


        }
        public override string ToString()
        {
            return string.Join(", ", this.szamok);
        }
    }
}
