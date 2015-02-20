namespace ForsakenLands.Items
{
    public class Sword : Item
    {
        private int attackPoints;

        public Sword(int id, string name, int attackPoints)
            : base(id, name)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }
    }
}
