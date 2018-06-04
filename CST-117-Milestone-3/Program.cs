using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone_3
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            InventoryItem inventoryItem = new InventoryItem("Test", "Hello World", 1, 2.5M, 1.5M);
            manager.AddItem(inventoryItem);
            Console.WriteLine("Before");
            Console.WriteLine(manager);

            InventoryItem inventoryItem2 = new InventoryItem("Test", "Hello World2", 3, 2.5M, 1.5M);
            manager.AddItem(inventoryItem2);

            Console.WriteLine("After");
            Console.WriteLine(manager);
            Console.ReadKey();
        }
    }
}
