using System;

namespace Basic 
{
    class Program
    {

        static void Main (string[] args) 
        {
            // Example file for C# Applied Data Structures by Joe Marini
            // Basic data structures

            // TODO: strings are collections of characters, and are immutable
            string s1 = "Hello world";
            char[] c1 = new char[] {'H', 'e', 'l', 'l', 'o'};
            string s2 = new string(c1);

            s1 += s2;
            Console.WriteLine(s1);

            // char[] c1 = new char[] {'F','i','z','z','y',' ','B','u','z','z'};
            string s3 = "hello ";
            string s4 = s3;

            // TODO: Be careful with string references
            s3 += "world";
            Console.WriteLine(s4);

            Console.WriteLine();

            // TODO: Arrays are contiguous storage of the same variable type
            int[] nums = new int[5];
            int[] nums2 = {1, 2, 3, 4, 5};
            Console.WriteLine(nums2.GetType());

            // TODO: implicitly typed array
            var a = new[] {"ab", "cd", "efg"};
            Console.WriteLine(a.GetType());

            // TODO: multiple type array
            object[] b = new object[] {"abc", 'd', 1, false};
            Console.WriteLine(b.GetType());

            Console.WriteLine();

            // TODO: Tuples are lightweight data structures that group multiple data elements
            (int, string) t1 = (5, "hi");
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);

            Console.WriteLine();

            (bool b, string s, int i) t2 = (true, "yo", 7);
            Console.WriteLine(t2.b);
            Console.WriteLine(t2.s);
            Console.WriteLine(t2.i);

            Console.WriteLine();

            var t3 = (word: "hello", nums: 12, b: true);
            Console.WriteLine(t3.word);
            Console.WriteLine(t3.nums);
            Console.WriteLine(t3.b);
        }

    }
}