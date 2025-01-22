using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission3
{
    internal class FoodItem
    {
        int[] foodItems = [];


        public void FoodItems(int item)
        {  
            
            if (item == 1)
            {
                
                Console.WriteLine("(Please enter the name of food item you would like to add:)");
                string itemName = Console.ReadLine();

                Console.WriteLine("(Please enter the category of food item:)");
                string itemCategory = Console.ReadLine();

                Console.WriteLine("(Please enter the quantity of this food item:)");
                int numAdd = int.Parse(Console.ReadLine());
            }
            
            
        }

    }
}
