namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Assassin : Hero
    {
        public Assassin()
            : base(1, 50, 10, 100, 0, null, HeroType.Assassin)
        {
        }
        
        public Assassin(
            int id,
            int attackPoints,
            int defencePoints,
            int manaPoints,
            int healthPoints,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints, itemInventory, HeroType.Assassin)
        {
        }
    }
}
