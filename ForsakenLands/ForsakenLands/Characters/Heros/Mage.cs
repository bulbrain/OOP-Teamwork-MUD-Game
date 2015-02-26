namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Mage : Hero
    {
        private const int MAGE_DEFAULT_ATTACK_POINTS = 10;
        private const int MAGE_DEFAULT_DEFENCE_POINTS = 10;
        private const int MAGE_DEFAULT_HEALTH_POINTS = 100;
        private const int MAGE_DEFAULT_MANA_POINTS = 60;

        public Mage()
            : base(
                    MAGE_DEFAULT_ATTACK_POINTS,
                    MAGE_DEFAULT_DEFENCE_POINTS,
                    MAGE_DEFAULT_HEALTH_POINTS,
                    MAGE_DEFAULT_MANA_POINTS,
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
