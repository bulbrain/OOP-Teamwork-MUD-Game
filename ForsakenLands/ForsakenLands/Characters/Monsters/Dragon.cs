namespace ForsakenLands.Characters.Monsters
{
    public class Dragon : Monster
    {
        private const int DRAGON_DEFAULT_ATTACK_POINTS = 30;
        private const int DRAGON_DEFAULT_DEFENCE_POINTS = 10;
        private const int DRAGON_DEFAULT_HEALTH_POINTS = 70;
        private const int DRAGON_DEFAULT_MANA_POINTS = 0;

        public Dragon()
            : base(
            DRAGON_DEFAULT_ATTACK_POINTS,
            DRAGON_DEFAULT_DEFENCE_POINTS,
            DRAGON_DEFAULT_HEALTH_POINTS, 
            DRAGON_DEFAULT_MANA_POINTS)
        {
        }
    }
}
