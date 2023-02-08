using StoreInventory;

public class Program
{
    static void Main(string[] args)
    {
        Item item = new Item(1, "Shirt", 20, 10);
        ItemLogic itemLogic = new ItemLogic();
        ItemDisplay itemDisplay = new ItemDisplay();

        itemLogic.CheckStockStatus(item);
        itemLogic.SetPrice(item, 25);
        itemDisplay.ShowItemInformation(item);

        Console.ReadLine();
    }
}