using System; // Provides Console and Enum methods for the console application.

namespace ParsingEnumsAssignment // Groups the enum and program classes for this assignment.
{
    // Contains the program entry point and parses the user's day input.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Ask the user to type a day name.
            Console.Write("Enter the current day of the week: ");

            // Read the user's input; use an empty string if no input is available.
            string dayInput = Console.ReadLine() ?? string.Empty;

            // Declare a variable that will store the successfully parsed enum value.
            DaysOfWeek currentDay;

            try // Place enum conversion and validation in a block that can handle parsing errors.
            {
                // Parse the text into the DaysOfWeek enum without regard to letter case.
                currentDay = Enum.Parse<DaysOfWeek>(dayInput, ignoreCase: true);

                // Reject numbers and undefined enum values so only actual day names are accepted.
                if (int.TryParse(dayInput, out _) || !Enum.IsDefined(currentDay))
                {
                    // Throw a parsing-related exception so the catch block displays the required message.
                    throw new ArgumentException("The input is not a named day of the week.");
                }

                // Confirm which enum value was assigned when parsing succeeds.
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException) // Handle invalid names and values that are not valid day names.
            {
                // Display the exact friendly error message requested by the assignment.
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (OverflowException) // Handle numeric input too large to parse as an enum value.
            {
                // Display the same friendly message for an out-of-range numeric value.
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }

    // Define the seven valid days as named values in an enum type.
    internal enum DaysOfWeek
    {
        // The first day value in this example.
        Sunday,

        // The second day value in this example.
        Monday,

        // The third day value in this example.
        Tuesday,

        // The fourth day value in this example.
        Wednesday,

        // The fifth day value in this example.
        Thursday,

        // The sixth day value in this example.
        Friday,

        // The seventh day value in this example.
        Saturday
    }
}
