namespace cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Player = new Player();
            Player.Name = "TitaniusOcelChuj";
            Player.HP = 30;
            Player.Mana = 10;
            Player.AttackPower = 5;

            Player Player2 = new Player();
            Player2.Name = "octopus";
            Player2.HP = 30;
            Player2.Mana = 10;
            Player2.AttackPower = 5;


            while (Player.HP >= 0 && Player2.HP >= 0)
            {
                Console.WriteLine("octopus:" + Player2.HP);
                Console.WriteLine("TitaniusOcelChuj:" + Player2.HP);
                Player.DamagePlayer(Player2);
                Player2.DamagePlayer(Player);
                

            }
            
            if (Player.HP < 0)
            {
                return Player.Mana;
            }
            else if (Player2.HP < 0) 
            { 
            }
            if (Player2.HP < 0)
            {
                Console.WriteLine("TitaniusOcelChuj vyhral");
            }

        }
        
        



         
    }
}