using System;
namespace BasicOperationsPractices;

public class Question3
{
    public static void Run()
    {
        // 03. Read two integer numbers A and B and print the result of all arithmetic operations you know for A and B.

        /*
         * INPUT
         */
        Console.Write("Enter the number A: ");
        int numberA = int.Parse(Console.ReadLine());

        Console.Write("Enter the number B: ");
        int numberB = int.Parse(Console.ReadLine());

        /*
         * Processing
         */
        int addition = numberA + numberB;
        int subtration = numberA - numberB;
        int multiplication = numberA * numberB;
        int integerDivision = numberA / numberB;
        decimal decimalDivision = (decimal)numberA / numberB;
        int mod = numberA % numberB;

        /*
         * Output
         */
        Console.WriteLine($"A + B = {addition}");
        Console.WriteLine($"A - B = {subtration}");
        Console.WriteLine($"A * B = {multiplication}");
        Console.WriteLine($"A / B = {integerDivision}");
        Console.WriteLine($"A % B = {mod}");
        Console.WriteLine($"A / B = {decimalDivision}");
    }
}