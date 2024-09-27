using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an empty stack
            Stack<string> stack = new Stack<string>();

            // TODO: The Push function pushes new elements onto the stack
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");

            // TODO: The Count property indicates how many elements are on the stack
            Console.WriteLine(stack.Count);

            // TODO: Stacks can be enumerated in place without changing the content
            PrintStack(stack);

            // TODO: The Peek function examines the current top element but does not remove it
            Console.WriteLine(stack.Peek());

            PrintStack(stack);

            // TODO: The Pop function removes an element from the top
            string top = stack.Pop();

            Console.WriteLine(stack.Count);
            PrintStack(stack);

            Console.WriteLine(top);

            // TODO: Search for an element using Contains
            Console.WriteLine("Contains 'three'? {0}", stack.Contains("three"));

        }

        static void PrintStack (Stack<string> stack) 
        {
            foreach (string s in stack) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
