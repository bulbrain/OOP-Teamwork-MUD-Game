namespace ForsakenLands.Items.Potion
{
    class ManaPotion : Potion
    {
        const int ManaRestored = 10;

        public ManaPotion(int id, string name, int healthPoints, int manaPoints)
            : base(id, name, 0, ManaRestored)
        {
        }
    }
}