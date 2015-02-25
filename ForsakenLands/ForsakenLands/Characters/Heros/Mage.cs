namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Mage : Hero
    {
        public Mage()
            : base(1, 10, 10, 100, 60, null, HeroType.Mage)
        {
        }

        public Mage(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints, itemInventory, HeroType.Mage)
        {
        }
    }
}
