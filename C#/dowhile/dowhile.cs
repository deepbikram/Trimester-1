//c# program to demonstrate do while loop with a project of resturant management system that can add items, search items, display items, delete items and quit the program.
class Program
{
    static void Main()
    {
        int choose;
        var items = new List<string>();
        do
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("ABC Restaurant Pvt. Ltd.");
            System.Console.WriteLine(" Butwal, Nepal");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Search Item");
            Console.WriteLine("3. Display the Menu");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Quit");
            Console.WriteLine("------------------------------");
            Console.Write("Select an option (1-5): ");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Enter item name: ");
                    string itemName = Console.ReadLine();
                    items.Add(itemName);
                    Console.WriteLine("Item added.");
                    break;
                case 2:
                    Console.WriteLine("Enter item name to search: ");
                    string searchItem = Console.ReadLine();
                    if (items.Contains(searchItem))
                    {
                        Console.WriteLine($"Item found: {searchItem}");
                    }
                    else
                    {
                        Console.WriteLine("Item not found.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Menu:");
                    if (items.Count == 0)
                    {
                        Console.WriteLine("No items in the menu.");
                    }
                    else
                    {
                        foreach (var item in items)
                        {
                            Console.WriteLine($"Item: {item}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter item name to delete: ");
                    string deleteItem = Console.ReadLine();
                    if (items.Remove(deleteItem))
                    {
                        Console.WriteLine("Item deleted.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Choose a valid option from the menu.");
                    break;
            }
        } while (choose != 5);
    }
}