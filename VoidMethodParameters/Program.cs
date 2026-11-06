using System; // Provides Console.WriteLine for displaying text.

namespace VoidMethodParameters // Groups the classes used by this assignment.
{
    // Contains the program entry point and demonstrates both method-call styles.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Display a title so the user knows what this example demonstrates.
            Console.WriteLine("Void Method and Named Parameters");
            Console.WriteLine();

            // Create an instance of MathOperations so its method can be called.
            MathOperations mathOperations = new MathOperations();

            // Call the method with positional arguments in the same order as its parameters.
            // The first argument is firstNumber, and the second argument is secondNumber.
            Console.WriteLine("Call using positional arguments:");
            mathOperations.DisplayCalculation(5, 12);

            // Add a blank line to make the two method-call examples easy to distinguish.
            Console.WriteLine();

            // Call the same method using parameter names, so the argument order is explicit.
            Console.WriteLine("Call using named arguments:");
            mathOperations.DisplayCalculation(firstNumber: 8, secondNumber: 20);
        }
    }

    // Contains a mathematical operation and displays the value of its second parameter.
    internal class MathOperations
    {
        // Doubles the first integer and displays both the result and the second integer.
        // The void return type means this method displays information but returns no value.
        public void DisplayCalculation(int firstNumber, int secondNumber)
        {
            // Perform a multiplication operation using the first integer parameter.
            int calculationResult = firstNumber * 2;

            // Display the result of the operation on the first integer.
            Console.WriteLine($"{firstNumber} multiplied by 2 is {calculationResult}.");

            // Display the second integer parameter as required by the assignment.
            Console.WriteLine($"The second number is {secondNumber}.");
        }
    }
}
