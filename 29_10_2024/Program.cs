namespace _29_10_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            mesto bratislava = mesto.NacitajZoSUboru("mesto.json");
            if (bratislava == null)
            {


                bratislava = new mesto("bratislava");

                for (int i = 0; i < 31; i++)
                {
                    Obcan o = GeneratorObcanov.GenerujObcana();
                    bratislava.PridajObcana(o);
                }
                for (int i = 0; i < 31; i++)
                {
                    programator programator = GeneratorObcanov.GenerujProgramatora();
                    bratislava.PridajObcana(programator);
                }

                string subor = "mesto.json";
                bratislava.UlozDoSuboru(subor);

                bratislava.VypisObcana();
            }
            

        }
    }

}