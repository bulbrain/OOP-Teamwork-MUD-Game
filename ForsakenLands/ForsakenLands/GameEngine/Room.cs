namespace ForsakenLands.GameEngine
{
    using System.Collections.Generic;

    using ForsakenLands.Characters;
    using Items;

    public class Room : GameObject
    {
        private static List<int> roomNumbers = new List<int>();
        private int roomNumber;

        public Room()
            : base()
        {
            this.RoomNumber = 0;
        }

        public int RoomNumber
        {
            get
            {
                return this.roomNumber;
            }
            set
            {
                this.roomNumber = roomNumbers.Count;
                roomNumbers.Add(this.roomNumber);
            }
        }

        public Item Item { get; set; }

        public Monster Monster { get; set; }
    }
}