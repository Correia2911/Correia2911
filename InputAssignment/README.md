# Input Assignment

## Project Overview

This beginner-friendly C# console application asks for a whole number, writes
the number to a text file, then reads and prints the file contents. The file is
created in the application's output directory, such as `bin/Debug/net10.0`.

## Concepts Demonstrated

- Reading user input with `Console.ReadLine`.
- Validating and converting input with `int.TryParse`.
- Creating a file path with `Path.Combine` and `AppContext.BaseDirectory`.
- Writing text to a file with `File.WriteAllText`.
- Reading text from a file with `File.ReadAllText`.
- Handling common file access errors.

## How To Run

### Visual Studio

1. Open `InputAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.
4. Enter a whole number when prompted.
5. Find `number.txt` in the application's output folder, for example
   `bin\Debug\net10.0`.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\InputAssignment.csproj
```

## Example Output

```text
Enter a whole number: 42

Saved the number to: ...\bin\Debug\net10.0\number.txt
Contents of the text file:
42
```

## Assessor Checklist

- Asks the user for a number: included.
- Writes the entered number to a text file: included.
- Reads and prints the text file contents: included.
- Comments explain each significant line and code block: included.

## Suggested Git Commit Message

`Add input and text file assignment`
