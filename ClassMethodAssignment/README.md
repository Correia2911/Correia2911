# Class Method Assignment: Divide by Two

## Project Overview

This beginner-friendly C# console application asks the user for an integer,
then uses an instance method to divide it by two and display the integer
quotient. It also demonstrates a method with output parameters, an overloaded
method, and a static class.

## Concepts Being Tested

- **Class and object:** `DivisionOperations` is instantiated in `Main()` so its
  instance methods can be called.
- **Void method:** `DivideByTwo(int number)` performs a calculation and displays
  the result without returning a value.
- **Integer division:** Dividing an `int` by `2` produces a whole-number
  quotient. Any fractional part is discarded.
- **Output parameters:** The overloaded method assigns a quotient and remainder
  to `out` parameters so the caller can use both results.
- **Method overloading:** Both methods are named `DivideByTwo`, but their
  parameter lists differ.
- **Static class:** `AssignmentMessages` is called by its class name and does
  not need an object instance.
- **Input validation:** `int.TryParse` lets the user correct invalid input
  instead of causing a conversion error.

## Simple Steps

1. `Main()` calls a static helper to display the title.
2. `Main()` creates a `DivisionOperations` object.
3. The application asks the user for a whole number and repeats the prompt
   until the input can be parsed as an `int`.
4. `DivideByTwo(number)` calculates and displays the integer quotient.
5. The overloaded `DivideByTwo(number, out quotient, out remainder)` assigns
   both output values to variables in `Main()`.
6. `Main()` displays those output values.

## How The Overload and Output Parameters Work

The first method has one parameter:

```csharp
public void DivideByTwo(int number)
```

The second method has three parameters, two of which use the `out` keyword:

```csharp
public void DivideByTwo(int number, out int quotient, out int remainder)
```

Because their parameter lists differ, C# treats them as overloads. The
overloaded method must assign a value to each `out` parameter before it
finishes. Its caller declares variables to receive those assigned values.

For example, with input `9`, integer division produces quotient `4` and
remainder `1`. This is because `9 / 2` using integers discards the fractional
part, while `9 % 2` calculates the remainder.

## How To Run

### Visual Studio

1. Open `ClassMethodAssignment.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\ClassMethodAssignment.csproj
```

## Example Output

```text
Class Method Assignment: Divide by Two

Enter a whole number: 9

Division method:
9 divided by 2 is 4.

Overloaded method with output parameters:
Integer quotient: 4
Remainder: 1

The quotient and remainder together describe the integer division.
```

## Assessor Checklist

- A class has a `void` method that accepts an integer, divides it by 2, and
  outputs the integer result: included.
- `Main()` instantiates that class: included.
- The user enters an integer and the method is called with it: included.
- A method uses output parameters: included.
- A method is overloaded with a different parameter list: included.
- A class is declared `static` and used without instantiation: included.
- Comments explain each significant line and code block: included.

## Common Mistakes

- A `void` method displays its result; it does not return a result to the caller.
- Every `out` parameter must be assigned inside the method before the method
  returns.
- Overloads need different parameter lists; changing only the method body or
  return type is not enough.
- Static classes cannot be instantiated. Call their static methods using the
  class name.
- Integer division truncates toward zero: for example, `9 / 2` is `4`, not
  `4.5`. The remainder is available from `%`.
- The `out` keyword must appear in both the method declaration and the call.

## Suggested Git Commit Message

`Add class method division assignment`
