namespace ForsakenLands.Items.Potion
{
    public class HealPotion : Item
    {
        private int healthPoints;
        
        public HealPotion(int id, string name, int healthPoints)
            : base(id, name)
        {
            this.HealthPoints = healthPoints;
        }

        public int HealthPoints { get; set; }
    }
}
