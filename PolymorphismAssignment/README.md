# Polymorphism Assignment

## Project Overview

This beginner-friendly C# console application demonstrates an interface and
polymorphism. The `IQuittable` interface declares a `Quit()` method. The
`Employee` class inherits names from `Person`, implements `IQuittable`, and
provides the method's behavior. In `Main()`, an `Employee` object is referenced
through the `IQuittable` interface and its `Quit()` method is called.

## Concepts Demonstrated

- **Interface:** `IQuittable` defines a method contract without implementing it.
- **Interface implementation:** `Employee` implements `IQuittable` and provides
  the required `Quit()` method.
- **Inheritance:** `Employee` inherits `FirstName` and `LastName` from `Person`.
- **Polymorphism:** An `Employee` instance is stored in a variable of interface
  type `IQuittable`; calling `Quit()` through that reference executes
  `Employee.Quit()`.
- **Object initialization:** The employee's inherited name properties are set
  using an object initializer.

## How To Run

### Visual Studio

1. Open `PolymorphismAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\PolymorphismAssignment.csproj
```

## Expected Output

```text
Sample Student has quit.
```

## Assessor Checklist

- `IQuittable` declares a parameterless `void Quit()` method: included.
- `Employee` implements `IQuittable`: included.
- `Employee` retains its `Person` inheritance and name properties: included.
- An `Employee` object is referenced by an `IQuittable` variable: included.
- `Quit()` is called using the interface reference: included.
- Comments explain each significant line and code block: included.

## Common Mistakes

- Declare the method in the interface without a method body.
- Add `IQuittable` to the employee's base list and implement its required
  `Quit()` method.
- To demonstrate polymorphism, assign the `Employee` instance to an
  `IQuittable` variable and call the method through that variable.
- The implementing method must match the interface method signature, including
  its name, return type, and parameters.

## Suggested Git Commit Message

`Add interface polymorphism assignment`
