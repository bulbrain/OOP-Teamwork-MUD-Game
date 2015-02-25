namespace ForsakenLands.Items.Armor
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Armor : Item, IEquippable
    {
        // attributes should be added
        public Armor(int id, string name, bool isEquipped = false)
            : base(id, name)
        {
            this.IsEquipped = isEquipped;
        }

        public bool IsEquipped { get; set; }
    }
}