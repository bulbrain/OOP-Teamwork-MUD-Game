using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Items.Potion
{
    class HealPotion : Item
    {

        int healthPoints;
        public HealPotion(int id, string name, int healthPoints)
            : base(id, name)
        {
            this.HealthPoints = healthPoints;
        }

        public int HealthPoints { get; set; }
    }
}
