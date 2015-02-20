using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Items.Potion
{
    class ManaPotion : Item
    {
        int manaPoints;
        public ManaPotion(int id, string name, int manaPoints)
            : base(id, name)
        {
            this.ManaPoints = manaPoints;
        }

        public int ManaPoints { get; set; }
    }
}
