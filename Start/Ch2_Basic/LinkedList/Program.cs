using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings that represent song names
            string[] songs = {"Shout", "Satisfaction", "Help!",
                            "Stairway to Heaven", "Come Sail Away",
                            "All Night Long", "Right Here Right Now"};

            // TODO: Create a LinkedList that holds strings
            LinkedList<string> songList = new LinkedList<string>(songs);

            // TODO: Items can be added at the front or back of the list
            songList.AddFirst("Africa");
            songList.AddLast("Free Bird");

            // TODO: Like other collections, a LinkedList can be iterated
            foreach (string song in songList) 
            {
                Console.WriteLine(song);
            }

            Console.WriteLine();

            // TODO: First and Last properties return LinkedListNodes
            LinkedListNode<string> firstSong = songList.First;
            LinkedListNode<string> lastSong = songList.Last;

            Console.WriteLine(firstSong.Value);
            Console.WriteLine(lastSong.Value);

            // TODO: Items can be added or removed relative to an existing item
            songList.AddAfter(firstSong, "Blackbird");

            // TODO: Search for items in the list with Contains and Find
            Console.WriteLine("Is 'Help!' in the list? {0}", songList.Contains("Help!"));
            Console.WriteLine("What's the song before 'Help!'? {0}", songList.Find("Help!").Previous.Value);

            // TODO: The list can then be traversed with those properties
            Console.WriteLine(firstSong.Next.Next.Value);
            Console.WriteLine(lastSong.Previous.Previous.Value);
        }
    }
}
