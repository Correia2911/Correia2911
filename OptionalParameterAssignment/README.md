# Method Assignment: Optional Parameter

## Project Overview

This beginner-friendly C# console application demonstrates an optional method
parameter. It asks for one required integer and gives the user the choice to
enter a second integer or press Enter to skip it. The `MathOperations` class
adds the numbers and returns the integer result.

## Concepts Being Tested

- **Class and object:** `MathOperations` defines the calculation, and `Main`
  creates an instance with `new`.
- **Method parameters:** `AddNumbers` receives integer arguments.
- **Optional parameter:** `secondNumber = 0` supplies a default value when a
  caller leaves out the second argument.
- **Return value:** `AddNumbers` returns the sum as an `int`.
- **Console input:** `Console.ReadLine` reads text from the user.
- **Input conversion:** `int.TryParse` safely converts valid text to an integer.
- **Conditional logic:** `if` checks whether a second number was supplied.

## How The Program Works

1. `Main` creates a `MathOperations` object.
2. The program asks for the required first integer, repeating the prompt until
   the input is valid.
3. The program asks for the optional second integer. A blank line means the user
   has chosen to skip it.
4. If the second integer is supplied, `Main` calls
   `AddNumbers(firstNumber, secondNumber)`.
5. If it is skipped, `Main` calls `AddNumbers(firstNumber)`. C# uses the
   optional parameter's default value of `0`.
6. The method adds the values and returns the result to `Main`.

## How To Run

### Visual Studio

1. Open `OptionalParameterAssignment.csproj` in Visual Studio.
2. Build the project with **Build > Build Solution**.
3. Run it with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\OptionalParameterAssignment.csproj
```

## Example Runs

### Providing both numbers

```text
Enter the first required whole number: 10
Enter a second whole number, or press Enter to skip it: 5

10 + 5 = 15

The calculation is complete.
```

### Skipping the optional number

```text
Enter the first required whole number: 10
Enter a second whole number, or press Enter to skip it:

No second number was entered, so 10 + 0 = 10

The calculation is complete.
```

## Requirement Review

- Separate `MathOperations` class: included in `MathOperations.cs`.
- Method with two integer parameters, one optional: `AddNumbers(int firstNumber, int secondNumber = 0)`.
- Performs a math operation and returns an integer: adds and returns the sum.
- `Main` instantiates the class: included.
- Prompts for one required and one optional integer: included.
- Calls with both values or omits the optional value as appropriate: included.
- Comments explain the code's sections and decisions: included.
- Input is validated so non-integer text does not crash the program: included.

## Common Mistakes

- An optional parameter must have a default value, such as `secondNumber = 0`.
- Optional parameters must come after required parameters in the method signature.
- The caller can omit the optional argument, but must provide the required one.
- `Console.ReadLine` returns text, so input must be converted before it can be
  used in integer arithmetic.
- A blank line from the user means the optional value is omitted; it is
  different from entering `0`, even though both produce the same sum here.

## Suggested Git Commit Message

`Add optional parameter method assignment`
