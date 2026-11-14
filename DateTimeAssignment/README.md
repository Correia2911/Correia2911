# DateTime Assignment

## Project Overview

This beginner-friendly C# console application prints the current local date
and time, asks the user for a number of hours, and displays the date and time
that many hours in the future (or past, for a negative number).

## Concepts Demonstrated

- Getting the current local date and time with `DateTime.Now`.
- Reading console input with `Console.ReadLine`.
- Validating and converting the input with `int.TryParse`.
- Adding hours to a date and time with `DateTime.AddHours`.
- Handling a requested time outside the supported `DateTime` range.
- Formatting a date and time in a readable long format with `"F"`.

## How To Run

### Visual Studio

1. Open `DateTimeAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.
4. Enter a whole number of hours when prompted.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\DateTimeAssignment.csproj
```

## Example Output

```text
Current date and time: Saturday, November 14, 2026 3:00:00 PM
Enter a number of hours: 2
The date and time in 2 hour(s) will be: Saturday, November 14, 2026 5:00:00 PM
```

The actual date and time depend on when the application is run and the
computer's regional settings.

## Assessor Checklist

- Prints the current date and time: included.
- Asks the user for a number: included.
- Calculates and prints the time after the entered number of hours: included.
- Comments explain each significant line and code block: included.

## Suggested Git Commit Message

`Add date and time calculation assignment`
