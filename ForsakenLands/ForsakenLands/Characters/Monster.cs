namespace ForsakenLands.Characters
{
    using ForsakenLands.Attributes;
    using ForsakenLands.Interfaces;

    public class Monster : Character
    {
        public Monster(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int manaPoints)
            : base(id, attackPoints, defencePoints, healthPoints, manaPoints)
        {
        }
    }
}
