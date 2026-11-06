using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a heading for the first loop demonstration.
            Console.WriteLine("WHILE loop boolean comparison");

            // Start the counter at 1 so the loop can show three counting steps.
            int whileNumber = 1;

            // Compare whileNumber with 3 before each repetition.
            // The expression whileNumber <= 3 is a Boolean comparison:
            // it evaluates to true or false.
            while (whileNumber <= 3)
            {
                // Display the current counter value while the comparison is true.
                Console.WriteLine($"The while loop count is {whileNumber}.");

                // Add 1 so the comparison will eventually become false
                // and the loop will stop.
                whileNumber++;
            }

            // Add an empty line to separate the two loop demonstrations.
            Console.WriteLine();

            // Display a heading for the second loop demonstration.
            Console.WriteLine("DO WHILE loop boolean comparison");

            // Start this demonstration's counter at 1.
            int doWhileNumber = 1;

            // A do while loop runs its body once before checking its condition.
            do
            {
                // Display the current counter value before the condition is checked.
                Console.WriteLine($"The do while loop count is {doWhileNumber}.");

                // Add 1 so the comparison will eventually become false.
                doWhileNumber++;
            }
            // Repeat while doWhileNumber is less than or equal to 3.
            while (doWhileNumber <= 3);

            // Add an empty line before starting the income comparison program.
            Console.WriteLine();

            // Display the title of the program.
            Console.WriteLine("Anonymous Income Comparison Program");

            // Display the heading for Person 1.
            Console.WriteLine("\nPerson 1");

            // Ask Person 1 for their hourly rate.
            Console.WriteLine("Hourly Rate?");

            // Read the hourly rate entered by the user and convert it to a decimal.
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Ask Person 1 for the number of hours worked per week.
            Console.WriteLine("Hours worked per week?");

            // Read the hours worked and convert it to a decimal.
            decimal person1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

            // Calculate Person 1's annual salary.
            // Annual salary = hourly rate × hours per week × 52 weeks.
            decimal person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;

            // Display the heading for Person 2.
            Console.WriteLine("\nPerson 2");

            // Ask Person 2 for their hourly rate.
            Console.WriteLine("Hourly Rate?");

            // Read the hourly rate entered by the user and convert it to a decimal.
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());

            // Ask Person 2 for the number of hours worked per week.
            Console.WriteLine("Hours worked per week?");

            // Read the hours worked and convert it to a decimal.
            decimal person2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

            // Calculate Person 2's annual salary.
            // Annual salary = hourly rate × hours per week × 52 weeks.
            decimal person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;

            // Display Person 1's annual salary.
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(person1AnnualSalary);

            // Display Person 2's annual salary.
            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine(person2AnnualSalary);

            // Compare the two salaries.
            // This creates a Boolean value that will be either True or False.
            bool person1MakesMoreMoney = person1AnnualSalary > person2AnnualSalary;

            // Display the comparison statement.
            Console.WriteLine("\nPerson 1 makes more money than Person 2");

            // Display the result of the comparison.
            Console.WriteLine(person1MakesMoreMoney);

        }
    }
}
