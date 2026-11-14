using System; // Provides console input, output, and path information.
using System.IO; // Provides file read and write methods.

namespace InputAssignment // Groups the classes used in this assignment.
{
    // Contains the program entry point and coordinates input and file operations.
    internal class Program
    {
        // Main is the first method that runs when the console application starts.
        private static void Main()
        {
            // Ask the user to enter a whole number that the program can save.
            Console.Write("Enter a whole number: ");

            // Read the user's input; null means that no input is available.
            string? input = Console.ReadLine();

            // Stop safely if the input stream has ended.
            if (input is null)
            {
                Console.WriteLine("No input was received. The program will now close.");
                return;
            }

            // Convert the input text to an integer, and report invalid input clearly.
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please run the program again and enter a whole number.");
                return;
            }

            // Place the text file in the application's output folder (for example, bin\Debug\net10.0).
            string filePath = Path.Combine(AppContext.BaseDirectory, "number.txt");

            try
            {
                // Convert the integer back to text and write it to the text file.
                File.WriteAllText(filePath, number.ToString());

                // Read all of the text from the file that was just created.
                string savedNumber = File.ReadAllText(filePath);

                // Tell the user the saved text file's location.
                Console.WriteLine();
                Console.WriteLine($"Saved the number to: {filePath}");

                // Display the file contents so the user can see what was stored.
                Console.WriteLine("Contents of the text file:");
                Console.WriteLine(savedNumber);
            }
            catch (IOException exception)
            {
                // Explain that the requested file operation could not be completed.
                Console.WriteLine($"The number could not be saved or read: {exception.Message}");
            }
            catch (UnauthorizedAccessException exception)
            {
                // Explain that the application does not have permission to access the file.
                Console.WriteLine($"The application does not have permission to access the file: {exception.Message}");
            }
        }
    }
}
