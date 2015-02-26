namespace ForsakenLands.Items.Potion
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Potion : Item, IConsumable
    {
        public Potion(string name, int healthPoints, int manaPoints)
            : base(name, 0, 0, healthPoints, manaPoints)
        {
        }
    }
}
