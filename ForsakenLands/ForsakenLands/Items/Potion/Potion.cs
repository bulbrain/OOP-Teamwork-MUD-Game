namespace ForsakenLands.Items.Potion
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Potion : Item, IConsumable
    {
        public Potion(int healthPoints, int manaPoints, string name = null)
            : base(name, 0, 0, healthPoints, manaPoints)
        {
        }
    }
}
