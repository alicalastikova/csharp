﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class programator : Obcan
    {
        protected string programovacijazyk;
        public programator(string meno, int Vek, string programovacijazyk) : base(meno, Vek) 
        {
           this.programovacijazyk = programovacijazyk;
        }
        public programator()
        { }
       
        public override void vypisinfo()
        {
            Console.WriteLine( meno + "," + vek + "rokov, pise kod v jazyku:" + programovacijazyk);
        }
    }
}
