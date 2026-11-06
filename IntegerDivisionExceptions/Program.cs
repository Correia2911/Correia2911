using System; // Provides Console for reading input and displaying messages.
using System.Collections.Generic; // Provides the List<int> collection.

namespace IntegerDivisionExceptions // Groups the application code under a descriptive name.
{
    internal class Program // Defines the class that contains the application.
    {
        private static void Main() // The program starts running in this method.
        {
            // Display a title so the user knows what the program does.
            Console.WriteLine("Integer Division with Exception Handling");
            Console.WriteLine();

            // Create a list of whole numbers that the program will divide.
            List<int> numbers = new List<int> { 24, 15, 10, 7 };

            // Show the values before asking for the divisor.
            Console.WriteLine("Numbers to divide: " + string.Join(", ", numbers));

            try // Place operations that may fail inside a try block.
            {
                // Ask the user to enter a whole-number divisor.
                Console.Write("Enter an integer to divide each number by: ");

                // Read the input and convert it to an integer.
                // int.Parse throws a FormatException if the text is not a valid integer.
                string? userInput = Console.ReadLine();
                int divisor = int.Parse(userInput ?? string.Empty);

                // Explain that each list value will now be divided by the input value.
                Console.WriteLine();
                Console.WriteLine($"Dividing each number by {divisor}:");

                // Visit each integer in the list, one at a time.
                foreach (int number in numbers)
                {
                    // Convert the numerator to decimal so division can show fractional results.
                    // Decimal division by zero throws DivideByZeroException as required.
                    decimal result = (decimal)number / divisor;

                    // Display the original number and its calculated result clearly.
                    Console.WriteLine($"{number} / {divisor} = {result}");
                }
            }
            catch (DivideByZeroException) // Handle an attempt to divide by zero specifically.
            {
                // Explain the problem in language that is helpful to the user.
                Console.WriteLine("Error: The divisor cannot be zero. Please enter a non-zero integer.");
            }
            catch (FormatException) // Handle input that cannot be converted to an integer.
            {
                // Explain that the requested input must be a whole number.
                Console.WriteLine("Error: Your input was not a valid integer. Please enter digits such as 2 or -2.");
            }
            catch (Exception) // Handle other unexpected exceptions as a final fallback.
            {
                // Show a friendly message without exposing technical exception details.
                Console.WriteLine("An unexpected error occurred while processing the input.");
            }

            // This line runs after a successful calculation or any handled exception.
            Console.WriteLine();
            Console.WriteLine("The application continued running after exception handling.");
        }
    }
}
