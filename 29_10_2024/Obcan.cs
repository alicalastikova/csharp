using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class Obcan
    {
        public string meno;
        public int vek;
       

        public Obcan(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public virtual void vypisinfo()
        {
            Console.WriteLine("meno: " + meno ,"vek: "+ vek);
        }
       
    }
}
