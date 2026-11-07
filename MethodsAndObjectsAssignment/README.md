# Methods and Objects Assignment

## Project Overview

This beginner-friendly C# console application demonstrates classes, properties,
object initialization, inheritance, and calling an inherited method. It defines
a `Person` superclass and an `Employee` subclass, then creates a sample employee
and displays the employee's full name.

## Assignment Requirements

- `Person` has string properties named `FirstName` and `LastName`.
- `Person.SayName()` is a `void` method with no parameters and displays the full
  name as `Name: [full name]`.
- `Employee` inherits from `Person` and has an integer `Id` property.
- `Main()` initializes an `Employee` with first name `Sample` and last name
  `Student`.
- The program calls the inherited `SayName()` method on the `Employee` object.
- Comments explain each significant line and code block.

## Concepts Demonstrated

- **Class:** A definition for an object and its members.
- **Properties:** `FirstName`, `LastName`, and `Id` store object data.
- **Object initialization:** An object initializer sets property values as the
  `Employee` object is created.
- **Inheritance:** `Employee : Person` means an employee is also a person and
  inherits the `Person` members.
- **Inherited method:** `employee.SayName()` calls the method declared by
  `Person` through an `Employee` instance.
- **Void method:** `SayName()` performs an action and does not return a value.

## How To Run

### Visual Studio

1. Open `MethodsAndObjectsAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\MethodsAndObjectsAssignment.csproj
```

## Expected Output

```text
Name: Sample Student
```

## Suggested Git Commit Message

`Add methods and objects inheritance assignment`
