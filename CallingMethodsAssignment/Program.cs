using System;

namespace CallingMethodsAssignment
{
    // Contains the entry point and user interaction for the console application.
    internal class Program
    {
        // Main is the first method called when the application starts.
        private static void Main()
        {
            // Display a title that identifies the purpose of this assignment.
            Console.WriteLine("Calling Methods Assignment");
            Console.WriteLine();

            // Declare a variable that will hold the integer entered by the user.
            int number;

            // Keep requesting input until the user enters a valid integer.
            while (true)
            {
                // Prompt the user to enter the value used by each math operation.
                Console.Write("Enter a whole number: ");

                // Read the user's input; null means that no more console input is available.
                string? input = Console.ReadLine();

                // End the program safely if input is unavailable instead of repeating forever.
                if (input is null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No input was received. The program will now close.");
                    return;
                }

                // TryParse converts valid integer text and stores the converted number in number.
                if (int.TryParse(input, out number))
                {
                    // Leave the input loop after successfully converting the user's value.
                    break;
                }

                // Explain the expected input before asking again.
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }

            // Create a MathOperations object so its public methods can be called.
            MathOperations mathOperations = new MathOperations();

            // Call each method with the same input and store each returned result.
            int additionResult = mathOperations.AddTen(number);
            int multiplicationResult = mathOperations.MultiplyByFive(number);
            int subtractionResult = mathOperations.SubtractThree(number);

            // Display the original input and the result returned by each method.
            Console.WriteLine();
            Console.WriteLine($"You entered: {number}");
            Console.WriteLine($"After adding 10: {additionResult}");
            Console.WriteLine($"After multiplying by 5: {multiplicationResult}");
            Console.WriteLine($"After subtracting 3: {subtractionResult}");

            // Wait for a key press so the console window stays open after displaying the results.
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
