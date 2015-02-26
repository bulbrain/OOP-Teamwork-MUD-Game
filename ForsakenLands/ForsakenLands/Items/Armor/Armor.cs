namespace ForsakenLands.Items.Armor
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Armor : Item, IEquippable
    {
        // attributes should be added
        public Armor(string name, bool isEquipped = false)
            : base(name, 10, 0, 0, 0)
        {
            this.IsEquipped = isEquipped;
        }

        public bool IsEquipped { get; set; }
    }
}