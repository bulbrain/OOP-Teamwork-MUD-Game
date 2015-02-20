using System;
using System.Collections.Generic;

using ForsakenLands;
using ForsakenLands.Items;
using ForsakenLands.Interfaces;

namespace ForsakenLands.Characters.Heros
{
    public abstract class Hero : Character, IInventoriable
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

        public abstract void AddItemToInventory(Item item);

        public abstract void RemoveItemFromInventory(Item item);
    }
}
