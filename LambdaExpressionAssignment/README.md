# Lambda Expression Assignment

## Project Overview

This beginner-friendly C# console application filters a list of ten employees
in three ways: a `foreach` loop finds employees named Joe, a lambda expression
finds employees named Joe again, and another lambda expression finds employees
whose IDs are greater than 5.

## Concepts Demonstrated

- **Class and properties:** `Employee` stores an ID, first name, and last name.
- **Generic lists:** `List<Employee>` stores and organizes employee objects.
- **`foreach`:** Visits each employee so the program can check its `FirstName`.
- **Lambda expression:** `employee => employee.FirstName == "Joe"` describes a
  condition for an employee.
- **LINQ `Where`:** Returns the items that match a lambda condition.
- **`ToList()`:** Stores the filtered results in a new list.

## How To Run

### Visual Studio

1. Open `LambdaExpressionAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\LambdaExpressionAssignment.csproj
```

## Expected Results

- The foreach search and the first lambda search both return Joe Smith (ID 1)
  and Joe Johnson (ID 3).
- The ID lambda returns employees with IDs 6, 7, 8, 9, and 10.

## Assessor Checklist

- `Employee` has `Id`, `FirstName`, and `LastName` properties: included.
- `Main()` creates a list of at least ten employees: included.
- At least two employees have the first name `Joe`: included.
- A `foreach` loop checks `employee.FirstName` and creates a Joe list: included.
- A lambda expression creates another Joe list: included.
- A lambda expression creates a list of employees with `Id > 5`: included.
- Comments explain each significant line and code block: included.

## Common Mistakes

- Compare the employee object's `FirstName` property, not the employee object
  itself, with the text `"Joe"`.
- Use `employee => ...` as the lambda condition; the arrow separates the
  parameter from the expression.
- Use `>` rather than `>=` when the requirement says IDs greater than 5.
- Add `using System.Linq;` so the `Where` and `ToList` methods are available.

## Suggested Git Commit Message

`Add lambda expression employee assignment`
