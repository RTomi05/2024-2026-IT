using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebesseg
{
    internal class Adatok
    {
        public int km;
        public string jelzes;
        public bool varosban;

        public Adatok(string sor)
        {
            string[] vag = sor.Split(' ');
            km = int.Parse(vag[0]);
            jelzes = vag[1];
        }

        public Adatok(int km, string jelzes)
        {
            this.km = km;
            this.jelzes = jelzes;
        }

        public bool isTelepules()
        {
            return jelzes.Length >= 4;
        }

        public int sebessegHatar()
        {
            try
            {
                int sebesseg = int.Parse(jelzes);
                return sebesseg;
            }
            catch (Exception)
            {
                if(isTelepules())
                {
                    return 50;
                }
                else if(jelzes == "]")
                {
                    return 90;
                }
                else if (jelzes == "#")
                {
                    if (varosban)
                    {
                        return 50;
                    }
                    else
                    {
                        return 90;
                    }
                }
                else if (jelzes == "%")
                {
                    if (varosban)
                    {
                        return 50;
                    }
                    else
                    {
                        return 90;
                    }
                }
                else
                {
                    return 0;
                }
                throw;
            }
        }
    }
}
