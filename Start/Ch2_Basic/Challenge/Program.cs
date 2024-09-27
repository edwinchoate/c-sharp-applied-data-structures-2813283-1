// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge: Chapter 2

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Test Code
            ShoppingList list = new();
            list.AddItem("Milk", 2.25, 1);
            list.AddItem("Sugar", 1.75, 2);
            list.AddItem("Bread", 3.25, 1);
            list.AddItem("Butter", 4.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();

            list.RemoveItem("Bread");
            list.RemoveItem("Sugar");
            list.AddItem("Cookies", 0.50, 4);
            list.AddItem("Oranges", 0.65, 5);
            list.AddItem("Chicken", 8.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();
        }
    }

    public class ShoppingList
    {

        private List<ShoppingItem> _shoppingList = new();

        public void AddItem(string ItemName, double Price, int Quantity)
        {
            if (!_shoppingList.Exists(item => item.Name == ItemName && item.Price == Price)) 
                _shoppingList.Add(new ShoppingItem(ItemName, Price, Quantity));
            else 
            {
                int index = _shoppingList.IndexOf(_shoppingList.Find(item => item.Name == ItemName && item.Price == Price));
                _shoppingList[index].Quantity += Quantity;
            }
        }

        public void RemoveItem(string ItemName)
        {
            ShoppingItem item = _shoppingList.Find(item => item.Name == ItemName);
            if (item != null)
            {
                if (item.Quantity == 1) 
                    _shoppingList.Remove(item);
                else
                    _shoppingList[_shoppingList.IndexOf(item)].Quantity--;
            } 
        }

        public int GetCount()
        {
            int count = 0;
            _shoppingList.ForEach(item => count += item.Quantity);
            return count;
        }

        public void PrintList()
        {
            foreach (var item in _shoppingList)
            {
                Console.WriteLine($"Item: {item.Name,10}, Price: {item.Price:C}, Quantity: {item.Quantity}");
            }
        }
    }

    public class ShoppingItem 
    {

        public ShoppingItem (string name, double price, int quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
