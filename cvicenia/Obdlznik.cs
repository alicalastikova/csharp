using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenia
{
    internal class Obdlznik
    {
        public int x { get; set; }
        public int y { get; set; }

        public Obdlznik(int X, int y)
        {
            x = X;
            this.y = y;
        }

        public int Obsah()
        { 
            return x* y;
        }
       
    }

}
