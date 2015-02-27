namespace ForsakenLands.Items.Potion
{
    public class HealthPotion : Potion
    {
        const int HealthRestored = 10;

        public HealthPotion(string name = null)
            : base(HealthRestored, 0, name)
        {
        }
    }
}