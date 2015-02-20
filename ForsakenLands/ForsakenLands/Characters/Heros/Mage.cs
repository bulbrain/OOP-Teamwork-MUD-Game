namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Mage : Hero
    {
        public Mage(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            int accuracy,
            int evasion,
            int range,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints, accuracy, evasion, range, itemInventory)
        {
        }

        public override void AddItemToInventory(Item item)
        {

        }

        public override void RemoveItemFromInventory(Item item)
        {

        }
    }
}
