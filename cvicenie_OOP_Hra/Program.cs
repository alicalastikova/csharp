namespace cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Player = new Player();
            Player.Name = "TitaniusOcelChuj";
            Player.HP = 70;
            Player.Mana = 10;
            Player.AttackPower = 5;
            Player.CritChange = 50;
            

            Player Player2 = new Player();
            Player2.Name = "Octopus";
            Player2.HP = 65;
            Player2.Mana = 10;
            Player2.AttackPower = 5;
            Player2.CritChange = 10;


            while (Player.HP >= 0 && Player2.HP >= 0)
            {
                Console.WriteLine("Octopus:" + Player2.HP);
                Console.WriteLine("TitaniusOcelChuj:" + Player.HP);
                Player.DamagePlayer(Player2);
                Player2.DamagePlayer(Player);

                if (Player.HP <= 20)
                {
                    bool wasHealed = Player.Heal();
                    if (wasHealed) 
                    {
                        Console.WriteLine("TitaniusOcelChuj postava bola uzdravena.");
                    }
                    else
                    {
                        Console.WriteLine("TitaniusOcelChuj nema manu nebola uzdravena.");
                    }

                }
                if (Player2.HP <= 20)
                {
                    bool wasHealed = Player2.Heal();
                    if (wasHealed)
                    {
                        Console.WriteLine("Octopus postava bola uzdravena.");
                    }
                    else
                    {
                        Console.WriteLine("Octopus nema manu nebola uzdravena.");
                    }

                }

                Random random = new Random();
                int randomNumber = random.Next(0, 100);
                
                if (randomNumber <= 5)
                {
                    Player.RefilMana(10);
                    Console.WriteLine("TitaniusOcelChuj doplnena mana.");
                }

                
                int Number = random.Next(0, 100);
                if (randomNumber <= 5)
                {
                      Player2.RefilMana(10);
                      Console.WriteLine("Octopus doplnena mana.");
                }
            }

            if (Player.HP < 0)
            {
                Console.WriteLine("Octopus vyhral");
            }
            
            if (Player2.HP < 0)
            {
                      
                Console.WriteLine("TitaniusOcelChuj vyhral");
            }

            
        }
        
        



         
    }
}