using System;
using System.Collections;
using System.Collections.Specialized;

namespace HybridDictExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create the hybrid dictionary
            HybridDictionary dict = new HybridDictionary(20, false);
                // param1 is initial capacity 
                // param2 is whether or not the dictionary is case insensitive

            // TODO: Add some initial items
            dict.Add("item1", "value 1");
            dict.Add("item2", "value 2");
            dict.Add("item3", "value 3");
            dict.Add("item4", "value 4");

            Console.WriteLine(dict.Count);

            // TODO: Contains
            Console.WriteLine("Contains 'item2'? {0}", dict.Contains("item2"));

            // TODO: Remove
            dict.Remove("item2");
            
            foreach (DictionaryEntry entry in dict) 
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }

            // TODO: Clear
            dict.Clear();
            
            // TODO: Print the number of items
            Console.WriteLine(dict.Count);
        }
    }
}
