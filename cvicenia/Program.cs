using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace cvicenia
{
    public class Program
    {
      public static void Main(string[] args)
      {
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            Obdlznik re = new Obdlznik(x,y);
            int Obsah = re.Obsah();
            Console.WriteLine("obsah je " + Obsah);

            Obdlznik r = new Obdlznik(10*re.x,10*re.y);
            int Obsah = r.Obsah();
            Console.WriteLine("obsah je " + Obsah);
      }

    }
}