namespace ForsakenLands.Items.Potion
{
    class ManaPotion : Potion
    {
        const int ManaRestored = 10;

        public ManaPotion(string name = null)
            : base(0, ManaRestored, name)
        {
        }
    }
}