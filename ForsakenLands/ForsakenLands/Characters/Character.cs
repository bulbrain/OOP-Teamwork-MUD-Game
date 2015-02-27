﻿namespace ForsakenLands.Characters
{
    using System;

    using ForsakenLands;
    using ForsakenLands.Interfaces;

    internal delegate void ChangedEventHandler(object sender, HealthChangedEventArgs e);

    public abstract class Character : GameObject, IBaseAttributable, ILevelable
    {
        protected const double StatAndExperienceModifierFromLevel = 0.2;

        private const int InitialLevel = 1;

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
            this.Level = InitialLevel;
            this.AttackPoints = this.CalculateStatAccordingToLevel(attackPoints);
            this.DefencePoints = this.CalculateStatAccordingToLevel(defencePoints);
            this.HealthPoints = this.CalculateStatAccordingToLevel(healthPoints);
            this.ManaPoints = this.CalculateStatAccordingToLevel(manaPoints);
            this.CurrentHealthPoints = this.HealthPoints;
            this.CurrentManaPoints = this.ManaPoints;
        }

        internal event ChangedEventHandler HealthChanged;

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

                if (value < 30)
                {
                    this.OnChanged(new HealthChangedEventArgs(value));
                }
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

            int statScaledWithLevel = stat + Convert.ToInt32(stat * StatAndExperienceModifierFromLevel) * (this.Level - 1);

            return statScaledWithLevel;
        }

        internal virtual void OnChanged(HealthChangedEventArgs e)
        {
            if (this.HealthChanged != null)
            {
                this.HealthChanged(this, e);
            }
        }
    }
}