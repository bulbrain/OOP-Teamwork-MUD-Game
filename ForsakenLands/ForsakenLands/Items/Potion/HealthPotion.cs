namespace ForsakenLands.Items.Potion
{
    public class HealthPotion : Potion
    {
        const int HealthRestored = 10;

        public HealthPotion(int id, string name, int healthPoints, int manaPoints)
            : base(id, name, HealthRestored, 0)
        {
        }
    }
}