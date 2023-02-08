using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Refactored: Input validation added to the constructor
        public Item(int id, string name, decimal price, int stock)
        {
            if (!ValidateInput(id, name, price, stock))
            {
                throw new ArgumentException("Invalid input values");
            }

            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        // Refactored: Method for input validation extracted to its own method
        private bool ValidateInput(int id, string name, decimal price, int stock)
        {
            if (id <= 0 || string.IsNullOrEmpty(name) || price <= 0 || stock < 0)
            {
                return false;
            }

            return true;
        }
    }
}
