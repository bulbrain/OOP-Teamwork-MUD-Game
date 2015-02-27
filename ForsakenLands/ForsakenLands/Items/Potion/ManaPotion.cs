namespace ForsakenLands.Items.Potion
{
    class ManaPotion : Potion
    {
        const int ManaRestored = 30;

        public ManaPotion(string name = null)
            : base(0, ManaRestored, name)
        {
        }
    }
}