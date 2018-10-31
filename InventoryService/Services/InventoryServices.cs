using System.Collections.Generic;
using InventoryService.Models;

namespace InventoryService.Services
{
    public class InventoryServices : IInventoryServices
    {
        // Store inventory items
        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);

            return items;
        }

        public Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return _inventoryItems; // Return dictionary
        }
    }
}
