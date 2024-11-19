using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihaUloh
{
    public class Program
    {
        public static void Main()
        {
            tim tim1 = new tim("Draci");
            tim tim2 = new tim("sokoli");
            tim tim3 = new tim("orli");

            Console.WriteLine("celkovy pocet timov: " + tim.ziskaj_pocet_timov());
        }


    }

}