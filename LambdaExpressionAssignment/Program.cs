using System; // Provides Console for displaying the filtered employees.
using System.Collections.Generic; // Provides List<T> collections.
using System.Linq; // Provides the Where method used with lambda expressions.

namespace LambdaExpressionAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and the employee filtering examples.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Create a list with ten employees; two employees have the first name Joe.
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "David", LastName = "Taylor" },
                new Employee { Id = 8, FirstName = "Olivia", LastName = "Anderson" },
                new Employee { Id = 9, FirstName = "James", LastName = "Thomas" },
                new Employee { Id = 10, FirstName = "Sophia", LastName = "Jackson" }
            };

            // Create an empty list that will hold Joe employees found by the foreach loop.
            List<Employee> joesFromLoop = new List<Employee>();

            // Check every employee in the source list.
            foreach (Employee employee in employees)
            {
                // Compare the employee object's FirstName property with "Joe".
                if (employee.FirstName == "Joe")
                {
                    // Add matching employee objects to the result list.
                    joesFromLoop.Add(employee);
                }
            }

            // Display a heading and every employee found by the foreach loop.
            Console.WriteLine("Employees named Joe (foreach loop):");
            DisplayEmployees(joesFromLoop);

            // Use a lambda expression to select employees whose FirstName is "Joe".
            // The Where method returns all employees that satisfy the expression.
            List<Employee> joesFromLambda = employees
                .Where(employee => employee.FirstName == "Joe")
                .ToList();

            // Display a heading and every employee found by the lambda expression.
            Console.WriteLine();
            Console.WriteLine("Employees named Joe (lambda expression):");
            DisplayEmployees(joesFromLambda);

            // Use a lambda expression to select employees whose Id is greater than 5.
            List<Employee> employeesWithHighIds = employees
                .Where(employee => employee.Id > 5)
                .ToList();

            // Display a heading and every employee whose ID is greater than 5.
            Console.WriteLine();
            Console.WriteLine("Employees with an ID greater than 5:");
            DisplayEmployees(employeesWithHighIds);
        }

        // Display each employee's ID and full name from the supplied list.
        private static void DisplayEmployees(List<Employee> employees)
        {
            // Visit every employee in the list passed to this method.
            foreach (Employee employee in employees)
            {
                // Print the employee's identifier, first name, and last name.
                Console.WriteLine(
                    $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
        }
    }

    // Represents an employee with an ID, first name, and last name.
    internal class Employee
    {
        // Store the employee's identifier.
        public int Id { get; set; }

        // Store the employee's first name.
        public string FirstName { get; set; } = string.Empty;

        // Store the employee's last name.
        public string LastName { get; set; } = string.Empty;
    }
}
