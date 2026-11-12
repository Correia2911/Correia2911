using System; // Provides Console.WriteLine for displaying the amount.

namespace StructAssignment // Groups the struct and program class for this assignment.
{
    // Contains the program entry point and demonstrates creating a Number value.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Create a Number value and set its Amount property with an object initializer.
            Number number = new Number
            {
                Amount = 123.45m
            };

            // Display the decimal amount stored in the Number value.
            Console.WriteLine($"Amount: {number.Amount}");
        }
    }

    // Define a struct named Number to group a decimal amount as a value type.
    internal struct Number
    {
        // Store the amount as a decimal, which is suitable for precise decimal values.
        public decimal Amount { get; set; }
    }
}
