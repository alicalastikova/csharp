using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _29_10_2024
{
    public class mesto
    {
        protected string nazov;
        public List<Obcan> obcania = new List<Obcan>();
        public string Nazov { get; set; }
       
        public mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();    
        }

        public mesto() 
        {
          
        }

        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        
        public void VypisObcana()
        {
            Console.WriteLine("Obcania mesta " + nazov + ":");
            foreach (Obcan obcan in obcania)
            {
                obcan.vypisinfo();
            }
           
        }
        public void UlozDoSuboru(string nazovSuboru)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(nazovSuboru, json);
            Console.WriteLine("Data boli ulozene");
        }

        public static mesto NacitajZoSUboru(string nazovSuboru)
        {
            if (File.Exists(nazovSuboru))
            {
                string json = File.ReadAllText(nazovSuboru);
                mesto mesto = JsonSerializer.Deserialize<mesto>(json);
                return mesto;

            }
            return null;

        }
    }
}   


    

