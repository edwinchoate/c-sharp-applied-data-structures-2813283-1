using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries map keys to values. Keys must be unique
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            fileTypes.Add(".bmp", "Bitmap");
            fileTypes.Add(".txt", "Plain Text");
            fileTypes.Add(".html", "HTML Document");
            fileTypes.Add(".jpg", "JPG Image");
            fileTypes.Add(".png", "PNG Image");

            // use the Count property to see how many items there are
            Console.WriteLine(fileTypes.Count);

            // Trying to add an existing key will throw an exception
            // fileTypes.Add(".txt", "Just plain text");

            // The TryAdd function makes it convenient to see if there's a duplicate
            Console.WriteLine(fileTypes.TryAdd(".txt", "Just a text file"));
            Console.WriteLine(fileTypes.Count);

            Console.WriteLine(fileTypes.TryAdd(".webp", "WebP Image"));
            Console.WriteLine(fileTypes.Count);

            // Dictionaries are also like associative arrays
            Console.WriteLine(fileTypes[".html"]);

            // This way, setting an existing key just overwrites the value
            fileTypes[".html"] = "Web Page";
            Console.WriteLine(fileTypes[".html"]);

            // See if the Dictionary contains an key or a value
            Console.WriteLine("Contains key '.txt'? {0}", fileTypes.ContainsKey(".txt"));
            Console.WriteLine("Contains value 'Bitmap'? {0}", fileTypes.ContainsValue("Bitmap"));

            // Remove items
            fileTypes.Remove(".txt");
            Console.WriteLine("Contains key '.txt'? {0}", fileTypes.ContainsKey(".txt"));
        }
    }
}
