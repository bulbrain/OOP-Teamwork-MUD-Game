namespace ForsakenLands.Items.Potion
{
    class ManaPotion : Item
    {
        private int manaPoints;
        
        public ManaPotion(int id, string name, int manaPoints)
            : base(id, name)
        {
            this.ManaPoints = manaPoints;
        }

        public int ManaPoints { get; set; }
    }
}
