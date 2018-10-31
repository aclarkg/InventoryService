using System.Collections.Generic;
using InventoryService.Models;

namespace InventoryService.Services
{
    public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);

       Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
