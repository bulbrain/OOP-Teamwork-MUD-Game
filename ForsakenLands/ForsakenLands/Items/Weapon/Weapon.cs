namespace ForsakenLands.Items.Weapon
{
    using ForsakenLands.Interfaces;

    public abstract class Weapon : Item, IEquippable
    {
        // attributes should be added
        public Weapon(string name = null)
            : base(name, 10, 0, 0, 0)
        {
            this.IsEquipped = false;
        }

        public bool IsEquipped { get; set; }
    }
}