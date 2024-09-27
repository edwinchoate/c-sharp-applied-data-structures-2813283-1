using System;
using System.Collections;
using System.Collections.Specialized;

namespace OrderedDictExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new OrderedDictionary object
            OrderedDictionary dict = new OrderedDictionary();

            // TODO: Add some keys and values in a particular order
            dict.Add("item1", "value 1");
            dict.Add("item2", "value 2");
            dict.Add("item3", "value 3");
            dict.Add("item4", "value 4");

            // TODO: Print the contents of the Dictionary
            PrintDictionary(dict);

            // TODO: Remove an existing item and add a new one
            dict.Remove("item3");

            dict.Add("item5", "value 5");

            // TODO: Modify the value of an item in the dict
            dict["item2"] = "new value 2";

            // TODO: Add one final new item
            dict.Add("item6", "value 6");

            PrintDictionary(dict);
        }

        static void PrintDictionary(OrderedDictionary theDict)
        {
            foreach (DictionaryEntry entry in theDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("---------------");
        }
    }
}
