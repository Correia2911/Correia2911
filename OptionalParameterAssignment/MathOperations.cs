namespace OptionalParameterAssignment // Places this class in the same namespace as Program.
{
    // Groups mathematical methods that can be used by the console application.
    internal class MathOperations
    {
        // Adds two integers and returns their sum.
        // The default value lets callers omit secondNumber; in that case, it is 0.
        public int AddNumbers(int firstNumber, int secondNumber = 0)
        {
            // Return the sum of the required integer and the optional integer.
            return firstNumber + secondNumber;
        }
    }
}
