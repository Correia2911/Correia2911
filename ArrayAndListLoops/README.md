# Array and List Loops

## Project Overview

This beginner-friendly C# console application demonstrates loops, arrays,
`List<string>` collections, searching, duplicate detection, and the difference
between the `<` and `<=` comparison operators. It is organized into six labeled
assignment parts and uses explanatory comments throughout the source code.

## Assignment Objectives

1. Append user-provided text to each item in a one-dimensional string array and
   display the updated items.
2. Show an infinite-loop example in comments only, explain why it would never
   end, and run a corrected loop that terminates.
3. Demonstrate and compare loops that use `<` and `<=`.
4. Search a list of unique values, report the first match's zero-based index,
   and stop searching with `break`.
5. Search a list containing repeated values, report every matching index, and
   continue searching without `break`.
6. Use a `foreach` loop and a second collection to label each value as unique
   (its first occurrence) or duplicate (a value encountered earlier).

## Technologies Used

- C#
- .NET 10 Console Application
- `System.Collections.Generic` collections (`List<string>` and `HashSet<string>`)

## Skills Demonstrated

- Declaring and updating a one-dimensional array
- Reading console input and appending strings
- Writing `for` and `foreach` loops
- Understanding loop conditions, counters, and termination
- Comparing `<` with `<=`
- Searching lists and reporting zero-based indexes
- Using `break` to stop after the first match
- Searching all matches by allowing a loop to continue
- Tracking previously seen values with a `HashSet<string>`
- Explaining code with clear comments

## How To Run

### From a terminal

Install the .NET 10 SDK, open a terminal in this project folder, and run:

```powershell
dotnet run --project .\ArrayAndListLoops.csproj
```

Or, from the repository root, run:

```powershell
dotnet run --project .\ArrayAndListLoops\ArrayAndListLoops.csproj
```

The program asks for text to append, then asks for one item to find in each
search exercise. For the unique-items list, try `Apple`, `Banana`, `Cherry`, or
`Date`. For all duplicate matches, try `Blue`, `Green`, or `Red`.

### In Visual Studio

Open `ArrayAndListLoops.csproj` in Visual Studio and run the console project
with **Ctrl+F5** or **Debug > Start Without Debugging**.

## Expected Output

The exact output depends on the text and search values entered. The loop
comparison section displays:

```text
Loop using < (the value 4 is not included):
1
2
3
Loop using <= (the value 4 is included):
1
2
3
4
```

For example, searching for `Blue` in Part 5 reports indexes `0`, `2`, and `5`.
Part 6 labels the first `Red`, `Blue`, `Green`, and `Yellow` as unique, and later
occurrences of `Red` and `Blue` as duplicates.

## Author

Correia2911

## Recommended Repository Name

`array-and-list-loops-csharp`

## Recommended Commit Messages

- Part 1: `Add string array append and display loops`
- Part 2: `Demonstrate and correct an infinite loop`
- Part 3: `Compare less-than and less-than-or-equal loops`
- Part 4: `Find the first match in a unique list`
- Part 5: `Display every matching index in a duplicate list`
- Part 6: `Track unique and duplicate values with a set`
- Final submission: `Complete array and list loops assignment`

## GitHub Setup Commands

These commands are for publishing this project as its own GitHub repository.
Run them from this project directory after creating an empty GitHub repository
named `array-and-list-loops-csharp`. If the remote repository has a different
owner or name, replace the URL with the URL GitHub provides for that repository.

```powershell
git init
git add .
git commit -m "Complete array and list loops assignment"
git branch -M main
git remote add origin https://github.com/Correia2911/array-and-list-loops-csharp.git
git push -u origin main
```

If you are adding this project to an existing Git repository instead, run Git
commands from that existing repository's root and stage this project folder.
Do not run `git init` inside this project folder in that case, because it would
create a nested repository.
