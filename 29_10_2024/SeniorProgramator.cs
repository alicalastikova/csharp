using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class SeniorProgramator : programator
    {
        public int pocetProjektov;
        public SeniorProgramator(string meno, int Vek, string programovacijazyk, int pocetProjektov) : base(meno, Vek, programovacijazyk)
        {
            this.pocetProjektov = pocetProjektov;
        }
        public new void vypisinfo()
        {
            Console.WriteLine(meno+ "," + vek+ "programuje v: " + pocetProjektov+ " a ma "+pocetProjektov+" projektov");
        }
    }
}
