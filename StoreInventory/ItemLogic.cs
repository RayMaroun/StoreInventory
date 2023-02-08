using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory
{
    // Refactored: Logic-related methods extracted to a separate class
    public class ItemLogic
    {
        // Refactored: Method name changed to CheckStockStatus
        public void CheckStockStatus(Item item)
        {
            if (item.Stock == 0)
            {
                Console.WriteLine("Item is out of stock");
            }
            else
            {
                Console.WriteLine("Item is in stock");
            }
        }

        // Refactored: Method name changed to SetPrice
        public void SetPrice(Item item, decimal newPrice)
        {
            item.Price = newPrice;
        }
    }
}
