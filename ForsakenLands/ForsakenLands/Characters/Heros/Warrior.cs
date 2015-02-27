namespace ForsakenLands.Characters.Heros
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public class Warrior : Hero
    {
        private const int WarriorDefaultAttackPoints = 40;
        private const int WarriorDefaultDefencePoints = 20;
        private const int WarriorDefaultHealthPoints = 100;
        private const int WarriorDefaultManaPoints = 0;

        public Warrior()
            : base(
                    WarriorDefaultAttackPoints,
                    WarriorDefaultDefencePoints,
                    WarriorDefaultHealthPoints,
                    WarriorDefaultManaPoints,
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
