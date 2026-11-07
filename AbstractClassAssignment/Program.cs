using System; // Provides Console.WriteLine for displaying the employee's name.

namespace AbstractClassAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and creates the Employee object.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Create an Employee object and initialize the name properties it inherits from Person.
            Employee employee = new Employee
            {
                // Set the employee's first name using the inherited FirstName property.
                FirstName = "Sample",

                // Set the employee's last name using the inherited LastName property.
                LastName = "Student"
            };

            // Call Employee's implementation of the abstract SayName method.
            employee.SayName();
        }
    }

    // Abstract means Person is a base class and cannot be instantiated directly.
    internal abstract class Person
    {
        // Store the person's first name and provide public access to read or set it.
        public string FirstName { get; set; } = string.Empty;

        // Store the person's last name and provide public access to read or set it.
        public string LastName { get; set; } = string.Empty;

        // Require every non-abstract class derived from Person to implement this method.
        public abstract void SayName();
    }

    // Employee inherits the name properties and abstract method declaration from Person.
    internal class Employee : Person
    {
        // Override the abstract method to provide Employee's name-display behavior.
        public override void SayName()
        {
            // Display the employee's full name in the required format.
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
