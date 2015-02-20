using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Items.Armor
{
    class Head : Item
    {
        private int defencePoints;

        public Head(int id, string name, int defencePoints)
            : base(id, name)
        {
            this.DefencePoints = defencePoints;
        }

        public int DefencePoints { get; set; }
    }
}
