using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                                "George Carlin", "Lenny Bruce",
                                "Eddie Murphy", "Louie Anderson"};
            // TODO: Create the list
            List<string> list = new List<string>(10);  // 10 is Capacity

            // TODO: Add some elements to the list from an existing array
            list.AddRange(comedians);

            // TODO: Add individual items
            list.Add("Steve Martin");

            // TODO: Examine the Count and Capacity
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            // TODO: Enumerate the items in the list with a foreach loop
            PrintList(list);

            // TODO: Access any item by its index
            Console.WriteLine(list[5]);

            // TODO: Remove items from the list
            list.RemoveAt(5);

            Console.WriteLine();

            // TODO: Sort the list content
            list.Sort();
            PrintList(list);

            // ** Searching List Content **/

            Console.WriteLine();

            // TODO: Determine if a list contains a given item
            Console.WriteLine("Is Steve Martin in the list? {0}", list.Contains("Steve Martin"));

            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list
            Console.WriteLine("Is there a comedian whose name starts with 'G'? {0}", list.Exists(x => x.StartsWith("G")));

            // TODO: Use the Find function to search through items
            Console.WriteLine("A comedian whose name starts with 'R' {0}", list.Find(x => x.StartsWith("R")));

            // TODO: The FindAll function can find multiple items
            Console.WriteLine("Comedians whose names start with 'L':");
            List<string> l = list.FindAll(x => x.StartsWith("L"));
            PrintList(l);

            // TODO: Use TrueForAll to see if a given condition is true for all elements
            Console.WriteLine(list.TrueForAll(x => x.Length > 3));
        }

        static void PrintList(List<string> theList)
        {
            foreach (string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
