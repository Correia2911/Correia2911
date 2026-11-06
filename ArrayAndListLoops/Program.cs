using System; // Provides Console for reading input and writing output.
using System.Collections.Generic; // Provides List<T> and HashSet<T> collections.

namespace ArrayAndListLoops // Groups the assignment code under a descriptive namespace.
{
    internal class Program // Defines the class that contains the console application.
    {
        private static void Main() // The application starts running in this method.
        {
            // =====================================================
            // PART 1
            // =====================================================

            // Create a one-dimensional string array with initial text in each element.
            string[] messages = { "First item: ", "Second item: ", "Third item: " };

            // Ask the user for the text that will be appended to every array element.
            Console.Write("Enter some text to append to each array item: ");

            // Read the user's line; use an empty string if input has ended.
            string textToAppend = Console.ReadLine() ?? string.Empty;

            // Visit every array position and add the user's text to its current value.
            for (int index = 0; index < messages.Length; index++)
            {
                // The += operator joins the existing element text with the user's text.
                messages[index] += textToAppend;
            }

            // Explain that the following output shows the updated array values.
            Console.WriteLine();
            Console.WriteLine("Updated array elements:");

            // Visit the array again so every updated element can be displayed.
            for (int index = 0; index < messages.Length; index++)
            {
                // Display both the zero-based position and the updated string.
                Console.WriteLine($"Index {index}: {messages[index]}");
            }

            // Add a blank line to separate the output of this assignment part.
            Console.WriteLine();

            // =====================================================
            // PART 2
            // =====================================================

            // The following infinite loop is an example in comments only; it is not run:
            // while (true)
            // {
            //     Console.WriteLine("This message would continue forever.");
            // }
            //
            // This loop would be infinite because its condition is always true, and
            // nothing inside the loop changes the condition or exits with break.

            // Describe the corrected loop before showing its finite output.
            Console.WriteLine("PART 2: Corrected loop");
            Console.WriteLine("The counter starts at 1 and increases until it reaches 4.");

            // Start at 1, continue while the counter is at most 3, and add 1 each time.
            for (int counter = 1; counter <= 3; counter++)
            {
                // Display the current counter value to demonstrate each iteration.
                Console.WriteLine($"Corrected loop iteration: {counter}");
            }

            // The infinite example is fixed by using a changing counter and a condition
            // that eventually becomes false; therefore, this loop terminates after 3
            // iterations instead of running forever.
            Console.WriteLine();

            // =====================================================
            // PART 3
            // =====================================================

            // Explain that < stops before the number on the right side of the condition.
            Console.WriteLine("PART 3: Comparing < and <=");
            Console.WriteLine("Loop using < (the value 4 is not included):");

            // The condition index < 4 allows index values 1, 2, and 3.
            for (int index = 1; index < 4; index++)
            {
                // Display each value produced by the less-than loop.
                Console.WriteLine(index);
            }

            // Explain that <= includes the number on the right side of the condition.
            Console.WriteLine("Loop using <= (the value 4 is included):");

            // The condition index <= 4 allows index values 1, 2, 3, and 4.
            for (int index = 1; index <= 4; index++)
            {
                // Display each value produced by the less-than-or-equal loop.
                Console.WriteLine(index);
            }

            // The < operator excludes its limit, while <= includes its limit.
            Console.WriteLine();

            // =====================================================
            // PART 4
            // =====================================================

            // Create a string list in which every item appears only once.
            List<string> uniqueItems = new List<string>
            {
                "Apple",
                "Banana",
                "Cherry",
                "Date"
            };

            // Ask which item the user wants to find in the list.
            Console.Write("PART 4: Search the unique-items list. Enter an item: ");

            // Read the search text, handle end-of-input, and remove surrounding spaces.
            string firstSearch = (Console.ReadLine() ?? string.Empty).Trim();

            // Track whether the search loop finds a matching item.
            bool firstItemFound = false;

            // Check each list item in order, retaining the current zero-based index.
            for (int index = 0; index < uniqueItems.Count; index++)
            {
                // Compare without regard to letter case so "apple" matches "Apple".
                if (string.Equals(uniqueItems[index], firstSearch, StringComparison.OrdinalIgnoreCase))
                {
                    // Report the index of the first matching item.
                    Console.WriteLine($"First match found at index {index}.");

                    // Record that a match was found so the no-match message is skipped.
                    firstItemFound = true;

                    // Stop because this part asks for the first matching index only.
                    break;
                }
            }

            // Tell the user when the complete search found no matching item.
            if (!firstItemFound)
            {
                // Display the item that was not found.
                Console.WriteLine($"'{firstSearch}' was not found in the unique-items list.");
            }

            // Add a blank line to separate the output of this assignment part.
            Console.WriteLine();

            // =====================================================
            // PART 5
            // =====================================================

            // Create a list that intentionally contains repeated values.
            List<string> repeatedItems = new List<string>
            {
                "Blue",
                "Green",
                "Blue",
                "Red",
                "Green",
                "Blue"
            };

            // Ask the user which value to find in the list that has duplicates.
            Console.Write("PART 5: Search all duplicates. Enter an item: ");

            // Read the search text, handle end-of-input, and remove surrounding spaces.
            string allMatchesSearch = (Console.ReadLine() ?? string.Empty).Trim();

            // Track whether at least one occurrence of the requested value is found.
            bool anyMatchFound = false;

            // Check every list position so no occurrence can be missed.
            for (int index = 0; index < repeatedItems.Count; index++)
            {
                // Compare each value without regard to letter case.
                if (string.Equals(repeatedItems[index], allMatchesSearch, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the index of this matching occurrence.
                    Console.WriteLine($"Match found at index {index}.");

                    // Remember a match was found so the no-match message is skipped.
                    anyMatchFound = true;
                }

                // No break is used here because the search must continue to find all matches.
            }

            // Tell the user when the loop found no occurrence at any index.
            if (!anyMatchFound)
            {
                // Display the item that was not found.
                Console.WriteLine($"'{allMatchesSearch}' was not found in the repeated-items list.");
            }

            // Add a blank line to separate the output of this assignment part.
            Console.WriteLine();

            // =====================================================
            // PART 6
            // =====================================================

            // Create a list with values that occur once and values that occur more than once.
            List<string> colorItems = new List<string>
            {
                "Red",
                "Blue",
                "Red",
                "Green",
                "Blue",
                "Yellow"
            };

            // Create a second collection to remember values already encountered.
            // The comparer makes duplicate detection ignore differences in letter case.
            HashSet<string> previouslySeenItems = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Introduce the per-item uniqueness results.
            Console.WriteLine("PART 6: Unique and duplicate items");

            // Visit each value in the original list without using an index.
            foreach (string item in colorItems)
            {
                // Add returns true only when this value was not already in the set.
                if (previouslySeenItems.Add(item))
                {
                    // The first occurrence is unique at the point it is encountered.
                    Console.WriteLine($"{item}: unique");
                }
                else
                {
                    // A value already in the set has appeared earlier, so it is a duplicate.
                    Console.WriteLine($"{item}: duplicate");
                }
            }

            // Explain that the set holds all values seen so far and is checked each time.
            Console.WriteLine();
            Console.WriteLine("The second collection tracks each value after its first occurrence.");
        }
    }
}
