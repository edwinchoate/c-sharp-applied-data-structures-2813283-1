// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        const string Openers = "([{";
        const string Closers = ")]}";

        static void Main(string[] args)
        {
            string[] TestStatements = {
                "print('Hello World')",
                "if a(b[x]) == b(a[x])",
                "function t(x) { print('t(x)')}",
                "print 'Hello World')",
                "f(x) = g(x[2)",
                "{{[[(())]]}",
                "}"
            };

            foreach (string TestStr in TestStatements) {
                bool Result = CheckBalanced(TestStr);

                Console.WriteLine($"Statement '{TestStr}' {(Result ? "is" : "is not")} balanced.");
            }
        }

        // TODO: Implement the CheckBalanced method
        static bool CheckBalanced(string TestStatement) {
            // TODO: Put your logic here

            string search = "";
            
            foreach (char c in TestStatement) 
            {
                if (Openers.IndexOf(c) != -1 || Closers.IndexOf(c) != -1)
                    search += c;
            }

            if (search.Length % 2 != 0) return false;
            if (search.Length == 0) return true; 

            Stack<char> stack = new();

            foreach (char c in search) 
            {
                if (Openers.IndexOf(c) != -1)
                {
                    stack.Push(c);
                }
                else // Closers
                {
                    char top;
                    bool canPop = stack.TryPop(out top);

                    if (canPop)
                    {
                        switch (c) 
                        {
                            case ')':
                                if (top != '(') return false;
                                break;
                            case ']':
                                if (top != '[') return false;
                                break;
                            case '}':
                                if (top != '{') return false;
                                break;
                            default:
                                throw new NotImplementedException($"Unhandled char '{c}' in CheckedBalanced method.");
                        }
                    }
                    else 
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
