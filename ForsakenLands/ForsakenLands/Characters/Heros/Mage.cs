namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Mage : Hero
    {
        private const int MageDefaultAttackPoints = 10;
        private const int MageDefaultDefencePoints = 10;
        private const int MageDefaultHealthPoints = 100;
        private const int MageDefaultManaPoints = 60;

        public Mage()
            : base(
                    MageDefaultAttackPoints,
                    MageDefaultDefencePoints,
                    MageDefaultHealthPoints,
                    MageDefaultManaPoints,
                    null,
                    HeroType.Mage)
        {
        }

        public Mage(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            List<Item> itemInventory)
            : base(attackPoints, defencePoints, healthPoints, manaPoints, itemInventory, HeroType.Mage)
        {
        }
    }
}
