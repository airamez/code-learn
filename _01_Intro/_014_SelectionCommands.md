# Selection Commands

- Selection commands let your program choose what to do next based on a condition.
- In C#, the two main selection commands are `if` and `switch`.
- These commands are also called decision statements because they help the program decide between different paths.
- A selection command checks a condition and then runs code only when that condition is true.
- This lets your program respond to different situations.
- Example: if a number is positive, show one message, otherwise show a different message.
- Selection commands are useful for:
  - making decisions
  - handling different input values
  - running different code paths
  - creating interactive programs

### Command blocks with `{}`

In C#, the code inside `{}` is called a command block. A command block groups one or more commands so they all run when the condition is true.

### Single command without `{}`

If the `if` body has only one command, the braces are optional. This is shorter, but use braces when you have more than one statement.

## `if` statement

The `if` statement is the most common selection command in C#.

Syntax:

```csharp
if (condition)
{
    // command block runs when condition is true
}
```

Example with a block:

```csharp
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0)
{
    Console.WriteLine("The number is positive.");
    Console.WriteLine("This is also inside the same block.");
}
```

### Single command without `{}`

If the `if` body has only one command, the braces are optional. This is shorter, but use braces when you have more than one statement.

```csharp
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0)
    Console.WriteLine("The number is positive.");
```

Example with braces again:

```csharp
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0)
{
    Console.WriteLine("The number is positive.");
}
```

Use `else` to run code when the `if` condition is not true.

```csharp
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0)
{
    Console.WriteLine("The number is positive.");
}
else
{
    Console.WriteLine("The number is zero or negative.");
}
```

### `if` / `else if` / `else`

Use `else if` when you need to check more than one possibility.

```csharp
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 0)
{
    Console.WriteLine("Positive number.");
}
else if (number < 0)
{
    Console.WriteLine("Negative number.");
}
else
{
    Console.WriteLine("Zero.");
}
```

This example checks three conditions:
- number greater than 0
- number less than 0
- number equals 0

## `switch` statement

The `switch` statement is a cleaner way to choose between many possible values.

Syntax:

```csharp
switch (variable)
{
    case value1:
        // code for value1
        break;
    case value2:
        // code for value2
        break;
    default:
        // code when no case matches
        break;
}
```

Example:

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Another day");
        break;
}
```

### Why use `switch`?

`switch` is helpful when you have a value that can match many fixed options. It keeps code easier to read than many `else if` statements.

## Tips for beginners

- Use `if` when you need to check conditions like greater than, less than, or whether something is true or false.
- Use `switch` when you want to compare one variable against many constant values.
- Always include `break;` in each `case` block to stop the switch after a match.
- Use `default` to handle any value that does not match a `case`.

## Official references

- `if` statement: https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
- `switch` statement: https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement

## Summary

Selection commands let your code decide what to do. Beginners should start with `if` for simple decisions, then use `switch` when there are many fixed choices. Both are essential for making programs that can react differently depending on the data.