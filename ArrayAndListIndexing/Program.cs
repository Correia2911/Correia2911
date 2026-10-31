using System;
using System.Collections.Generic;

namespace ArrayAndListIndexing
{
    // Contains the code for the array and list indexing console application.
    internal class Program
    {
        // Main is the entry point: the program starts running here.
        private static void Main()
        {
            // Display a heading so the user knows what this program demonstrates.
            Console.WriteLine("Array and List Indexing");
            Console.WriteLine();

            // Create a one-dimensional string array with three example names.
            string[] names = { "Ada", "Grace", "Katherine" };

            // Ask for a valid name-array index; stop gracefully if input has ended.
            if (!TryReadIndex("string array", names.Length, out int nameIndex))
            {
                return;
            }

            // Display the string stored at the selected, validated array index.
            Console.WriteLine($"String at index {nameIndex}: {names[nameIndex]}");
            Console.WriteLine();

            // Create a one-dimensional integer array with three example scores.
            int[] scores = { 95, 88, 100 };

            // Ask for a valid integer-array index; stop gracefully if input has ended.
            if (!TryReadIndex("integer array", scores.Length, out int scoreIndex))
            {
                return;
            }

            // Display the integer stored at the selected, validated array index.
            Console.WriteLine($"Integer at index {scoreIndex}: {scores[scoreIndex]}");
            Console.WriteLine();

            // Create a List<string> containing three example colors.
            List<string> colors = new List<string> { "Blue", "Green", "Purple" };

            // Ask for a valid list index; stop gracefully if input has ended.
            if (!TryReadIndex("string list", colors.Count, out int colorIndex))
            {
                return;
            }

            // Display the string stored at the selected, validated list index.
            Console.WriteLine($"String at index {colorIndex}: {colors[colorIndex]}");
        }

        // Reads and validates an index for a collection with the supplied item count.
        private static bool TryReadIndex(string collectionName, int itemCount, out int index)
        {
            // Set a safe output value in case the collection contains no items.
            index = -1;

            // Avoid asking for an index when there are no valid positions to choose.
            if (itemCount <= 0)
            {
                Console.WriteLine($"The {collectionName} is empty, so it has no valid indexes.");
                return false;
            }

            // Keep asking until the user enters an index within the collection bounds.
            while (true)
            {
                // Show the valid zero-based index range in the prompt.
                Console.Write($"Enter an index for the {collectionName} (0-{itemCount - 1}): ");

                // Read the user's answer; null means the input stream has ended.
                string? input = Console.ReadLine();

                // Exit cleanly instead of looping if the console can no longer provide input.
                if (input is null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No input was received. The program will now close.");
                    return false;
                }

                // TryParse checks that the answer is a whole number without throwing an exception.
                if (!int.TryParse(input, out index))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    continue;
                }

                // Reject negative indexes and indexes at or beyond the collection's item count.
                if (index < 0 || index >= itemCount)
                {
                    Console.WriteLine(
                        $"Index {index} does not exist. Choose an index from 0 to {itemCount - 1}.");
                    continue;
                }

                // The index is now safe to use, so return success to the calling code.
                return true;
            }
        }
    }
}
