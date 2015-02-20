namespace ForsakenLands.Items.Weapon
{
    public class Staff : Item
    {
        private int attackPoints;

        public Staff(int id, string name, int attackPoints)
            : base(id, name)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }
    }
}
