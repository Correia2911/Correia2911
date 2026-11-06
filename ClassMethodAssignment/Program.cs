using System; // Provides Console for reading input and writing output.

namespace ClassMethodAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and coordinates the user's input and calculations.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Use a static class to display the application title without creating an object.
            AssignmentMessages.DisplayTitle();

            // Create an instance of DivisionOperations to call its instance methods.
            DivisionOperations divisionOperations = new DivisionOperations();

            // Declare a variable that will hold the whole number entered by the user.
            int number;

            // Keep asking until the user enters a valid integer.
            while (true)
            {
                // Ask the user for the value that will be divided by two.
                Console.Write("Enter a whole number: ");

                // Read the user's input; null means that no more console input is available.
                string? input = Console.ReadLine();

                // Exit cleanly if no input is available instead of repeating forever.
                if (input is null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No input was received. The program will now close.");
                    return;
                }

                // TryParse converts integer text safely without throwing for invalid text.
                if (int.TryParse(input, out number))
                {
                    // Stop asking once a valid integer has been stored in number.
                    break;
                }

                // Explain the expected input so the user can try again.
                Console.WriteLine("Invalid input. Please enter a whole number, such as 12 or -4.");
            }

            // Label the first demonstration, in which the method displays its own result.
            Console.WriteLine();
            Console.WriteLine("Division method:");

            // Call the void method that divides the entered number by two and displays it.
            divisionOperations.DivideByTwo(number);

            // Label the overload demonstration, which calculates values using output parameters.
            Console.WriteLine();
            Console.WriteLine("Overloaded method with output parameters:");

            // Call the overload and declare variables to receive its two output values.
            divisionOperations.DivideByTwo(number, out int quotient, out int remainder);

            // Display the result values assigned by the overloaded method.
            Console.WriteLine($"Integer quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");

            // Explain that integer division keeps the whole-number quotient and its remainder.
            Console.WriteLine();
            Console.WriteLine("The quotient and remainder together describe the integer division.");
        }
    }

    // Provides instance methods that divide an integer by two.
    internal class DivisionOperations
    {
        // Divides the supplied integer by two and writes the integer quotient to the console.
        public void DivideByTwo(int number)
        {
            // Integer division returns a whole-number quotient and discards any fractional part.
            int quotient = number / 2;

            // Display the original value and the calculated quotient.
            Console.WriteLine($"{number} divided by 2 is {quotient}.");
        }

        // This overload has a different parameter list and also returns division details by out.
        // The quotient is the whole-number answer; the remainder is what is left over.
        public void DivideByTwo(int number, out int quotient, out int remainder)
        {
            // Assign the whole-number division result to the first output parameter.
            quotient = number / 2;

            // Assign the leftover amount to the second output parameter using the remainder operator.
            remainder = number % 2;
        }
    }

    // A static class cannot be instantiated; its members are called using the class name.
    internal static class AssignmentMessages
    {
        // Display a heading before the program asks for input.
        public static void DisplayTitle()
        {
            // Write the assignment title and a blank line for readability.
            Console.WriteLine("Class Method Assignment: Divide by Two");
            Console.WriteLine();
        }
    }
}
