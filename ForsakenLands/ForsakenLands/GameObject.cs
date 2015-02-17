namespace ForsakenLands
{

    public abstract class GameObject
    {
        private int id;

        public GameObject(int id)
        {
            this.Id = id;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                this.id = value;
            }
        }
    }
}
