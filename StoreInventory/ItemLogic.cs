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
        // Refactored: Method name changed to CheckStockStatus and used ternary operator
        public void CheckStockStatus(Item item)
        {
            string stockStatus = (item.Stock == 0) ? "out of" : "in";
            Console.WriteLine($"Item is {stockStatus} stock");
        }

        // Refactored: Method name changed to SetPrice
        public void SetPrice(Item item, decimal newPrice)
        {
            item.Price = newPrice;
        }
    }
}
