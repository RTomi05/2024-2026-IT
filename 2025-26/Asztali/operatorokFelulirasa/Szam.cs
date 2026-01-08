using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorokFelulirasa
{
    internal class Szam
    {
        public int szam;
        public Szam(int szam)
        {
            this.szam = szam;
        }
        public override string ToString()
        {
            return "A szám értéke: " + szam;
        }

        public static Szam operator +(Szam szam1, Szam szam2)
        {
            return new Szam(szam1.szam + szam2.szam);
        }

        public static Szam operator +(Szam szam1, int int1)
        {
            return new Szam(szam1.szam + int1);
        }

        public static int operator +(int int1, Szam szam1)
        {
            return int1 + szam1.szam;
        }

        public static double operator +(double double1, Szam szam1)
        {
            return double1 + szam1.szam;
        }

        public static Szam operator ++(Szam szam)
        {
            return new Szam(szam.szam + 1);
        }

        public static Szam operator -(Szam szam1, Szam szam2)
        {
            return new Szam(szam1.szam - szam2.szam);
        }

        public static Szam operator -(Szam szam1, int int1)
        {
            return new Szam(szam1.szam - int1);
        }

        public static int operator -(int int1, Szam szam1)
        {
            return int1 - szam1.szam;
        }

        public static double operator -(double double1, Szam szam1)
        {
            return double1 - szam1.szam;
        }

        public static Szam operator --(Szam szam)
        {
            return new Szam(szam.szam - 1);
        }

        public static bool operator ==(Szam szam, Szam szam2)
        {
            if (szam.szam == szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool operator ==(Szam szam, int szam2)
        {
            if (szam.szam == szam2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(int szam, Szam szam2)
        {
            if (szam == szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Szam szam, Szam szam2)
        {
            if (szam.szam != szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(int szam, Szam szam2)
        {
            if (szam != szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Szam szam, int szam2)
        {
            if (szam.szam != szam2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Szam szam, Szam szam2)
        {
            if (szam.szam > szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(int szam, Szam szam2)
        {
            if (szam > szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Szam szam, int szam2)
        {
            if (szam.szam > szam2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Szam szam, Szam szam2)
        {
            if (szam.szam < szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(int szam, Szam szam2)
        {
            if (szam < szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Szam szam, int szam2)
        {
            if (szam.szam < szam2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Szam szam, Szam szam2)
        {
            if (szam.szam >= szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(int szam, Szam szam2)
        {
            if (szam >= szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Szam szam, int szam2)
        {
            if (szam.szam >= szam2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //<=
        public static bool operator <=(Szam szam, Szam szam2)
        {
            if (szam.szam <= szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(int szam, Szam szam2)
        {
            if (szam <= szam2.szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Szam szam, int szam2)
        {
            if (szam.szam >= szam2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
