namespace ForsakenLands.Items.Potion
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Potion : Item, IConsumable
    {
        private int healthPoints;
        private int manaPoints;

        public Potion(int id, string name, int healthPoints, int manaPoints)
            : base(id, name)
        {
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The health points value of a potion must be zero or a positive nubmer.");
                }

                this.healthPoints = value;
            }
        }

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The mana points value of a potion must be zero or a positive nubmer.");
                }

                this.manaPoints = value;
            }
        }
    }
}
