using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle ToyotaSupraTurbo = new Vehicle();
            ToyotaSupraTurbo.EvidencneCisloAuta = "ZA123AL";
            ToyotaSupraTurbo.RokVyroby = 1988;
            ToyotaSupraTurbo.JePlatnaSTK = true;
            ToyotaSupraTurbo.TypMotoru = 'D';

            Vehicle elonTesla = new Vehicle("ZA123LA", 2009,false,9.9, 'E');

            Console.WriteLine("info o aute:" + elonTesla.EvidencneCisloAuta);
            Console.WriteLine("info o aute:" + ToyotaSupraTurbo.VypisAuta(true));
            Console.WriteLine("info o aute:" + ToyotaSupraTurbo.VypisAuta(false));

            List<Vehicle> list = new List<Vehicle>();
            list.Add(elonTesla);
            list.Add(ToyotaSupraTurbo);
            foreach (Vehicle v in list)
            {
                Console.WriteLine(Vehicle.VypisAuta(false));
            }


        }
    }
}