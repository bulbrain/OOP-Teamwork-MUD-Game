namespace ForsakenLands.Items
{
    using ForsakenLands;

    public abstract class Item : GameObject
    {
        public Item(string name)
            : base()
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}