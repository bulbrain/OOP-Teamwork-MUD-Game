namespace ForsakenLands.Items.Potion
{
    public class HealthPotion : Potion
    {
        const int HealthRestored = 10;

        public HealthPotion(string name)
            : base(name, HealthRestored, 0)
        {
        }
    }
}