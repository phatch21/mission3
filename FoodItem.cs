﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Payton Hatch
// Group 4-6

namespace mission3
{
    public class FoodItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        public FoodItem(string name, string category, int quantity, DateTime expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Quantity: {Quantity}, Expiration Date: {ExpirationDate.ToShortDateString()}";
        }
    }
}
