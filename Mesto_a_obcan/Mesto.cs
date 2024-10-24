using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Mesto
    {
        public string nazov;
        public List<Obcan>Obcania;

        public Mesto(string Bratislava) 
        { 
         this.nazov = Bratislava;
            Obcania = new List<Obcan>();
        }

        public void PridajObcana (Obcan obcan) 
        { 
         Obcania.Add(obcan);
        }

        public void VypisObcanov()
        {
            Console.WriteLine("Obcania mesta " + nazov + ":");
            foreach (var obcan in Obcania) 
            {
                obcan.VypisInfo();
            }
        }
    }
}
