using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3gyak
{
    abstract internal class Video:IMedia
    {
        protected Video()
        {

        }
        public string Tipus
        {
            get
            {
                return "Video";
            }
            set
            {
                //nem csinál semmit
            }
        }
        abstract public void mutat();
    }
}
