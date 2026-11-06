# Void Method and Named Parameters

## Project Overview

This beginner-friendly C# console application demonstrates calling a `void`
method that accepts two integer parameters. The method doubles its first
parameter and displays its second parameter. `Main()` calls it once with
positional arguments and once with named arguments.

## Concepts Being Tested

- **Class:** `MathOperations` groups the calculation method.
- **Object:** `Main()` creates an instance with `new MathOperations()`.
- **Method parameters:** `firstNumber` and `secondNumber` receive integer values
  from the method call.
- **`void` return type:** The method displays its results but does not return a
  value to its caller.
- **Math operation:** The method multiplies its first integer by 2.
- **Positional arguments:** Values are supplied in the same order as the
  parameters in the method declaration.
- **Named arguments:** Parameter names are included in the call to make it
  clear which value is passed to each parameter.

## How The Program Works

1. `Main()` prints a title.
2. `Main()` creates a `MathOperations` object.
3. The first call passes `5` and `12` positionally.
4. The second call uses `firstNumber: 8` and `secondNumber: 20`.
5. In both calls, `DisplayCalculation` doubles its first argument and displays
   the second argument.

## How To Run

### Visual Studio

1. Open `VoidMethodParameters.csproj` in Visual Studio.
2. Select **Build > Build Solution**.
3. Run with **Debug > Start Without Debugging** or press **Ctrl+F5**.

### .NET CLI

From this project folder, run:

```powershell
dotnet run --project .\VoidMethodParameters.csproj
```

## Expected Output

```text
Void Method and Named Parameters

Call using positional arguments:
5 multiplied by 2 is 10.
The second number is 12.

Call using named arguments:
8 multiplied by 2 is 16.
The second number is 20.
```

## Requirement Review

- A class contains a `void` method with two integer parameters: included.
- The method performs an operation on the first parameter: multiplies it by 2.
- The method displays the second parameter: included.
- `Main()` instantiates the class: included.
- The method is called with two positional arguments: included.
- The method is called again with named arguments: included.
- Comments explain each significant line and code block: included.

## Common Mistakes

- A `void` method does not return a value; use `return` with a value only when
  the method has a non-void return type.
- Method parameters are part of the declaration; arguments are the values in a
  method call.
- Positional arguments must match the declared parameter order.
- Named arguments must use the parameter names declared by the method.
- The method must display the second parameter, not only use the first one.

## Suggested Git Commit Message

`Add void method and named parameter assignment`
