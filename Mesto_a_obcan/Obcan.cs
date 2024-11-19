using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Obcan
    {
        public string meno {  get; set; }
        
        public int vek { get; set; }

        public Obcan(string meno, int Vek)
        {
            vek = Vek;
            this.meno = meno;
        }
        
        public void VypisInfo()
        {
            Console.WriteLine("meno:" + meno+" vek:" + vek);
        }
    }
}
