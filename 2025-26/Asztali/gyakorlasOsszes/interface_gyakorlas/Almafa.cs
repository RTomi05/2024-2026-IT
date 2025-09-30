using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_gyakorlas
{
    internal class Almafa : Fa
    {
        public string nev { get; set; }
        public void kivag()
        {
            Console.WriteLine("Timberrrrrrr!!!");
        }
        public string terem()
        {
            return "gyümölcsözik";
        }
    }
}
