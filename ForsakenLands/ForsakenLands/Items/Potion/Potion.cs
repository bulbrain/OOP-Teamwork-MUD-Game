namespace ForsakenLands.Items.Potion
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Potion : Item, IConsumable
    {
        private int healthToRestore;
        private int manaToRestore;

        public Potion(int healthToRestore, int manaToRestore, string name = null)
            : base(name, 0, 0, 0, 0)
        {
            this.HealthToRestore = healthToRestore;
            this.ManaToRestore = manaToRestore;
        }

        public int HealthToRestore
        {
            get 
            { 
                return this.healthToRestore; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The health points can't be negative!");
                }

                this.healthToRestore = value;
            }
        }

        public int ManaToRestore
        {
            get
            {
                return this.manaToRestore;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The mana points can't be negative!");
                }

                this.manaToRestore = value;
            }
        }
    }
}
