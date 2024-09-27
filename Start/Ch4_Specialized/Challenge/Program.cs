// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Challenge
{
    class Program
    {
        static void PrintStringStats(string TheString)
        {
            // Split the string on space character boundary
            string[] wordArray = TheString.Split(' ');

            // TODO: Count the total number of words using a StringCollection
            StringCollection collection = new StringCollection();
            collection.AddRange(wordArray);

            Console.WriteLine("Word Count: {0}", collection.Count);
            
            // TODO: Find the longest word
            // TODO: Build the word count data
            string longestWord = "";
            Dictionary<string, int> uniqueWords = new();

            foreach (string w in wordArray)
            {
                string word = w.ToLower();

                if (word.Length > longestWord.Length) 
                    longestWord = word;

                if (!uniqueWords.ContainsKey(word))
                {
                    uniqueWords.Add(word, 1);
                }
                else 
                {
                    uniqueWords[word]++;
                }
            }

            Console.WriteLine("Longest word: {0}", longestWord);

            // TODO: Print out the word count data
            Console.WriteLine("----------------------");

            foreach (string word in uniqueWords.Keys) 
            {
                Console.WriteLine("Word: {0}, Count: {1}", word, uniqueWords[word]);
            }
        }

        static void Main(string[] args)
        {
            string[] GettysburgAddress = {
                "Four score and seven years ago our",
                "fathers brought forth on this continent",
                "a new nation conceived in Liberty",
                "and dedicated to the proposition",
                "that all men are created equal",
                "Now we are engaged in a great civil war",
                "testing whether that nation",
                "or any nation so conceived and so dedicated",
                "can long endure",
                "We are met on a great battlefield of that war",
                "We have come to dedicate a portion of that field",
                "as a final resting place for those who",
                "here gave their lives that that nation might live",
                "It is altogether fitting",
                "and proper that we should do this"
            };

            // TODO: Convert the string array to a single string and call PrintStringStats
            string TheText = "";

            StringBuilder sb = new StringBuilder();
            sb.AppendJoin(" ", GettysburgAddress);

            TheText = sb.ToString().ToLower().Trim();

            PrintStringStats(TheText);
        }
    }
}