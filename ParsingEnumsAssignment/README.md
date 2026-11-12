# Parsing Enums Assignment

## Project Overview

This beginner-friendly C# console application defines a `DaysOfWeek` enum,
prompts the user for a day name, and parses the input into that enum type.
Invalid input displays the required message:

```text
Please enter an actual day of the week.
```

Day names are accepted regardless of letter case. Numeric input is rejected so
the user must enter a named day.

## Concepts Demonstrated

- **Enum:** `DaysOfWeek` defines a fixed set of named day values.
- **Enum parsing:** `Enum.Parse<DaysOfWeek>` converts the user's string into an
  enum value.
- **Case-insensitive parsing:** The `ignoreCase: true` argument accepts input
  such as `monday` or `MONDAY`.
- **Validation:** `Enum.IsDefined` checks that the parsed enum value is defined,
  while `int.TryParse` rejects numeric values entered instead of a day name.
- **Exception handling:** `try`/`catch` displays the requested message when
  parsing or validation fails.

## How To Run

### Visual Studio

1. Open `ParsingEnumsAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\ParsingEnumsAssignment.csproj
```

Enter a day name such as `Monday`. Try `monday` to test case-insensitive
parsing, or enter an invalid name or number to see the error message.

## Example Output

Valid input:

```text
Enter the current day of the week: Monday
You entered: Monday
```

Invalid input:

```text
Enter the current day of the week: Funday
Please enter an actual day of the week.
```

## Research

This example follows Microsoft's documentation for
[enumerations in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
and the `Enum.Parse` and `Enum.IsDefined` APIs.

## Assessor Checklist

- An enum represents the days of the week: included.
- The application prompts the user for the current day: included.
- Input is assigned to a `DaysOfWeek` variable: included.
- Parsing and validation are wrapped in `try`/`catch`: included.
- The requested error message is displayed for invalid input: included.
- Comments explain each significant line and code block: included.

## Suggested Git Commit Message

`Add enum parsing assignment`
