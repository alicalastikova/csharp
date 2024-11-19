using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihaUloh
{
    public class tim
    {
        public static int pocet_timov = 0;
        public string nazov;
        public tim( string nazov)
        {
            this.nazov = nazov;
            pocet_timov++;
        }
        public static int ziskaj_pocet_timov()
        {
            return pocet_timov;
        }
        public string ziskaj_nazov()
        { 
            return nazov; 
        }
    }
    
}
