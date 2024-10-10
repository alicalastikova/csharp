namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SpocitajSamohlasky();
        }
        public static void SpocitajSamohlasky()
        {
            Console.WriteLine("write text");
            string text = Console.ReadLine();
            int length = text.Length;
            Console.WriteLine("text length:" + length);
            int vowelCount = 0;
            char[] vowel ={ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            {
                vowelCount++;
                Console.WriteLine($"Pocet samohlasok: {vowelCount}");
            }
        }

    }
}
