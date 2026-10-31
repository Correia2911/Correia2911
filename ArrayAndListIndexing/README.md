# Array and List Indexing

## Assignment requirements

This console application meets the assignment requirements by:

1. Creating a one-dimensional array of strings and displaying the string at a user-selected index.
2. Creating a one-dimensional array of integers and displaying the integer at a user-selected index.
3. Displaying an explanation when a selected numeric index does not exist, then asking again.
4. Creating a `List<string>` and displaying the string at a user-selected list index.
5. Commenting the code's declarations, decisions, input, and output so another developer can follow it.
6. Validating input so text, negative numbers, indexes that are too large, and end-of-input do not crash the application.

## C# concepts demonstrated

- **One-dimensional arrays:** `string[]` and `int[]` store ordered values of a fixed size.
- **Generic lists:** `List<string>` stores an ordered collection that can grow or shrink.
- **Zero-based indexing:** The first item is at index `0`; the last valid index is the collection's size minus one.
- **Input and output:** `Console.WriteLine`, `Console.Write`, and `Console.ReadLine` communicate with the user.
- **Safe parsing:** `int.TryParse` checks user input without throwing an exception for non-numeric text.
- **Conditions and loops:** `if` statements reject invalid input, and a `while` loop asks again.
- **Methods and out parameters:** `TryReadIndex` shares index-validation logic and returns the validated index.
- **Nullable reference types:** `string?` accounts for `Console.ReadLine` returning `null` at end-of-input.

## Line-by-line walkthrough

### Imports, namespace, and entry point

- `using System;` makes console input/output and integer parsing available.
- `using System.Collections.Generic;` makes `List<string>` available.
- `namespace ArrayAndListIndexing` groups the program under a descriptive name.
- `internal class Program` defines the class that contains the application.
- `private static void Main()` is the entry point that runs when the application starts.

### String array

- `string[] names = { "Ada", "Grace", "Katherine" };` creates a one-dimensional array of strings.
- `names.Length` supplies the number of items to the index-validation method.
- `TryReadIndex(...)` prompts until the user supplies a valid index; it returns `false` if input ends.
- The `if` statement returns from `Main` when there is no usable input, rather than trying to access an item.
- `names[nameIndex]` reads and displays the selected string. The index is safe because it was validated first.

### Integer array

- `int[] scores = { 95, 88, 100 };` creates a one-dimensional array of integers.
- The next `TryReadIndex(...)` call checks the user's choice against `scores.Length`.
- `scores[scoreIndex]` displays the integer at the validated index.

### String list

- `new List<string> { "Blue", "Green", "Purple" }` creates a list and fills it with strings.
- `colors.Count` gives the number of list items; unlike an array, a list can change size.
- The final `TryReadIndex(...)` call validates the selected list index.
- `colors[colorIndex]` displays the string at that list index.

### The `TryReadIndex` method

- The method accepts a collection label and item count, and returns success plus the chosen index.
- `index = -1` initializes the `out` parameter to a safe value before any early return.
- The empty-collection check avoids prompting for an index when no index can be valid.
- `while (true)` repeats the prompt until input is valid or the input stream ends.
- `Console.ReadLine()` reads a line; `null` indicates that no more input is available.
- `int.TryParse` rejects non-integer text without throwing an exception.
- `index < 0 || index >= itemCount` detects both negative indexes and indexes past the end.
- `continue` returns to the prompt after an invalid answer.
- `return true` means the index is in range and may safely be used by the caller.

## Build and run

From the repository root, run:

```powershell
dotnet run --project .\ArrayAndListIndexing\ArrayAndListIndexing.csproj
```

For each collection, enter an index from `0` to `2`. Try entering text, `-1`, or `3` to see the validation messages.

## Slightly more advanced improvement

The three selection/display blocks can be consolidated into one generic method that accepts `IReadOnlyList<T>`. Arrays and `List<T>` both implement this interface, so a single method can validate and display items of either type. This reduces repeated code while keeping the same behavior:

```csharp
private static bool DisplayItemAtIndex<T>(IReadOnlyList<T> items, string collectionName)
{
    if (items.Count == 0)
    {
        Console.WriteLine($"The {collectionName} is empty, so it has no valid indexes.");
        return false;
    }

    while (true)
    {
        Console.Write($"Enter an index for the {collectionName} (0-{items.Count - 1}): ");
        string? input = Console.ReadLine();

        if (input is null)
        {
            Console.WriteLine();
            Console.WriteLine("No input was received. The program will now close.");
            return false;
        }

        if (!int.TryParse(input, out int index) || index < 0 || index >= items.Count)
        {
            Console.WriteLine($"That index is invalid. Choose an index from 0 to {items.Count - 1}.");
            continue;
        }

        Console.WriteLine($"Item at index {index}: {items[index]}");
        return true;
    }
}
```

For example, `DisplayItemAtIndex(names, "string array")` and `DisplayItemAtIndex(scores, "integer array")` infer `T` from each collection. This version demonstrates **generics** and **interfaces** while reusing one method for all three collection types.
