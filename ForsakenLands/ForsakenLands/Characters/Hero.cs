namespace ForsakenLands.Characters
{
    using System.Collections.Generic;

    using ForsakenLands.Interfaces;
    using ForsakenLands.Items;
    using ForsakenLands.Characters.Heros;
    using System;
    using System.Linq;

    public class Hero : Character, IInventoriable
    {
        private List<Item> itemInventory;
        private HeroType heroType;

        public Hero(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            List<Item> itemInventory,
            HeroType heroType)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints)
        {
            this.ItemInventory = itemInventory;
            this.HeroType = heroType;
        }

        public HeroType HeroType 
        { 
            get {return this.heroType;}
            set
            {
                this.heroType = value;
            }
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

            if (this.ItemInventory[itemIndex] is IConsumable)
            {
                // add item stats to hero stats

                // remove item from inventory after it has been consumed
                this.ItemInventory.RemoveAt(itemIndex);
            }
            else if (this.ItemInventory[itemIndex] is IEquippable)
            {
                var itemToEquip = (IEquippable)this.ItemInventory[itemIndex];
                var itemToEquipType = itemToEquip.GetType();

                // Unequip items of the same type
                foreach (IEquippable equippable in this.ItemInventory.Where(i => i.GetType() == itemToEquipType))
                {
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
    }
}
