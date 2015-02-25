namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Warrior : Hero
    {
        public Warrior()
            : base(1, 50, 15, 100, 0, null, HeroType.Warrior)
        {
        }

        public Warrior(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints, itemInventory, HeroType.Warrior)
        {
        }
    }
}
