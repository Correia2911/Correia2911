using System;
using System.Text;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a title so the user can identify this program in the console.
            Console.WriteLine("String Operations Demonstration");
            Console.WriteLine();

            // Store the first piece of text in a string variable.
            string firstText = "Learning";

            // Store the second piece of text in another string variable.
            string secondText = " C#";

            // Store the third piece of text in another string variable.
            string thirdText = " is fun!";

            // Join the three strings in order using the + concatenation operator.
            string combinedText = firstText + secondText + thirdText;

            // Label and display the combined text.
            Console.WriteLine("Three strings combined:");
            Console.WriteLine(combinedText);
            Console.WriteLine();

            // Call ToUpper() to create an uppercase version of the combined text.
            string uppercaseText = combinedText.ToUpper();

            // Label and display the uppercase text.
            Console.WriteLine("The combined text in uppercase:");
            Console.WriteLine(uppercaseText);
            Console.WriteLine();

            // Create a StringBuilder object to assemble a longer piece of text.
            StringBuilder paragraph = new StringBuilder();

            // Add the first sentence to the StringBuilder.
            // The trailing space separates it from the next sentence.
            paragraph.Append("C# strings are useful for storing text. ");

            // Add the second sentence to the same StringBuilder object.
            paragraph.Append("StringBuilder can add text efficiently, one piece at a time. ");

            // Add the third and final sentence to complete the paragraph.
            paragraph.Append("When the paragraph is ready, ToString() gives us the finished text.");

            // Convert the completed StringBuilder contents to a regular string.
            string completedParagraph = paragraph.ToString();

            // Label and display the completed paragraph.
            Console.WriteLine("Paragraph created with StringBuilder:");
            Console.WriteLine(completedParagraph);
        }
    }
}
