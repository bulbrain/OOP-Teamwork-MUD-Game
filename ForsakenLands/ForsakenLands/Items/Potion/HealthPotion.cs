namespace ForsakenLands.Items.Potion
{
    using System.Text;

    public class HealthPotion : Potion
    {
        private const int HealthRestored = 30;

        public HealthPotion(string name = null)
            : base(HealthRestored, 0, name)
        {
        }

        public override string ToString()
        {
            StringBuilder potionString = new StringBuilder();
            potionString.Append(base.ToString());
            potionString.Append(" Restore Points " + HealthRestored);
            return potionString.ToString();
        }
    }
}