using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForsakenLands.Characters
{
    internal class HealthChangedEventArgs : EventArgs
    {
        public HealthChangedEventArgs(int healthPoints)
        {
            this.NewHealthPoints = healthPoints;
        }

        public int NewHealthPoints { get; set; }
    }
}
