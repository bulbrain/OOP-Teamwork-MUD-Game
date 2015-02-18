namespace ForsakenLands.Items
{
    using ForsakenLands;

    public abstract class Item : GameObject
    {
        private string name;

        public Item(int id, string name)
            : base(id)
        {
        }

        public string Name { get; set; }
    }
}