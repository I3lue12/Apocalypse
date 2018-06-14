﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Medkit : Item
    {
      
        public int AmountToHeal { get; set; }

        public Medkit(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {

            AmountToHeal = amountToHeal;

        }


    }
}
