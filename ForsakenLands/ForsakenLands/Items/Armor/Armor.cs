namespace ForsakenLands.Items.Armor
{
    using ForsakenLands.Interfaces;

    public abstract class Armor : Item, IEquippable
    {
        // attributes should be added
        public Armor(string name = null)
            : base(name, 0, 10, 0, 0)
        {
            this.IsEquipped = false;
        }

        public bool IsEquipped { get; set; }
    }
}