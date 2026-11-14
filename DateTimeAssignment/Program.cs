using System; // Provides DateTime, Console, and integer parsing.

namespace DateTimeAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and calculates a future time.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Capture the current local date and time once so both displays use the same starting point.
            DateTime currentDateTime = DateTime.Now;

            // Display the captured current date and time in a readable format.
            Console.WriteLine($"Current date and time: {currentDateTime:F}");

            // Ask the user how many hours should be added to the current time.
            Console.Write("Enter a number of hours: ");

            // Read the user's input; null means that no input is available.
            string? input = Console.ReadLine();

            // Stop safely if the input stream has ended.
            if (input is null)
            {
                Console.WriteLine("No input was received. The program will now close.");
                return;
            }

            // Convert the input text to an integer, and report invalid input clearly.
            if (!int.TryParse(input, out int hours))
            {
                Console.WriteLine("Invalid input. Please run the program again and enter a whole number.");
                return;
            }

            try
            {
                // Add the requested number of hours to the captured current date and time.
                DateTime futureDateTime = currentDateTime.AddHours(hours);

                // Display the calculated date and time in the same readable format.
                Console.WriteLine($"The date and time in {hours} hour(s) will be: {futureDateTime:F}");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Explain that the requested number of hours is outside DateTime's supported range.
                Console.WriteLine("That number of hours is too large to calculate a date and time.");
            }
        }
    }
}
