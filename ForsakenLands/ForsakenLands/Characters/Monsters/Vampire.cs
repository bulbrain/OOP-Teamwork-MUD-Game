namespace ForsakenLands.Characters.Monsters
{
    public class Vampire : Monster
    {
        private const int VAMPIRE_DEFAULT_ATTACK_POINTS = 30;
        private const int VAMPIRE_DEFAULT_DEFENCE_POINTS = 20;
        private const int VAMPIRE_DEFAULT_HEALTH_POINTS = 70;
        private const int VAMPIRE_DEFAULT_MANA_POINTS = 0;

        public Vampire()
            : base(
                VAMPIRE_DEFAULT_ATTACK_POINTS,
                VAMPIRE_DEFAULT_DEFENCE_POINTS,
                VAMPIRE_DEFAULT_HEALTH_POINTS,
                VAMPIRE_DEFAULT_MANA_POINTS)
        {
        }
    }
}
