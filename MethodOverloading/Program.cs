using System; // Provides Console for displaying the results.

namespace MethodOverloading // Groups the classes for this assignment under a descriptive name.
{
    // Contains the program entry point and demonstrates calling overloaded methods.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Display a heading to explain the purpose of this program.
            Console.WriteLine("Method Overloading Demonstration");
            Console.WriteLine();

            // Create an instance of MathOperations so its Calculate methods can be called.
            MathOperations mathOperations = new MathOperations();

            // Store an integer argument for the first Calculate overload.
            int integerValue = 7;

            // Pass an int argument; C# selects Calculate(int) and adds 10.
            int integerResult = mathOperations.Calculate(integerValue);

            // Display the integer input and the result returned by its overload.
            Console.WriteLine($"Integer calculation: {integerValue} + 10 = {integerResult}");

            // Store a decimal argument for the second Calculate overload.
            decimal decimalValue = 6.5m;

            // Pass a decimal argument; C# selects Calculate(decimal) and doubles it.
            int decimalResult = mathOperations.Calculate(decimalValue);

            // Display the decimal input and the integer result returned by its overload.
            Console.WriteLine($"Decimal calculation: {decimalValue} multiplied by 2 = {decimalResult}");

            // Store numeric text for the third Calculate overload.
            string textValue = "8";

            // Pass a string argument; C# selects Calculate(string), parses it, and subtracts 3.
            int stringResult = mathOperations.Calculate(textValue);

            // Display the text input and the result returned by its overload.
            Console.WriteLine($"String calculation: {textValue} converted to an integer, then minus 3 = {stringResult}");

            // Remind the learner that each call used the same method name with a different parameter type.
            Console.WriteLine();
            Console.WriteLine("C# chose a Calculate method based on the type of each argument.");
        }
    }

    // Provides three different calculations through methods that share the name Calculate.
    internal class MathOperations
    {
        // This overload accepts an int and adds 10 to the supplied whole number.
        public int Calculate(int number)
        {
            // Return the result of the integer addition.
            return number + 10;
        }

        // This overload accepts a decimal and multiplies it by 2.
        public int Calculate(decimal number)
        {
            // Convert.ToInt32 rounds the decimal result to the nearest int.
            // This example produces a whole number for 6.5m * 2m, so no rounding occurs.
            return Convert.ToInt32(number * 2m);
        }

        // This overload accepts numeric text, converts it to an int, and subtracts 3.
        public int Calculate(string numberText)
        {
            // int.Parse converts the string into an integer; it requires valid integer text.
            int number = int.Parse(numberText);

            // Return the result of the subtraction as an integer.
            return number - 3;
        }
    }
}
