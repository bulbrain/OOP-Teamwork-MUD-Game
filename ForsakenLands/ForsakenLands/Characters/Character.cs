namespace ForsakenLands.Characters
{
    using System;

    using ForsakenLands;
    using System.Text;
    using ForsakenLands.Interfaces;

    public abstract class Character : GameObject, IBaseAttributable, ILevelable
    {
        private const int INNITIAL_LEVEL = 1;
        protected const double STAT_AND_EXP_MODIFIER_FROM_LEVEL = 0.2;

        private int attackPoints;
        private int defencePoints;
        private int healthPoints;
        private int manaPoints;
        private int level;
        private int currentHealthPoints;
        private int currentManaPoints;

        public Character(
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints)
            : base()
        {
            this.Level = INNITIAL_LEVEL;
            this.AttackPoints = CalculateStatAccordingToLevel(attackPoints);
            this.DefencePoints = CalculateStatAccordingToLevel(defencePoints);
            this.HealthPoints = CalculateStatAccordingToLevel(healthPoints);
            this.ManaPoints = CalculateStatAccordingToLevel(manaPoints);
            this.CurrentHealthPoints = this.HealthPoints;
            this.CurrentManaPoints = this.ManaPoints;
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

        public int CurrentHealthPoints
        {
            get
            {
                return this.currentHealthPoints;
            }

            set
            {
                this.currentHealthPoints = value;
            }
        }

        public int CurrentManaPoints
        {
            get
            {
                return this.currentManaPoints;
            }

            set
            {
                this.currentManaPoints = value;
            }
        }


        public int CalculateStatAccordingToLevel(int stat)
        {
            if (this.Level == 1)
            {
                return stat;
            }
            else
            {
                int statScaledWithLevel = stat + Convert.ToInt32(stat * STAT_AND_EXP_MODIFIER_FROM_LEVEL) * (this.Level - 1);
                return statScaledWithLevel;
            }
        }

    }
}