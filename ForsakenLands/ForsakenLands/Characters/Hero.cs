namespace ForsakenLands.Characters
{
    using System.Collections.Generic;

    using ForsakenLands.Items;
    using ForsakenLands.Characters.Heros;
    using System;
    using System.Linq;
    using ForsakenLands.Interfaces;

    public class Hero : Character, IInventoriable, IExperiancable
    {
        private const int INNITIAL_EXPERIENCE = 0;
        private const int ExperienceToLevelTwo = 100;

        private List<Item> itemInventory;
        private HeroType heroType;
        private int currentExperience;
        private int experienceToNextLevel;

        public Hero(
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            List<Item> itemInventory,
            HeroType heroType)
            : base(attackPoints, defencePoints, healthPoints, manaPoints)
        {
            this.ItemInventory = itemInventory;
            this.HeroType = heroType;
            this.CurrentExperience = INNITIAL_EXPERIENCE;
            this.ExperienceToNextLevel = ExperienceToLevelTwo;
        }

        public List<Item> ItemInventory
        {
            get { return this.itemInventory; }
            set
            {
                if (value == null)
                {
                    this.itemInventory = new List<Item>();
                }
                else
                {
                    this.itemInventory = value;
                }
            }
        }

        public HeroType HeroType
        {
            get { return this.heroType; }
            set
            {
                this.heroType = value;
            }
        }

        public int CurrentExperience
        {
            get
            {
                return this.currentExperience;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Current experience cannot be a negative number.");
                }

                this.currentExperience = value;
            }
        }

        public int ExperienceToNextLevel
        {
            get
            {
                return this.experienceToNextLevel;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience to next level cannot be a negative number.");
                }

                this.experienceToNextLevel = value;
            }
        }

        public void AddItemToInventory(Item item)
        {
            this.ItemInventory.Add(item);
        }

        public void RemoveItemFromInventory(Item item)
        {
            if (!this.ItemInventory.Contains(item))
            {
                throw new ArgumentException("There is no such item in the inventory.");
            }

            this.ItemInventory.Remove(item);
        }

        /// <summary>
        /// This method uses an item from the inventory, according to the type of the item.
        /// If the item implements the IConsumable interface, it is consumed and then removed from the inventory.
        /// If the item implements the IEquippable interface, it is equipped and any other equipped item of the exact 
        /// same type is unequipped
        /// </summary>
        /// <param name="itemIndex">
        /// Represents the index of the item from the ItemInventory
        /// </param>
        public virtual void UseItem(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= this.ItemInventory.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid Item Inventory Index.");
            }

            // add item stats to hero stats
            Item currentItem = this.ItemInventory[itemIndex];
            this.AddPointsToHeroPoints(currentItem);

            if (this.ItemInventory[itemIndex] is IConsumable)
            {
                // remove item from inventory after it has been consumed
                this.ItemInventory.RemoveAt(itemIndex);
            }
            else if (this.ItemInventory[itemIndex] is IEquippable)
            {
                var itemToEquip = (IEquippable)this.ItemInventory[itemIndex];
                var itemToEquipType = itemToEquip.GetType();

                var sameTypeItems = this.itemInventory.Where(item => item.GetType().Name == itemToEquip.GetType().Name);
                   
                foreach (IEquippable equippable in sameTypeItems)
                {
                    if (equippable.IsEquipped == true)
                    {
                        //remove points from previous equipped
                        this.RemovePointsFromHeroPoints((Item)equippable);
                    }
                    equippable.IsEquipped = false;
                }

                itemToEquip.IsEquipped = true;
            }
        }

        public static Hero CreateHeroByType(Heros.HeroType heroType)
        {
            Hero hero = null;

            if (heroType == HeroType.Assassin)
            {
                hero = new Assassin();
            }
            else if (heroType == HeroType.Mage)
            {
                hero = new Mage();
            }
            else
            {
                hero = new Warrior();
            }

            return hero;
        }

        private void AddPointsToHeroPoints(Item item)
        {
            this.AttackPoints += item.AttackPoints;
            this.DefencePoints += item.DefencePoints;
            this.ManaPoints += item.ManaPoints;
            this.HealthPoints += item.HealthPoints;
        }

        private void RemovePointsFromHeroPoints(Item item)
        {
            this.AttackPoints -= item.AttackPoints;
            this.DefencePoints -= item.DefencePoints;
            this.ManaPoints -= item.ManaPoints;
            this.HealthPoints -= item.HealthPoints;
        }

        /// <summary>
        /// This method can be used when a monster is killed, or quest completed, which awards experience
        /// </summary>
        /// <param name="experienceToAd">The amount of experience to be added to 
        /// the CurrentExperience of the hero</param>
        public void AddExperience(int experienceToAd)
        {
            if (experienceToAd < 0)
            {
                throw new ArgumentException("The experience to be added to the hero must be a positive integer.");
            }

            if (this.CurrentExperience + experienceToAd >= this.ExperienceToNextLevel)
            {
                this.Level++;
                this.CurrentExperience = 0;
                this.ExperienceToNextLevel += Convert.ToInt32(this.ExperienceToNextLevel * STAT_AND_EXP_MODIFIER_FROM_LEVEL);
            }
            else
            {
                this.CurrentExperience += experienceToAd;
            }
        }
    }
}
