namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Assassin : Hero
    {
        private const int AssassinDefaultAttackPoints = 40;
        private const int AssassinDefaultDefencePoints = 10;
        private const int AssassinDefaultHealthPoints = 100;
        private const int AssassinDefaultManaPoints = 0;

        public Assassin()
            : base(
                    AssassinDefaultAttackPoints,
                    AssassinDefaultDefencePoints,
                    AssassinDefaultHealthPoints,
                    AssassinDefaultManaPoints,
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
