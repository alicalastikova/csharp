using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Vehicle
    {
        public string EvidencneCisloAuta { get; set; }
        public int RokVyroby { get; set; }
        public bool JePlatnaSTK { get; set; }
        public double PriemernaSpotreba { get; set; }
        public char TypMotoru { get; set; }

        public Vehicle(string evidencecisloAuta, int rokVyroby, bool jePlatnaTK, double priemernaSpotreba, char typMotora)
        {
            EvidencneCisloAuta = evidencecisloAuta;
            RokVyroby = rokVyroby;
            JePlatnaSTK = jePlatnaTK;
            PriemernaSpotreba = priemernaSpotreba;
            TypMotoru = typMotora;

        }

        public string VypisAuta()
        {
            var informacie = $"SPZ:{EvidencneCisloAuta},Rok:{RokVyroby}, STK:{JePlatnaSTK}" +
                             $"Spoterba: {PriemernaSpotreba},Motor:{TypMotoru}";
            return informacie;
        
        }
        


        
    }

}

