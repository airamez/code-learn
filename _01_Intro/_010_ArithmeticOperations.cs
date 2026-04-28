using System;

/*
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
 * Note: Talk about Operation Priority
 */

public class ArithmeticOperations {
    public static void Run ()
    {
        Console.Write("Number 1 = ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Number 2 = ");
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {sum}");

        int diff = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {diff}");

        int mult = number1 * number2;
        Console.WriteLine($"{number1} * {number2} = {mult}");

        int div = number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {div}");

        int reminder = number1 % number2;
        Console.WriteLine($"{number1} % {number2} = {reminder}");

        // For decimal division one of the operands must the of a decimals type
        decimal decimalDiv = (decimal) number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {decimalDiv}");

        int number1Negative = -number1;
        Console.WriteLine($"Number 1 negative = {number1Negative}");

        // Increment: ++ --
        int i = 0;
        Console.WriteLine($"i = {i++}");
        Console.WriteLine($"i = {i}");

        Console.WriteLine($"i = {++i}");
        Console.WriteLine($"i = {i}");

        int j = i++;
        Console.WriteLine($"i = {i}; j = {j}");

        // Compound assignment *=, /=, +=, and -= operators 
        i += 5;  // i = i + 5
        Console.WriteLine($"i = {i}");

        i -= 2;  // i = i + 2
        Console.WriteLine($"i = {i}");

        Console.Write("Number 3 = ");
        int number3 = int.Parse(Console.ReadLine());

        decimal average = (decimal) (number1 + number2 + number3) / 3;

        Console.WriteLine($"The average of {number1}, {number2}, {number3} is {average:N4}");


    }
}