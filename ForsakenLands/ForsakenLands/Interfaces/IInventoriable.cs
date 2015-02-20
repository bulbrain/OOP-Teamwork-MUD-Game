namespace ForsakenLands.Interfaces
{
    using System.Collections.Generic;

    using ForsakenLands.Items;

    public interface IInventoriable
    {
        List<Item> ItemInventory { get; set; }

        void AddItemToInventory(Item item);

        void RemoveItemFromInventory(Item item);
    }
}
