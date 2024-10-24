namespace Mesto_a_obcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Mesto mesto = new Mesto("Bratislava");
           Mesto mesto1 = new Mesto("Zilina");

            
            mesto.PridajObcana(new Obcan("olga", 20));
            mesto.PridajObcana(new Obcan("ivan", 30));
            mesto.PridajObcana(new Obcan("fero", 70));

            mesto1.PridajObcana(new Obcan("oliver", 24));
            mesto1.PridajObcana(new Obcan("stefan", 26));
            mesto1.PridajObcana(new Obcan("pista", 47));

            mesto.VypisObcanov();
            mesto1.VypisObcanov();


        }
    }
}