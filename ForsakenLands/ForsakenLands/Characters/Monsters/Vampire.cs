namespace ForsakenLands.Characters.Monsters
{
    public class Vampire : Monster
    {
        private const int VampireDefaultAttackPoints = 30;
        private const int VampireDefaultDefencePoints = 20;
        private const int VampireDefaultHealthPoints = 70;
        private const int VampireDefaultManaPoints = 0;

        public Vampire()
            : base(
                VampireDefaultAttackPoints,
                VampireDefaultDefencePoints,
                VampireDefaultHealthPoints,
                VampireDefaultManaPoints)
        {
        }
    }
}
