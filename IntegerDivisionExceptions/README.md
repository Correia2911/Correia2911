# Integer Division with Exception Handling

## Project Overview

This beginner-friendly C# console application stores several integers in a
`List<int>`, asks the user for an integer divisor, and uses a `foreach` loop to
divide each list value by that divisor. It demonstrates exception handling for
zero divisors, invalid numeric input, and other unexpected errors.

The results use `decimal` division so that fractional answers are not discarded.
Unlike floating-point division, decimal division by zero throws
`DivideByZeroException`, which is handled by the program.

## Assignment Objectives

- Create and use a `List<int>` containing multiple integer values.
- Read a divisor from the console and convert it to an integer.
- Process each value using a `foreach` loop.
- Handle `DivideByZeroException`, `FormatException`, and `Exception`.
- Show a user-friendly message for each handled error case.
- Print a message after the `try`/`catch` to demonstrate that the program
  continues after an exception.

## Technologies Used

- C#
- .NET 10 Console Application
- `System.Collections.Generic`

## Skills Demonstrated

- Generic collections with `List<int>`
- Console input and output
- Converting text to an integer with `int.Parse`
- Iterating over a collection with `foreach`
- Numeric division and preserving fractional results with `decimal`
- `try`/`catch` exception handling
- Catching specific exceptions before a general `Exception`

## How To Run

### Visual Studio

1. Install the .NET 10 SDK and a Visual Studio version that supports .NET 10.
2. Open `IntegerDivisionExceptions.csproj` in Visual Studio.
3. Build the project with **Build > Build Solution**.
4. Run it with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\IntegerDivisionExceptions.csproj
```

## Example Output

### Valid divisor: `2`

```text
Integer Division with Exception Handling

Numbers to divide: 24, 15, 10, 7
Enter an integer to divide each number by: 2

Dividing each number by 2:
24 / 2 = 12
15 / 2 = 7.5
10 / 2 = 5
7 / 2 = 3.5

The application continued running after exception handling.
```

### Zero divisor: `0`

```text
Integer Division with Exception Handling

Numbers to divide: 24, 15, 10, 7
Enter an integer to divide each number by: 0

Dividing each number by 0:
Error: The divisor cannot be zero. Please enter a non-zero integer.

The application continued running after exception handling.
```

### Text input: `hello`

```text
Integer Division with Exception Handling

Numbers to divide: 24, 15, 10, 7
Enter an integer to divide each number by: hello
Error: Your input was not a valid integer. Please enter digits such as 2 or -2.

The application continued running after exception handling.
```

## Author

Correia2911

## Suggested Repository Name

`integer-division-exceptions-csharp`

See the GitHub upload instructions below for publishing the project as its own
repository.

## GitHub Upload Instructions

Create an empty GitHub repository named `integer-division-exceptions-csharp`.
For a standalone repository, copy this project folder to a location outside any
existing Git repository, then run these PowerShell commands from that copied
folder. Replace the remote URL if you use a different GitHub account or
repository name.

```powershell
git init
git add .
git commit -m "Complete integer division exception handling assignment"
git branch -M main
git remote add origin https://github.com/Correia2911/integer-division-exceptions-csharp.git
git push -u origin main
```

If you intend to add the project to an existing repository, do not run `git init`
inside this project folder. Instead, run `git add .\IntegerDivisionExceptions\`
from the existing repository root, then commit and push using that repository's
configured remote.
