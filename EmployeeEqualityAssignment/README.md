# Employee Equality Assignment

## Project Overview

This beginner-friendly C# console application defines an `Employee` class and
overloads the `==` and `!=` operators. Employees are considered equal when
their `Id` properties match; their names do not affect the comparison.

## Concepts Demonstrated

- **Properties:** `Id`, `FirstName`, and `LastName` store employee information.
- **Operator overloading:** The `==` operator compares two `Employee` objects
  using their IDs.
- **Paired comparison operators:** C# requires `==` and `!=` to be overloaded
  together for a class.
- **Null-safe comparison:** The operators handle identical references and null
  values before comparing IDs.
- **`Equals` and `GetHashCode`:** These methods use the same ID-based equality
  rule, keeping object equality consistent with the overloaded operators.

## How The Program Works

1. `Main()` creates three employees.
2. The first and second employees have different names but the same ID, so
   comparing them with `==` returns `true`.
3. The third employee has a different ID, so `==` returns `false` when compared
   with the first employee.
4. The `!=` example demonstrates the paired operator.

## How To Run

### Visual Studio

1. Open `EmployeeEqualityAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\EmployeeEqualityAssignment.csproj
```

## Expected Output

```text
Do Alex and Jordan have the same ID? True
Do Alex and Taylor have the same ID? False
Are Alex and Taylor different employees? True
```

## Assessor Checklist

- `Employee` has `Id`, `FirstName`, and `LastName` properties: included.
- `==` compares two employees by `Id`: included.
- `!=` is overloaded as the required paired operator: included.
- Comments explain each significant line and code block: included.

## Common Mistakes

- Overload `==` and `!=` together.
- Compare `Id` rather than names, as requested.
- Handle null references before accessing an object's properties.
- Override `Equals` and `GetHashCode` consistently when defining value-based
  equality for a class.

## Suggested Git Commit Message

`Add employee equality operator assignment`
