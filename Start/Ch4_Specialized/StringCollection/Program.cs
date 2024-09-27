using System;
using System.Collections.Specialized;

namespace StrCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // define an initial set of strings
            string[] colors = {"red","orange","yellow","green","blue","violet"};

            // TODO: create the string collection
            StringCollection collection = new StringCollection();

            // TODO: Add an existing set of strings
            collection.AddRange(colors);

            // TODO: add some individual items
            collection.Add("black");
            collection.Insert(0, "white");

            // TODO: Use the Count property to see how many there are
            Console.WriteLine(collection.Count);

            // TODO: Iterate over each string in the collection
            foreach (string s in collection) 
            {
                Console.WriteLine(s);
            }

            // TODO: Access an individual item
            string color = collection[3];

            // TODO: Search for a string
            Console.WriteLine("Contains blue? {0}", collection.Contains("blue"));
            Console.WriteLine("Index of 'green'? {0}", collection.IndexOf("green"));

            // TODO: Clear all the contents
            collection.Clear();
            Console.WriteLine(collection.Count);
        }
    }
}
