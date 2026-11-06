using System; // Provides Console for displaying prompts and reading user input.

namespace OptionalParameterAssignment // Groups the classes for this assignment.
{
    // Contains the application's entry point and the interaction with the user.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Display a title so the user knows what the program demonstrates.
            Console.WriteLine("Method Assignment: Optional Parameter");
            Console.WriteLine();

            // Create an object so Main can call the AddNumbers method.
            MathOperations mathOperations = new MathOperations();

            // Declare a variable that will hold the required first integer.
            int firstNumber;

            // Keep asking until the user enters a valid whole number.
            while (true)
            {
                // Ask for the required number and explain that it must be an integer.
                Console.Write("Enter the first required whole number: ");

                // Read the user's input; null means that no more input is available.
                string? firstInput = Console.ReadLine();

                // Stop safely if the input stream has ended before a required number was entered.
                if (firstInput is null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No input was received. The program will now close.");
                    return;
                }

                // TryParse converts valid integer text without throwing an exception.
                if (int.TryParse(firstInput, out firstNumber))
                {
                    // Leave the loop when the required number has been read successfully.
                    break;
                }

                // Explain the expected input and let the user try again.
                Console.WriteLine("Invalid input. Please enter a whole number, such as 12 or -4.");
            }

            // Explain that the second number is optional and Enter skips it.
            Console.Write("Enter a second whole number, or press Enter to skip it: ");

            // Read the optional input; a blank line means the user chose not to provide it.
            string? secondInput = Console.ReadLine();

            // Declare a nullable integer: it contains a value if entered, or null if skipped.
            int? secondNumber = null;

            // Keep asking again only when the user provided non-empty, invalid input.
            while (!string.IsNullOrWhiteSpace(secondInput))
            {
                // Try to convert the optional text into an integer.
                if (int.TryParse(secondInput, out int parsedSecondNumber))
                {
                    // Store the parsed number to indicate that the optional value was supplied.
                    secondNumber = parsedSecondNumber;

                    // Stop asking because the optional input is valid.
                    break;
                }

                // Explain the accepted choices: a whole number or a blank line.
                Console.Write("Invalid input. Enter a whole number, or press Enter to skip: ");

                // Read another answer so the user can correct the optional input.
                secondInput = Console.ReadLine();
            }

            // Declare a variable that will hold the result returned by AddNumbers.
            int result;

            // Check whether the user supplied a value for the optional parameter.
            if (secondNumber.HasValue)
            {
                // Pass both values when the user supplied the optional second number.
                result = mathOperations.AddNumbers(firstNumber, secondNumber.Value);

                // Display both inputs and the addition result.
                Console.WriteLine();
                Console.WriteLine(
                    $"{firstNumber} + {secondNumber.Value} = {result}");
            }
            else
            {
                // Pass only the required value; the method's default secondNumber of 0 is used.
                result = mathOperations.AddNumbers(firstNumber);

                // Explain that the optional parameter's default value was used.
                Console.WriteLine();
                Console.WriteLine($"No second number was entered, so {firstNumber} + 0 = {result}");
            }

            // Confirm that the program has finished processing the input.
            Console.WriteLine();
            Console.WriteLine("The calculation is complete.");
        }
    }
}
