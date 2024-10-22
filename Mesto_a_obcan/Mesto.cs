using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Mesto
    {
        public string meno { get; set; }
        public int vek { get; set; }
        public string meno2 { get; set; }
        public int vek2 { get; set; }

        public Mesto(string meno, int Vek)
        {
            vek = Vek;
            this.meno = meno;
        }
        public Mesto(string meno, int Vek)
        {
            vek2 = Vek;
            this.meno2 = meno;
        }



    }
}
