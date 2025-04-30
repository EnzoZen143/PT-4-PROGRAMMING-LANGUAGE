using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class Program
    {
        static List<string> inventory = new List<string>();
        static void Main(string[] args)
        {
            bool running = true;
            while (running == true)
            {
                Console.WriteLine("=== SIMPLE INVENTORY SYSTEM===");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. Exit Item");
                Console.WriteLine("Select an Option"); 
                string input = Console.ReadLine(); 

                switch (input) 
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== VIEW INVENTORY ===");
                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Inventory is empty.");
                        }
                        else
                        {
                            for (int i = 0; i < inventory.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {inventory[i]}");
                            }
                        }
                        Console.WriteLine("Press Enter to return...");
                        Console.ReadLine();
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== REMOVE ITEM ===");
                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Inventory is empty.");
                        }
                        else
                        {
                            for (int i = 0; i < inventory.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {inventory[i]}");
                            }

                            Console.WriteLine("Enter the number of the item to remove:");
                            string inputRemove = Console.ReadLine();
                            int index;
                            if (int.TryParse(inputRemove, out index))
                            {
                                if (index >= 1 && index <= inventory.Count)
                                {
                                    string removedItem = inventory[index - 1];
                                    inventory.RemoveAt(index - 1);
                                    Console.WriteLine($"'{removedItem}' removed from inventory.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid item number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number.");
                            }
                        }
                        Console.WriteLine("Press Enter to return...");
                        Console.ReadLine();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        break;
                }
            }

            static void AddItem()
            {
                Console.Clear();
                Console.WriteLine("Enter item name to add"); 
                string item = Console.ReadLine(); 
                inventory.Add(item); 
                Console.WriteLine($"'{item}'added to inventory"); 
                Console.WriteLine("Press Enter to return...");
                Console.ReadLine();
            }
        }
    }
}