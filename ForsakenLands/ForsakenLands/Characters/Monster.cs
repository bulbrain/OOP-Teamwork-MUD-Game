using ForsakenLands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForsakenLands.Characters
{
    public class Monster : Character, IRegenerable
    {
        public Monster(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int accuracy,
            int evasion,
            int range,
            int lives)
            : base(id, attackPoints, defencePoints, healthPoints, accuracy, evasion, range)
        {
            this.Lives = lives;
        }
    
        public int Lives { get; set; }

        public void AddLive() 
        {
            this.Lives++;
        }

        public void RemoveLive()
        {
            this.Lives--;
        }

        public virtual void Regenerate()
        {
            // to do
        }
    }
}
