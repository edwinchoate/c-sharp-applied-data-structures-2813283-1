using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty Queue that holds strings
            Queue<string> queue = new Queue<string>();

            // Add items to the end of the queue
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");
            queue.Enqueue("five");

            // use the count property to see how many items there are
            Console.WriteLine(queue.Count);

            // Queues can be iterated without changing the structure
            PrintQueue(queue);

            // peek at the front of the queue
            Console.WriteLine(queue.Peek());

            // remove items from the front of the queue
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            PrintQueue(queue);

            // see if the queue contains an item
            Console.WriteLine(queue.Contains("two"));

            // Remove all the items
            queue.Clear();
            Console.WriteLine(queue.Count);
        }

        static void PrintQueue (Queue<string> queue) 
        {
            foreach (string s in queue) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
