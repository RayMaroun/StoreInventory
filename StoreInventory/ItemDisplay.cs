using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory
{
    // Refactored: Display-related methods extracted to a separate class
    public class ItemDisplay
    {
        // Refactored: Method name changed to ShowItemInformation and used String Interpolation
        public void ShowItemInformation(Item item)
        {
            Console.WriteLine("Item Information");
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Price: {item.Price}");
            Console.WriteLine($"Stock: {item.Stock}");
        }
    }
}
