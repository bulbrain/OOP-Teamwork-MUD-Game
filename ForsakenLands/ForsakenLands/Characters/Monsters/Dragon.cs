namespace ForsakenLands.Characters.Monsters
{
    public class Dragon : Monster
    {
        private const int DragonDefaultAttackPoints = 30;
        private const int DragonDefaultDefencePoints = 10;
        private const int DragonDefaultHealthPoints = 70;
        private const int DragonDefaultManaPoints = 0;

        public Dragon()
            : base(
            DragonDefaultAttackPoints,
            DragonDefaultDefencePoints,
            DragonDefaultHealthPoints, 
            DragonDefaultManaPoints)
        {
        }
    }
}
