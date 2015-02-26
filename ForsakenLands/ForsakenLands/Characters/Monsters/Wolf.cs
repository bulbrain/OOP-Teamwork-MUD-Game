namespace ForsakenLands.Characters.Monsters
{
    public class Wolf : Monster
    {
        private const int WOLF_DEFAULT_ATTACK_POINTS = 20;
        private const int WOLF_DEFAULT_DEFENCE_POINTS = 10;
        private const int WOLF_DEFAULT_HEALTH_POINTS = 70;
        private const int WOLF_DEFAULT_MANA_POINTS = 0;

        public Wolf()
            : base(
                WOLF_DEFAULT_ATTACK_POINTS,
                WOLF_DEFAULT_DEFENCE_POINTS,
                WOLF_DEFAULT_HEALTH_POINTS,
                WOLF_DEFAULT_MANA_POINTS)
        {
        }
    }
}
