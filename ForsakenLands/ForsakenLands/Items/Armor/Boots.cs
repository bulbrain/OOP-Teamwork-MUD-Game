using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Items.Armor
{
    class Boots : Item
    {
        private int defencePoints;

        public Boots(int id, string name, int defencePoints)
            : base(id, name)
        {
            this.DefencePoints = defencePoints;
        }

        public int DefencePoints { get; set; }
    }
}