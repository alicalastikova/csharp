using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class Obcan
    {
        protected string meno;
        protected int vek;
       
        public string Meno
        {
            get { return meno; }
            set { meno = value; }
        }
        public int Vek
        {

            get { return vek; }
            set { vek = value; }
        }

        public Obcan(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public Obcan()
        {

        }

        public virtual void vypisinfo()
        {
            Console.WriteLine("meno: " + meno ,"vek: "+ vek);
        }

       
    }
}
