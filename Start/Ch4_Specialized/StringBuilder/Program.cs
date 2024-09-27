// Example file for C# Applied Data Structures by Joe Marini
// Using StringBuilder

using System;
using System.Text;

public sealed class App
{
    static void Main()
    {
        // TODO: Create a StringBuilder that expects to hold 50 characters.
        // Initialize the StringBuilder with "ABC".
        StringBuilder sb = new StringBuilder("ABC", 50);

        // TODO: Append three characters (D, E, and F) to the end of the StringBuilder.
        sb.Append(new char[] {'D', 'E', 'F'});

        // TODO: Append a format string to the end of the StringBuilder.
        sb.AppendFormat("GHI{0}{1}", 'J', 'K');

        Console.WriteLine(sb);

        // TODO: Display the number of characters in the StringBuilder and its string.
        Console.WriteLine(sb.Length);

        // TODO: Use AppendJoin to add an array of strings with a separator character
        string[] letters = new string[] {"L", "m", "N", "O", "P"};
        sb.AppendJoin('-', letters);
        Console.WriteLine(sb);

        // TODO: Insert a string at the beginning of the StringBuilder.
        sb.Insert(0, "Alphabet: ");

        // TODO: Replace all lowercase k's with uppercase K's.
        sb.Replace("m", "M");

        // TODO: Display the number of characters in the StringBuilder and its string.
        Console.WriteLine(sb.Length);
        Console.WriteLine(sb);
    }
}
