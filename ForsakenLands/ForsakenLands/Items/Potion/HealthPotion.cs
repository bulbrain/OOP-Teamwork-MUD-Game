namespace ForsakenLands.Items.Potion
{
    public class HealthPotion : Potion
    {
        const int HealthRestored = 10;

        public HealthPotion(string name, int healthPoints, int manaPoints)
            : base(name, HealthRestored, 0)
        {
        }
    }
}