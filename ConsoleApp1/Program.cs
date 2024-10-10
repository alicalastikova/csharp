public class Program
{

    public static void Main(string[] args)
    {
        Random random = new Random();
        int vygenerovanecislo = random.Next(maxValue: 100);


        Console.WriteLine("cislo");

        while (true)
        {
            string X = Console.ReadLine();
            int attermps = 5;
            int Y = int.Parse(X);


            if (Y < vygenerovanecislo)
            {
                Console.WriteLine("tvoje cislo je mensie");
            }
            if (Y > vygenerovanecislo)
            {
                Console.WriteLine("tvoje cislo je vecsie");
            }
            if (Y == vygenerovanecislo)
            {
                Console.WriteLine("uhadol si cislo");
            }

        }
    }





}