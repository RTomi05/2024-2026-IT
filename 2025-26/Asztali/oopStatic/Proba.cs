using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopStatic
{
    internal class Proba
    {

        public static string egyik = "Egyik";
        public static void fv1()
        {
            Console.WriteLine("Én egy statikus függvény vagyok.");
            Console.WriteLine(egyik);
        }
        public void fv2()
        {
            Console.WriteLine("Én egy dinamikus függvény vagyok.");
            Console.WriteLine(egyik);
        }
    }
}
