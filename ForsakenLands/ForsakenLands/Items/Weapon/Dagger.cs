namespace ForsakenLands.Items.Weapon
{
    public class Dagger : Item
    {
        private int attackPoints;

        public Dagger(int id, string name, int attackPoints)
            : base(id, name)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }
    }
}
