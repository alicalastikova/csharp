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
        public List<lekar> lekari = new List<lekar>();
        public List<ucitel> ucitelia = new List<ucitel>();
        public List<programator> programatori = new List<programator>();

        public mesto(string nazov)
        {
            this.nazov = nazov;
        }

        public void PridajLekara(lekar lekar)
        {
            lekari.Add(lekar);
        }

        public void PridajProgramatora(programator programator)
        {
            programatori.Add(programator);
        }

        public void PridajUcitela(ucitel ucitel)
        {
            ucitelia.Add(ucitel);
        }
        
        public void VypisObcana()
        {
            Console.WriteLine("Obcania mesta " + nazov + ":");
            foreach (lekar lekar in lekari)
            {
                lekar.vypisinfo();
            }
            foreach (programator programator in programatori)
            {
                programator.vypisinfo();
            }
            foreach (ucitel ucitel in ucitelia)
            {
                ucitel.vypisinfo();
            }
        }
    }
}   


    

