namespace ForsakenLands.Items.Armor
{
    public class Boots : Item
    {
        private int defencePoints;

        public Boots(int id, string name, int defencePoints)
            : base(id, name)
        {
            this.DefencePoints = defencePoints;
        }

        public int DefencePoints { get; set; }
    }
}