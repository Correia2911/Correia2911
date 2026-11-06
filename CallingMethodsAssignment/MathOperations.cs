namespace CallingMethodsAssignment
{
    // Provides separate mathematical operations for the console application to call.
    public class MathOperations
    {
        // Adds ten to the supplied integer and returns the calculated result.
        public int AddTen(int number)
        {
            return number + 10;
        }

        // Multiplies the supplied integer by five and returns the calculated result.
        public int MultiplyByFive(int number)
        {
            return number * 5;
        }

        // Subtracts three from the supplied integer and returns the calculated result.
        public int SubtractThree(int number)
        {
            return number - 3;
        }
    }
}
