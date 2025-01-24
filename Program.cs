using System;
using System.Collections.Generic;

using mission3;

// Payton Hatch
// Group 4-6

// program class
class Program
{   
    // list to store food items
    static List<FoodItem> foodItems = new List<FoodItem>();

    // constructor class
    static void Main(string[] args)
    {   
        // variable to determine when the program should be running
        bool running = true;

        // while loop listening for the desired selection of the user
        while (running)
        {
            // menu items
            Console.WriteLine("\nFood Bank Inventory System");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            // menu item chosen
            string choice = Console.ReadLine();

            // switch case statement directing the choice to the corresponding function
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

    // method adding a new food item
    static void AddFoodItem()
    {   
        // prompts to user for food info
        Console.Write("Enter food name: ");
        string name = Console.ReadLine();

        Console.Write("Enter category (e.g., Canned Goods, Dairy, Produce): ");
        string category = Console.ReadLine();

        int quantity;
        do
        {
            Console.Write("Enter quantity: ");
        } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0); // checks for valid quantity

        DateTime expirationDate;
        do
        {
            Console.Write("Enter expiration date (yyyy-mm-dd): ");
        } while (!DateTime.TryParse(Console.ReadLine(), out expirationDate)); // checks for valid date

        foodItems.Add(new FoodItem(name, category, quantity, expirationDate)); 
        Console.WriteLine("Food item added successfully."); 
    }

    // method for deleting food items
    static void DeleteFoodItem()
    {   
        // default when there is nothing in the list
        if (foodItems.Count == 0)
        {
            Console.WriteLine("No food items to delete.");
            return;
        }

        // list of current food items
        Console.WriteLine("\nCurrent Food Items:");
        for (int i = 0; i < foodItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {foodItems[i]}");
        }

        int index;
        do
        {
            Console.Write("Enter the number of the food item to delete: ");
        } while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > foodItems.Count); // confirms valid number for deletion

        foodItems.RemoveAt(index - 1);
        Console.WriteLine("Food item deleted successfully.");
    }

    // method that prints out all current food items
    static void PrintFoodItems()
    {   
        // default response when there are no items
        if (foodItems.Count == 0)
        {
            Console.WriteLine("No food items available.");
            return;
        }

        // for loop printing each food item
        Console.WriteLine("\nCurrent Food Items:");
        foreach (var item in foodItems)
        {
            Console.WriteLine(item);
        }
    }
}

