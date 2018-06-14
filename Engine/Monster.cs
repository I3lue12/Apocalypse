﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardXP, int rewardGold, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            CurrentHP = currentHP;
            MaxHP = maxHP;


        }



    }
}
