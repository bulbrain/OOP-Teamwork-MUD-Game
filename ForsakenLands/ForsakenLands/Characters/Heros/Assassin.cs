namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Assassin : Hero
    {
        private const int ASSASSIN_DEFAULT_ATTACK_POINTS = 40;
        private const int ASSASSIN_DEFAULT_DEFENCE_POINTS = 10;
        private const int ASSASSIN_DEFAULT_HEALTH_POINTS = 100;
        private const int ASSASSIN_DEFAULT_MANA_POINTS = 0;

        public Assassin()
            : base(
                    ASSASSIN_DEFAULT_ATTACK_POINTS,
                    ASSASSIN_DEFAULT_DEFENCE_POINTS,
                    ASSASSIN_DEFAULT_HEALTH_POINTS,
                    ASSASSIN_DEFAULT_MANA_POINTS,
                    null,
                    HeroType.Assassin)
        {
        }
        
        public Assassin(
            int attackPoints,
            int defencePoints,
            int manaPoints,
            int healthPoints,
            List<Item> itemInventory)
            : base(attackPoints, defencePoints, healthPoints, manaPoints, itemInventory, HeroType.Assassin)
        {
        }
    }
}
