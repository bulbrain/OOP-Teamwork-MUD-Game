using System;
using System.Collections.Generic;

using ForsakenLands;
using ForsakenLands.Items;

namespace ForsakenLands.Characters
{
    public abstract class Character : GameObject
    {
        private int attackPoints;
        private int defencePoints;
        private int healthPoints;
        private int accuracy;
        private int evasion;
        private int range;

        public Character(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int accuracy,
            int evasion,
            int range)
            : base(id)
        {
            this.AttackPoints = attackPoints;
            this.DefencePoints = defencePoints;
            this.HealthPoints = healthPoints;
            this.Accuaracy = accuracy;
            this.Evasion = evasion;
            this.Range = range;
        }

        public int AttackPoints 
        { 
            get { return this.attackPoints; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The atack points can't be negative!");
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
                    throw new ArgumentNullException("The defense points can't be negative!");
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
                    throw new ArgumentNullException("The health points can't be negative!");
                }
                this.healthPoints = value;
            }
        }

        public int Accuaracy 
        {
            get { return this.accuracy; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The accuracy can't be negative!");
                }

                this.accuracy = value;
            }
        }

        public int Evasion
        {
            get { return this.evasion; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The evasion can't be negative!");
                }

                this.evasion = value;
            }
        }

        public int Range
        {
            get { return this.range; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The range can't be negative!");
                }

                this.range = value;
            }
        }
    }
}
