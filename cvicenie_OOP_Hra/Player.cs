﻿using System;
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

        public void DamagePlayer(Player player)
        {
            int HPofEnemy = player.HP;
            int AttackOfCurrentPlayer = this.AttackPower;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            player.HP = HPofEnemyAfterFight;




        }


    }
}
