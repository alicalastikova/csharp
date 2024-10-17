using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_OOP_Hra
{
    public class Player
    {

        public string Name { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int AttackPower { get; set; }
        public int CritChange { get; set; }

        public void DamagePlayer(Player player)
        {
            int damageMultiPlayer = 1;

            Random random = new Random();   
            int randomNumber = random.Next(0,100);
            if (randomNumber <= this.CritChange ) 
            {
                damageMultiPlayer = 2;
                Console.WriteLine(this.Name+ "dal kriticky zasah.");
            }


            int HPofEnemy = player.HP;
            int AttackOfCurrentPlayer = this.AttackPower * damageMultiPlayer;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            player.HP = HPofEnemyAfterFight;

        }
        public bool Heal() 
        {
            if (this.Mana > 0)
            {
                int HPOPlayer = this.HP;
                int ManaOfPlayer = this.Mana;
                int HPOPlayerAfterHeal = HPOPlayer + ManaOfPlayer;
                this.Mana = 0;
                this.HP = HPOPlayerAfterHeal;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void RefilMana(int newMana)
        { 
            this.Mana = newMana;

            
        }
    }
}
