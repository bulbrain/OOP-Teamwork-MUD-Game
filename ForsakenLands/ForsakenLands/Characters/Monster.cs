namespace ForsakenLands.Characters
{
    using ForsakenLands.Attributes;
    using ForsakenLands.Interfaces;

    public class Monster : Character
    {
        public Monster(
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints)
            : base(attackPoints, defencePoints, healthPoints, manaPoints)
        {
        }
    }
}
