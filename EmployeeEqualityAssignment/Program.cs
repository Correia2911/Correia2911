using System; // Provides Console for displaying the equality test results.

namespace EmployeeEqualityAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and demonstrates Employee equality.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Create the first employee with an ID and a name.
            Employee firstEmployee = new Employee
            {
                Id = 1,
                FirstName = "Alex",
                LastName = "Morgan"
            };

            // Create a second employee with the same ID but a different name.
            Employee secondEmployee = new Employee
            {
                Id = 1,
                FirstName = "Jordan",
                LastName = "Lee"
            };

            // Create a third employee with a different ID.
            Employee thirdEmployee = new Employee
            {
                Id = 2,
                FirstName = "Taylor",
                LastName = "Reed"
            };

            // Compare the first two objects; matching IDs mean they are equal.
            Console.WriteLine(
                $"Do {firstEmployee.FirstName} and {secondEmployee.FirstName} have the same ID? " +
                $"{firstEmployee == secondEmployee}");

            // Compare objects with different IDs; the result should be false.
            Console.WriteLine(
                $"Do {firstEmployee.FirstName} and {thirdEmployee.FirstName} have the same ID? " +
                $"{firstEmployee == thirdEmployee}");

            // Demonstrate the paired != operator, which is the opposite of ==.
            Console.WriteLine(
                $"Are {firstEmployee.FirstName} and {thirdEmployee.FirstName} different employees? " +
                $"{firstEmployee != thirdEmployee}");
        }
    }

    // Represents an employee and defines equality based only on the employee ID.
    internal class Employee
    {
        // Store the employee's identifier, which is used when comparing employees.
        public int Id { get; set; }

        // Store the employee's first name for display.
        public string FirstName { get; set; } = string.Empty;

        // Store the employee's last name for display.
        public string LastName { get; set; } = string.Empty;

        // Overload == so two employees are equal when their IDs match.
        public static bool operator ==(Employee? firstEmployee, Employee? secondEmployee)
        {
            // The same reference (including two null references) is always equal to itself.
            if (ReferenceEquals(firstEmployee, secondEmployee))
            {
                return true;
            }

            // If only one reference is null, the two values cannot be equal.
            if (firstEmployee is null || secondEmployee is null)
            {
                return false;
            }

            // Names do not affect equality; compare only the required Id property.
            return firstEmployee.Id == secondEmployee.Id;
        }

        // Overload != as the logical opposite of ==, as C# requires the operators in pairs.
        public static bool operator !=(Employee? firstEmployee, Employee? secondEmployee)
        {
            // Reuse the == implementation so both operators follow the same equality rule.
            return !(firstEmployee == secondEmployee);
        }

        // Make Equals follow the same ID-based rule used by the overloaded operators.
        public override bool Equals(object? obj)
        {
            // Only another Employee with the same ID is considered equal.
            return obj is Employee otherEmployee && Id == otherEmployee.Id;
        }

        // Return a hash code based on Id so it is consistent with Equals.
        public override int GetHashCode()
        {
            // Equal employees have equal IDs and therefore the same hash code.
            return Id.GetHashCode();
        }
    }
}
