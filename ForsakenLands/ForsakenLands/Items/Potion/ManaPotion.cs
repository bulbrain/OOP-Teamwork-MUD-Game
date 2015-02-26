namespace ForsakenLands.Items.Potion
{
    class ManaPotion : Potion
    {
        const int ManaRestored = 10;

        public ManaPotion(string name, int healthPoints, int manaPoints)
            : base(name, 0, ManaRestored)
        {
        }
    }
}