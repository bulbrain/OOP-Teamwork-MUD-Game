namespace ForsakenLands.Items.Armor
{
    public class Chest : Item
    {
        private int defencePoints;

        public Chest(int id, string name, int defencePoints)
            : base(id, name)
        {
            this.DefencePoints = defencePoints;
        }

        public int DefencePoints { get; set; }
    }
}
