namespace _29_10_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mesto bratislava = new mesto("bratislava");

            bratislava.PridajProgramatora(new programator(" Igor ", 34));
            bratislava.PridajLekara(new lekar(" Anna ", 28));
            bratislava.PridajUcitela(new ucitel(" peter ", 20));

            bratislava.VypisObcana();
        }
    }
}