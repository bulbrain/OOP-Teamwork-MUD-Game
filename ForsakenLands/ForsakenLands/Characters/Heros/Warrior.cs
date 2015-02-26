namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Warrior : Hero
    {
        private const int WARRIOR_DEFAULT_ATTACK_POINTS = 40;
        private const int WARRIOR_DEFAULT_DEFENCE_POINTS = 20;
        private const int WARRIOR_DEFAULT_HEALTH_POINTS = 100;
        private const int WARRIOR_DEFAULT_MANA_POINTS = 0;

        public Warrior()
            : base(
                    WARRIOR_DEFAULT_ATTACK_POINTS,
                    WARRIOR_DEFAULT_DEFENCE_POINTS,
                    WARRIOR_DEFAULT_HEALTH_POINTS,
                    WARRIOR_DEFAULT_MANA_POINTS,
                    null,
                    HeroType.Warrior)
        {
        }
        
        public Warrior(
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints,
            List<Item> itemInventory)
            : base(attackPoints, defencePoints, healthPoints, manaPoints, itemInventory, HeroType.Warrior)
        {
        }
    }
}
