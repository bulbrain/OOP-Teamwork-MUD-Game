namespace ForsakenLands.Items
{
    using ForsakenLands;
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Item : GameObject, IBaseProperties
    {
        private int attackPoints;
        private int defencePoints;
        private int healthPoints;
        private int manaPoints;

        public Item(string name, int attackPoints, int defencePoints, int healthPoints, int manaPoints)
            : base()
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
        }

        public string Name { get; set; }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The atack points can't be negative!");
                }

                this.attackPoints = value;
            }
        }

        public int DefencePoints
        {
            get { return this.defencePoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The defense points can't be negative!");
                }

                this.defencePoints = value;
            }
        }

        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The health points can't be negative!");
                }

                this.healthPoints = value;
            }
        }

        public int ManaPoints
        {
            get { return this.manaPoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The mana points can't be negative!");
                }

                this.manaPoints = value;
            }
        }
    }
}