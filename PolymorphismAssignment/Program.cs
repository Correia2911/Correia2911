using System; // Provides Console.WriteLine for displaying messages.

namespace PolymorphismAssignment // Groups the classes and interface for this assignment.
{
    // Contains the program entry point and demonstrates interface-based polymorphism.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Create an Employee object and initialize the name properties inherited from Person.
            Employee employee = new Employee
            {
                // Set the employee's first name.
                FirstName = "Sample",

                // Set the employee's last name.
                LastName = "Student"
            };

            // Store the Employee object in a variable whose type is the IQuittable interface.
            // This is polymorphism: the interface reference points to an Employee instance.
            IQuittable quittableEmployee = employee;

            // Call Quit through the interface; Employee's implementation runs.
            quittableEmployee.Quit();
        }
    }

    // Defines the action that any class implementing this interface must provide.
    internal interface IQuittable
    {
        // Require implementing classes to provide a parameterless void Quit method.
        void Quit();
    }

    // Represents a person with a first and last name.
    internal class Person
    {
        // Store the person's first name and allow it to be read and set.
        public string FirstName { get; set; } = string.Empty;

        // Store the person's last name and allow it to be read and set.
        public string LastName { get; set; } = string.Empty;
    }

    // Employee inherits the name properties from Person and promises to implement IQuittable.
    internal class Employee : Person, IQuittable
    {
        // Implement the Quit method required by the IQuittable interface.
        public void Quit()
        {
            // Display a message to show that the interface method was called.
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }
}
