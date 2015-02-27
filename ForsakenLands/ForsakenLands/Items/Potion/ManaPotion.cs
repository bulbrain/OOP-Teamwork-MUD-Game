namespace ForsakenLands.Items.Potion
{
    using System.Text;

    public class ManaPotion : Potion
    {
        private const int ManaRestored = 30;

        public ManaPotion(string name = null)
            : base(0, ManaRestored, name)
        {
        }

        public override string ToString()
        {
            StringBuilder potionString = new StringBuilder();
            potionString.Append(base.ToString());
            potionString.Append(" Restore Points " + ManaRestored);
            return potionString.ToString();
        }
    }
}