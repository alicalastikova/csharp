using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class lekar
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public lekar(string meno, int Vek)
        {
            vek = Vek;
            this.meno = meno;
        }
        public void vypisinfo()
        {
            Console.WriteLine("Lekar meno:" + meno + "Lekar vek:" + vek);
        }
    }

}
