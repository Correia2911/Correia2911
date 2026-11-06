# Anonymous Income Comparison and Loop Demonstrations

A beginner C# console application demonstrating Boolean comparisons in `while`
and `do while` loops, followed by an annual income comparison for two people.

## Requirements

- .NET 10 SDK, or Visual Studio with support for the `net10.0` target

The C# source uses basic console features and can also be adapted to a .NET
Framework console project.

## Run

From the repository root, run:

```powershell
dotnet run --project .\AnonymousIncomeComparison\AnonymousIncomeComparison.csproj
```

The loop demonstrations run first. Then enter each person's hourly rate and
hours worked per week when prompted. The program estimates annual income using
52 weeks per year.

## What the loops demonstrate

- A `while` loop checks `whileNumber <= 3` before each repetition. It displays
  1, 2, and 3, then stops when the comparison becomes false.
- A `do while` loop displays its value before checking
  `doWhileNumber <= 3`. The body therefore runs at least once.
- Each comparison produces a Boolean value: either `true` or `false`.
- After the demonstrations, the income comparison evaluates
  `person1AnnualSalary > person2AnnualSalary` and prints the resulting Boolean.

## Example output

```text
WHILE loop boolean comparison
The while loop count is 1.
The while loop count is 2.
The while loop count is 3.

DO WHILE loop boolean comparison
The do while loop count is 1.
The do while loop count is 2.
The do while loop count is 3.

Anonymous Income Comparison Program

Person 1
Hourly Rate?
```

The rest of the output depends on the hourly rates and weekly hours entered.

> This is a practice program. It assumes the entered values are valid numbers
> and does not account for taxes, overtime, or time off.
