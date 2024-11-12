using System.Linq;

namespace Knuha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> knihas = new List<Kniha>()
            {
                new Kniha { Name = "Urla", Autor = "Petra Stehlikova" , PreDospelich = true , Rokvzdania = 2019},
                new Kniha { Name = "Rychlé šípy", Autor = "Jaroslav Foglar" , PreDospelich = true , Rokvzdania = 2016},
                new Kniha { Name = "Labková patrola", Autor = "Miroslav Filipec" , PreDospelich = false , Rokvzdania = 2019},
                new Kniha { Name = "Moja vina", Autor = "Mercedes Ron" , PreDospelich = false, Rokvzdania = 2020},
                new Kniha { Name = "Biblia", Autor = "Pan Neviem" , PreDospelich = false , Rokvzdania = 0},


            };

            Kniha prvaKniha = knihas.FirstOrDefault();


            List<Kniha> KnihyPreDospelich = knihas.Where(kniha => !kniha.PreDospelich).ToList();
            List<Kniha> knihyOdNajstarsej = knihas.OrderBy(kniha => kniha.Rokvzdania).ToList();
            List<Kniha> knihyOdNajnovsej = knihas.OrderByDescending(kniha => kniha.Rokvzdania).ToList();
            List<Kniha> knihyPreMladezOdNajstarsej = knihas.Where(kniha => !kniha.PreDospelich).OrderBy(kniha => kniha.Rokvzdania).ToList();

            var results = knihas.GroupBy(u => u.Rokvzdania).Select(grp => grp.ToList()).ToList();

            foreach (List<Kniha> skupina in results)
            {
                Console.WriteLine($"Skupina:");
                foreach (Kniha knihy in skupina)
                {
                    Console.WriteLine($"Nazov knihy {knihy.Name} od {knihy.Autor} je vhodna pre dospelich je vydana v {knihy.Rokvzdania}.");
                }
            }

            Console.WriteLine();
            var hhh = knihas.GroupBy(o => o.Rokvzdania).ToDictionary(g => g.Key , g => g.ToList());
            foreach (List<Kniha> skupina in results)
            {
                Console.WriteLine($"Skupina:");
                foreach (Kniha knihy in skupina)
                {
                    Console.WriteLine($"Nazov knihy {knihy.Name} od {knihy.Autor} je vhodna pre dospelich je vydana v {knihy.Rokvzdania}.");
                }
            }
            
            


        }   }   }         