namespace ForsakenLands.Characters
{
    using System.Collections.Generic;

    using ForsakenLands.Items;
    using ForsakenLands.Characters.Heros;

    public class Warrior : Hero
    {
        public Warrior(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int accuracy,
            int evasion,
            int range,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, accuracy, evasion, range, itemInventory)
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
