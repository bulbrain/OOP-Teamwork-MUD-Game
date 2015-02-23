namespace ForsakenLands.Characters.Monsters
{
    public class Dragon : Monster
    {
        private const int DRAGON_DEFAULT_ATTACK_POINTS = 200;
        private const int DRAGON_DEFAULT_DEFENCE_POINTS = 100;
        private const int DRAGON_DEFAULT_HEALTH_POINTS = 100;
        private const int DRAGON_DEFAULT_MANA_POINTS = 100;
        private const int DRAGON_DEFAULT_ACCURACY = 10;
        private const int DRAGON_DEFAULT_EVASION = 2;
        private const int DRAGON_DEFAULT_RANGE = 3;
        private const int DRAGON_DEFAULT_LIVES = 1;

        public Dragon(int id)
            : base(
            id,
            DRAGON_DEFAULT_ATTACK_POINTS,
            DRAGON_DEFAULT_DEFENCE_POINTS,
            DRAGON_DEFAULT_HEALTH_POINTS, 
            DRAGON_DEFAULT_MANA_POINTS,
            DRAGON_DEFAULT_ACCURACY, 
            DRAGON_DEFAULT_EVASION, 
            DRAGON_DEFAULT_RANGE, 
            DRAGON_DEFAULT_LIVES)
        {
        }
    }
}
