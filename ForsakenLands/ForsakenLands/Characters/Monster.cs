namespace ForsakenLands.Characters
{
    using System;

    using ForsakenLands.Interfaces;

    public class Monster : Character, IExperienceAwardable
    {
        // Use a constant for base value in case we want to scale the awarded exp with monster level in the future
        private const int BaseAwardedExperience = 50;

        private int awardedExperience;

        public Monster(
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints)
            : base(attackPoints, defencePoints, healthPoints, manaPoints)
        {
            this.AwardedExperience = BaseAwardedExperience;
        }

        public int AwardedExperience
        {
            get
            {
                return this.awardedExperience;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience awarded by a monster cannot be a negative number.");
                }

                this.awardedExperience = value;
            }
        }
    }
}
