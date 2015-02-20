using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Items.Weapon
{
    class Dagger : Item
    {
        private int attackPoints;

        public Dagger(int id, string name, int attackPoints)
            : base(id, name)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }
    }
}
