# Struct Assignment

## Project Overview

This beginner-friendly C# console application demonstrates a struct named
`Number` with a decimal `Amount` property. `Main()` creates a `Number` value,
assigns an amount, and prints it to the console.

## Concepts Demonstrated

- **Struct:** A value type that groups related data.
- **Property:** `Amount` stores and provides access to the number's decimal
  amount.
- **Decimal type:** The `decimal` type is appropriate for values that need
  decimal precision, such as currency-like amounts.
- **Object initializer:** The `Amount` property is assigned while creating the
  `Number` value.
- **Console output:** `Console.WriteLine` displays the assigned amount.

## How To Run

### Visual Studio

1. Open `StructAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\StructAssignment.csproj
```

## Expected Output

```text
Amount: 123.45
```

## Assessor Checklist

- A struct named `Number` is declared: included.
- `Number` has a decimal property named `Amount`: included.
- `Main()` creates a `Number` value and assigns an amount: included.
- The amount is printed to the console: included.
- Comments explain each significant line and code block: included.

## Suggested Git Commit Message

`Add decimal Number struct assignment`
