using System; // Provides Console.WriteLine for displaying the person's name.

namespace MethodsAndObjectsAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and creates the Employee object.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Create an Employee object and set its inherited and employee-specific properties.
            Employee employee = new Employee
            {
                // Set the FirstName property inherited from Person.
                FirstName = "Sample",

                // Set the LastName property inherited from Person.
                LastName = "Student",

                // Set the employee's own Id property.
                Id = 1
            };

            // Call the SayName method that Employee inherits from the Person superclass.
            employee.SayName();
        }
    }

    // Represents a person and provides the name properties and name-display method.
    internal class Person
    {
        // Store the person's first name; an empty default avoids an uninitialized value.
        public string FirstName { get; set; } = string.Empty;

        // Store the person's last name; an empty default avoids an uninitialized value.
        public string LastName { get; set; } = string.Empty;

        // Display the person's full name in the format required by the assignment.
        public void SayName()
        {
            // Combine the first and last names and write them to the console.
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Employee inherits the name properties and SayName method from Person.
    internal class Employee : Person
    {
        // Store the employee's unique integer identifier.
        public int Id { get; set; }
    }
}
