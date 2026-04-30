using System;

public class ComparisonOperations
{
    public static void Run ()
    {
        /*
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators
         * < > <= >=

         */ 
        
        Console.Write("Number 1: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Number 2: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"number1 > number2: {number1 > number2} ");
        Console.WriteLine($"number1 >= number2: {number1 >= number2} ");
        Console.WriteLine($"number1 < number2: {number1 < number2} ");
        Console.WriteLine($"number1 <= number2: {number1 <= number2} ");
    }
}