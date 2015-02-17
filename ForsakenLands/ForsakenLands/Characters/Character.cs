namespace ForsakenLands.Characters
{
    using ForsakenLands;
    using ForsakenLands.Items;
    using System.Collections.Generic;

    public abstract class Character : GameObject
    {
        private int attackPoints;
        private int defencePoints;
        private int healthPoints;
        private int accuracy;
        private int evasion;
        private int range;
        private List<Item> itemInventory;

        public Character(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int accuracy,
            int evasion,
            int range,
            List<Item> itemInventory)
            : base(id)
        {

        }
    }
}
