namespace ForsakenLands.Items.Weapon
{
    using ForsakenLands.Interfaces;
    using System;

    public abstract class Weapon : Item, IEquippable
    {
        // attributes should be added
        public Weapon(int id, string name, bool isEquipped = false)
            : base(id, name)
        {
            this.IsEquipped = isEquipped;
        }

        public bool IsEquipped { get; set; }
    }
}