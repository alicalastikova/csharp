using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class ucitel
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public ucitel(string meno, int Vek)
        {
            vek = Vek;
            this.meno = meno;
        }
        public void vypisinfo()
        {
            Console.WriteLine("Ucitel meno:" + meno + "Ucitel vek:" + vek);
        }
    }

    
}
