namespace ForsakenLands
{
    public abstract class GameObject
    {
        public GameObject(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }
    }
}
