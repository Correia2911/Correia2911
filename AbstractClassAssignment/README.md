# Abstract Class Assignment

## Project Overview

This beginner-friendly C# console application demonstrates an abstract base
class and inheritance. The abstract `Person` class contains first- and
last-name properties and requires derived classes to implement `SayName()`.
`Employee` inherits from `Person`, implements that method, and is instantiated
in `Main()`.

## Concepts Demonstrated

- **Abstract class:** `Person` provides shared data and cannot be instantiated
  directly.
- **Properties:** `FirstName` and `LastName` store a person's name.
- **Inheritance:** `Employee : Person` inherits the name properties and the
  abstract method requirement.
- **Abstract method:** `Person.SayName()` declares behavior without providing
  an implementation.
- **Method override:** `Employee.SayName()` provides the implementation using
  the `override` keyword.
- **Object initialization:** `Main()` sets the inherited properties while
  creating an `Employee`.

## How To Run

### Visual Studio

1. Open `AbstractClassAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\AbstractClassAssignment.csproj
```

## Expected Output

```text
Name: Sample Student
```

## Assessor Checklist

- Abstract class named `Person`: included.
- `Person` has string properties `FirstName` and `LastName`: included.
- `Person` declares `SayName()`: included as an abstract method.
- `Employee` inherits from `Person`: included.
- `Employee` implements `SayName()` with `override`: included.
- `Main()` creates an Employee with `Sample` and `Student` as its names and
  calls `SayName()`: included.
- Comments explain each significant line and code block: included.

## Common Mistakes

- An abstract class cannot be instantiated directly; create an instance of a
  concrete derived class such as `Employee`.
- A derived class must implement inherited abstract methods unless it is also
  declared abstract.
- Use `override` to implement a base class abstract method.
- The names and parameter list of the overridden method must match its
  declaration in the base class.
- C# naming convention uses PascalCase for properties and methods, such as
  `FirstName` and `SayName`.

## Suggested Git Commit Message

`Add abstract class assignment`
