namespace ForsakenLands.Items
{
    using ForsakenLands;
    using ForsakenLands.Interfaces;
    using System;
    using System.Text;

    public class Item : GameObject, IBaseAttributable
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

        public override string ToString()
        {
            StringBuilder itemString = new StringBuilder();
            itemString.Append(this.GetType().Name + " with");

            if (this.attackPoints > 0)
            {
                itemString.Append(String.Format(" Attack Points: {0}", this.attackPoints));
            }

            if (this.defencePoints > 0)
            {
                itemString.Append(String.Format(" Defense Points: {0}", this.defencePoints));
            }

            if (this.manaPoints > 0)
            {
                itemString.Append(String.Format(" Mana Points: {0}", this.manaPoints));
            }

            if (this.healthPoints > 0)
            {
                itemString.Append(String.Format(" Health Points: {0}", this.healthPoints));
            }

            return itemString.ToString();
        }
    }
}