namespace ForsakenLands.Characters
{
    using System;

    using ForsakenLands;
    using System.Text;
    using ForsakenLands.Interfaces;

    public abstract class Character : GameObject, IBaseProperties, ILevelable
    {
        private const int INNITIAL_LEVEL = 1;
        protected const double STAT_AND_EXP_MODIFIER_FROM_LEVEL = 0.2;

        private int attackPoints;
        private int defencePoints;
        private int healthPoints;
        private int manaPoints;
        private int level;

        public Character(
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints)
            : base()
        {
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.HealthPoints = healthPoints;
            this.ManaPoints = manaPoints;
            this.Level = INNITIAL_LEVEL;
        }

        public int AttackPoints 
        { 
            get { return this.attackPoints; }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("value", "The atack points can't be negative!");
                }

                this.attackPoints = CalculateStatAccordingToLevel(value);
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

                this.defencePoints = CalculateStatAccordingToLevel(value);
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

                this.healthPoints = CalculateStatAccordingToLevel(value);
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

                this.manaPoints = CalculateStatAccordingToLevel(value);
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value", "Hero level cannot be a negative number.");
                }

                this.level = value;
            }
        }


        public int CalculateStatAccordingToLevel(int stat)
        {
            int statScaledWithLevel = stat + Convert.ToInt32(stat * STAT_AND_EXP_MODIFIER_FROM_LEVEL) * this.Level;

            return statScaledWithLevel;
        }

    }
}