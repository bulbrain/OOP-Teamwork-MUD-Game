namespace ForsakenLands.Items.Armor
{
    public class Head : Item
    {
        private int defencePoints;

        public Head(int id, string name, int defencePoints)
            : base(id, name)
        {
            this.DefencePoints = defencePoints;
        }

        public int DefencePoints { get; set; }
    }
}
