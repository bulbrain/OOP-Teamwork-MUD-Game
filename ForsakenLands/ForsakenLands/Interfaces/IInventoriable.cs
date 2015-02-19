using ForsakenLands.Items;
using System.Collections.Generic;

namespace ForsakenLands.Interfaces
{
    interface IInventoriable
    {
        List<Item> ItemInventory { get; set; }

        void AddItemToInventory(Item item);

        void RemoveItemFromInventory(Item item);
    }
}
