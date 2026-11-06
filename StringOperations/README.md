# String Operations Demonstration

A beginner-friendly C# console application that combines strings, changes text
to uppercase, and creates a paragraph with `StringBuilder`.

## Requirements

- .NET 10 SDK, or Visual Studio with support for the `net10.0` target

## Create and run the project in Visual Studio

1. Open Visual Studio and select **Create a new project**.
2. Search for and select **Console App** with the C# language.
3. Select **Next**, enter `StringOperations` as the project name, and choose a
   location for the project.
4. Select **Next**, choose a .NET target supported by your Visual Studio
   installation, and select **Create**.
5. Open the generated `Program.cs`, replace its contents with the source code
   in this folder's `Program.cs`, and save the file. The supplied project targets
   .NET 10 and disables implicit usings so the `using` statements are explicit.
6. Select **Build > Build Solution** to compile the program.
7. Select **Debug > Start Without Debugging** or press **Ctrl+F5** to run it.

If you create a project using a different target framework, use that framework
in Visual Studio's project settings or in the project's `.csproj` file.

## Program concepts

- **String concatenation** joins strings. The `+` operator combines
  `firstText`, `secondText`, and `thirdText` into `combinedText`.
- **`ToUpper()`** returns a version of a string with its letters changed to
  uppercase. The original string is not changed; the returned value is stored
  in `uppercaseText`.
- **`StringBuilder`** is a type for assembling or changing text in steps. The
  program creates `paragraph`, adds three sentences with `Append()`, and calls
  `ToString()` to get the completed paragraph.

## Line-by-line program summary

1. `using System;` makes console features such as `Console.WriteLine` available.
2. `using System.Text;` makes the `StringBuilder` class available.
3. The namespace and `Program` class group the code.
4. `Main` is the entry point that runs when the application starts.
5. The first three string variables hold separate text pieces.
6. The `+` operator joins those pieces, and the program prints the result.
7. `ToUpper()` creates an uppercase copy, which the program prints.
8. `new StringBuilder()` creates an object for constructing the paragraph.
9. Three `Append()` calls add one sentence at a time.
10. `ToString()` retrieves the assembled paragraph as a regular string.
11. The final `Console.WriteLine` displays the completed paragraph.

## Sample output

```text
String Operations Demonstration

Three strings combined:
Learning C# is fun!

The combined text in uppercase:
LEARNING C# IS FUN!

Paragraph created with StringBuilder:
C# strings are useful for storing text. StringBuilder can add text efficiently, one piece at a time. When the paragraph is ready, ToString() gives us the finished text.
```

## Create a Git repository and publish to GitHub using Visual Studio

This project is in the existing `Correia2911` repository. To publish this
project with that repository:

1. Open the repository folder or its solution in Visual Studio.
2. Select **Git > Create Git Repository** only if the folder does not already
   have a Git repository. This workspace already has one, so do not initialize
   another repository inside `StringOperations`.
3. Open **Git Changes**. Review the changes and confirm that the
   `StringOperations` project files are listed. Files ignored by `.gitignore`
   (such as generated `bin` and `obj` folders) do not need to be committed.
4. Enter a commit message such as `Add string operations console assignment`,
   then select **Commit All**.
5. If the existing repository has already been published to GitHub, select
   **Push** or **Sync** to upload your commit.
6. If the repository has not yet been published, use **Git > Publish to GitHub**
   (or the Publish option in **Git Changes**), sign in when prompted, choose a
   repository name and visibility, and publish it. This publishes the existing
   repository, including its projects.
7. Open the repository on GitHub. On the **Code** tab, open the
   `StringOperations` folder and verify that `Program.cs`, the `.csproj`, and
   this README are present.
8. Copy the repository URL from the browser's address bar. Submit that URL for
   the assignment. If your instructor asks for a direct project link, provide
   the repository URL followed by `/tree/main/StringOperations` (replace
   `main` if the repository uses a different default branch).

If your instructor requires this assignment to be in a repository by itself,
create a separate project/repository location outside the existing repository,
then use Visual Studio's **Create Git Repository** and **Publish to GitHub**
for that standalone location.
