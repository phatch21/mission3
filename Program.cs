using System;
using System.Collections.Generic;

using mission3;

// Payton Hatch
// Group 4-6

// program class
class Program
{
    static List<FoodItem> foodItems = new List<FoodItem>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nFood Bank Inventory System");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddFoodItem();
                    break;
                case "2":
                    DeleteFoodItem();
                    break;
                case "3":
                    PrintFoodItems();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddFoodItem()
    {
        Console.Write("Enter food name: ");
        string name = Console.ReadLine();

        Console.Write("Enter category (e.g., Canned Goods, Dairy, Produce): ");
        string category = Console.ReadLine();

        int quantity;
        do
        {
            Console.Write("Enter quantity: ");
        } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0);

        DateTime expirationDate;
        do
        {
            Console.Write("Enter expiration date (yyyy-mm-dd): ");
        } while (!DateTime.TryParse(Console.ReadLine(), out expirationDate));

        foodItems.Add(new FoodItem(name, category, quantity, expirationDate));
        Console.WriteLine("Food item added successfully.");
    }

    static void DeleteFoodItem()
    {
        if (foodItems.Count == 0)
        {
            Console.WriteLine("No food items to delete.");
            return;
        }

        Console.WriteLine("\nCurrent Food Items:");
        for (int i = 0; i < foodItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {foodItems[i]}");
        }

        int index;
        do
        {
            Console.Write("Enter the number of the food item to delete: ");
        } while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > foodItems.Count);

        foodItems.RemoveAt(index - 1);
        Console.WriteLine("Food item deleted successfully.");
    }

    static void PrintFoodItems()
    {
        if (foodItems.Count == 0)
        {
            Console.WriteLine("No food items available.");
            return;
        }

        Console.WriteLine("\nCurrent Food Items:");
        foreach (var item in foodItems)
        {
            Console.WriteLine(item);
        }
    }
}

