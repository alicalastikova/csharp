namespace Mesto_a_obcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Mesto Mesto = new Mesto();
            Mesto.meno = "jana";
            Mesto.vek = 24;
            Mesto.meno2 = "olga";
            Mesto.vek2 = 1999;
            Console.WriteLine("Obcania mesta Bratislava:");
            Console.WriteLine("meno:" + Mesto.meno, "  vek:"+ Mesto.vek);
            Console.WriteLine("meno:" + Mesto.meno2, "  vek:" + Mesto.vek2);


        }
    }
}