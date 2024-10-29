using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class mesto
    {
        public string nazov;
        public List<Obcan> obcania = new List<Obcan>();
       
        public mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();    
        }

        public void PridajLekara(lekar lekar)
        {
            obcania.Add(lekar);
        }
        
        public void VypisObcana()
        {
            Console.WriteLine("Obcania mesta " + nazov + ":");
            foreach (Obcan obcan in obcania)
            {
                obcan.vypisinfo();
            }
           
        }
    }
}   


    

