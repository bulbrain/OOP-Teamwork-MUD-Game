namespace ForsakenLands.Items
{
    using ForsakenLands;

    public abstract class Item : GameObject
    {
        public Item(int id, string name)
            : base(id)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}