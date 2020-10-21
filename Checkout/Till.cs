using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Till
    {
        private Dictionary<char, int> _items;               // To store item name and quantity.
        private Dictionary<char, double> _unitPrices;       // To store item name and cost per item.
        
        // Constructor initialises both _items and _unitPrices with default values.
        public Till()
        {
            _items = new Dictionary<char, int>();
            _items.Add('A', 0);
            _items.Add('B', 0);
            _items.Add('C', 0);
            _items.Add('D', 0);

            _unitPrices = new Dictionary<char, double>();
            _unitPrices.Add('A', 50);
            _unitPrices.Add('B', 30);
            _unitPrices.Add('C', 20);
            _unitPrices.Add('D', 15);
        }

        //Function to calculate total cost of items with discount applied.
        public double Total() 
        { 
            double totalWithoutDiscount = 0;
            double totalDiscountForItem = 0;
            double totalWithDiscount = 0;
            double finalTotal = 0;

            foreach(var item in _items)
            {
                totalWithoutDiscount = totalCostForEachItemWithoutDiscount(item.Key);
                totalDiscountForItem = totalDiscountPerItemType(item.Key);            
                totalWithDiscount = totalWithoutDiscount - totalDiscountForItem;
                finalTotal += totalWithDiscount;
            }
             
           return finalTotal;
        }

        //Function to calculate total cost of items for each item type without discount.
        private double totalCostForEachItemWithoutDiscount(char name)
        {
            int quantity = _items[name];
            double unitPrice = _unitPrices[name];

            return quantity * unitPrice;
        }

        //Function to calculate total discount for each item type based current specials.
        private double totalDiscountPerItemType(char itemName)
        {
            double discount = 0;
            double totalDiscount = 0;

            if(itemName == 'A')         //Discount of 20 on purchase of every 3 item A
            {
                if(_items[itemName] >= 3)
                {
                    discount = 20;
                    totalDiscount = (_items[itemName] / 3) * discount;
                }
            }
            else if(itemName == 'B')         //Discount of 15 on purchase of every 2 item B
            {
                if(_items[itemName] >= 2)
                {
                    discount = 15;
                    totalDiscount = (_items[itemName] / 2) * discount;
                }
            }

            return totalDiscount;
        }

        //Function to scan each item in string of items and update the associated quantity value in _items.
        //It also alerts the user if string of items contains more than 6 units of item C.
        public void Scan(string items)
        {
            string itemsInUppercase = items.ToUpper();    

            foreach(var item in itemsInUppercase)
            {
                if(_items.ContainsKey(item) && _unitPrices.ContainsKey(item))
                {
                    if(_items[item] >= 0)
                    {
                        _items[item]++;    
                    }
                }

                //Implemenetation of limit of units of item C purchased.
                if(item == 'C')  
                {
                    //Once 6 units are scanned, alert user that any more units of the item will be removed.
                    if(_items[item] == 6)
                    { 
                        Console.WriteLine("You have reached the maximum permissible limit for item C. Any additional units of this item will be removed.");
                    }                    

                    //If number of units scanned exceeds 6, remove an item from the string by calling the Remove().
                    if(_items[item] > 6)
                    {
                        itemsInUppercase.Remove(itemsInUppercase.IndexOf(item));
                        _items[item]--; 
                    }
                }
            }
        }
    }
}