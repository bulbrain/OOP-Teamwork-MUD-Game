namespace ForsakenLands.Characters
{
    using System.Collections.Generic;

    using ForsakenLands.Interfaces;
    using ForsakenLands.Items;
    using ForsakenLands.Characters.Heros;
    using System;

    public class Hero : Character, IInventoriable
    {
        private List<Item> itemInventory;

        public Hero(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            int accuracy,
            int evasion,
            int range,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints, accuracy, evasion, range)
        {
            this.ItemInventory = itemInventory;
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

        public virtual void AddItemToInventory(Item item)
        {
            throw new Exception("Not implemented!");
        }

        public virtual void RemoveItemFromInventory(Item item)
        {
            throw new Exception("Not implemented!");
        }

        //public static Hero CreateHeroByType(Heros.HeroType heroType)
        //{
        //    Hero hero = null;

        //    if (heroType == HeroType.Assassin)
        //    {
        //        hero = new Assassin();
        //    }
        //    else if (heroType == HeroType.Mage)
        //    {
        //        hero = new Mage();
        //    }
        //    else
        //    {
        //        hero = new Warrior();
        //    }

        //    return hero;
        //}
    }
}
