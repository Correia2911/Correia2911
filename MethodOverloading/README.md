# Method Overloading

## Project Overview

This beginner-friendly C# console application demonstrates method overloading.
The `MathOperations` class declares three public methods named `Calculate`.
Each method accepts a different parameter type (`int`, `decimal`, or `string`),
performs a different calculation, and returns an `int`.

The `Main` method creates a `MathOperations` instance, calls each overload, and
displays the returned results.

## Concepts Being Tested

- **Class:** `MathOperations` groups related calculation methods.
- **Method:** `Calculate` defines an operation that can be called by another
  part of the program.
- **Method overloading:** Multiple methods can share a name when their parameter
  lists differ. Here, the parameter types distinguish the overloads.
- **Parameters and arguments:** A parameter is declared in a method definition;
  an argument is the value supplied in a call.
- **Return value:** Each overload returns an `int` to its caller.
- **Type conversion:** `int.Parse` converts integer text to an integer, and
  `Convert.ToInt32` converts a decimal result to an integer.
- **Object instantiation:** `new MathOperations()` creates the object used to
  call the instance methods.

## Assignment Objectives

1. Define a class named `MathOperations`.
2. Define three methods with the same name, `Calculate`.
3. Give the methods `int`, `decimal`, and `string` parameters respectively.
4. Perform a different operation in each method and return an `int`.
5. Instantiate `MathOperations` in `Main`.
6. Call all three overloads and display each result with `Console.WriteLine`.
7. Comment the code to explain the purpose of its sections.

## Calculations in This Example

| Overload | Argument example | Operation | Returned result |
|---|---:|---|---:|
| `Calculate(int)` | `7` | Add 10 | `17` |
| `Calculate(decimal)` | `6.5m` | Multiply by 2, then convert to `int` | `13` |
| `Calculate(string)` | `"8"` | Parse as an integer, then subtract 3 | `5` |

`Convert.ToInt32` rounds a decimal value to the nearest integer; values exactly
between two integers use midpoint-to-even rounding. The example's decimal
calculation produces `13` exactly, so no rounding is needed.

## How To Run

### Visual Studio

1. Install the .NET 10 SDK and a Visual Studio version that supports .NET 10.
2. Open `MethodOverloading.csproj` in Visual Studio.
3. Select **Build > Build Solution**.
4. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\MethodOverloading.csproj
```

## Expected Output

```text
Method Overloading Demonstration

Integer calculation: 7 + 10 = 17
Decimal calculation: 6.5 multiplied by 2 = 13
String calculation: 8 converted to an integer, then minus 3 = 5

C# chose a Calculate method based on the type of each argument.
```

## Simple Walkthrough

1. `using System;` makes `Console` and `Convert` available.
2. The `MethodOverloading` namespace groups this assignment's classes.
3. `Program.Main` is the application's entry point.
4. `new MathOperations()` creates an object to call the calculation methods.
5. `integerValue`, `decimalValue`, and `textValue` hold the sample arguments.
6. Each call uses the same method name, but the argument type tells C# which
   overload to select.
7. Each returned integer is stored in a result variable and printed.
8. The `MathOperations` class contains the three public `Calculate` overloads:
   - `Calculate(int)` adds 10.
   - `Calculate(decimal)` multiplies by 2 and converts the result to `int`.
   - `Calculate(string)` parses the numeric text and subtracts 3.

## Common Student Mistakes

- **Changing only the return type:** Return type alone does not distinguish
  overloaded methods. Their parameter lists must differ.
- **Using identical parameter types:** Two methods with the same name and same
  parameter types are duplicate signatures and will not compile.
- **Passing the wrong type:** The string overload requires text, such as `"8"`;
  the decimal overload accepts a decimal value, such as `6.5m`.
- **Forgetting the `m` suffix:** In C#, write decimal literals with an `m`
  suffix, such as `6.5m`.
- **Assuming string conversion is automatic:** `int.Parse` is needed to convert
  numeric text into an integer. It throws an exception if the string is not a
  valid integer.
- **Forgetting to use the returned value:** A method call's result should be
  stored or displayed.
- **Confusing overload selection with the method body:** C# selects an overload
  using the argument's compile-time type; the selected method then performs its
  own operation.

## Requirement Review

- `MathOperations` class: included.
- Three `Calculate` methods with different parameter types: included.
- Each method performs a different calculation and returns `int`: included.
- `Main` creates an instance and calls all three overloads: included.
- Each result is displayed with `Console.WriteLine`: included.
- Comments explain the code's sections and key decisions: included.

## Suggested Git Commit Messages

- `Add integer Calculate overload`
- `Add decimal Calculate overload`
- `Add string Calculate overload`
- `Demonstrate method overloading in console app`
- Final submission: `Complete method overloading assignment`
