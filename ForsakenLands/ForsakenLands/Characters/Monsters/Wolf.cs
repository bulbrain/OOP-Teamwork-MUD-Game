namespace ForsakenLands.Characters.Monsters
{
    public class Wolf : Monster
    {
        private const int WolfDefaultAttackPoints = 20;
        private const int WolfDefaultDefencePoints = 10;
        private const int WolfDefaultHealthPoints = 70;
        private const int WolfDefaultManaPoints = 0;

        public Wolf()
            : base(
                WolfDefaultAttackPoints,
                WolfDefaultDefencePoints,
                WolfDefaultHealthPoints,
                WolfDefaultManaPoints)
        {
        }
    }
}
