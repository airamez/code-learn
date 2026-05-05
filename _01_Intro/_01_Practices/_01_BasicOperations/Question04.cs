using System;
namespace BasicOperationsPractices;

public class Question4
{
    public static void Run()
    {
        // 04. Read three integer numbers and calculate the average.

        // Input
        Console.Write("Enter the number 1: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the number 2: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the number 3: ");
        int number3 = int.Parse(Console.ReadLine());

        // Processing
        decimal average = (number1 + number2 + number3) / 3m;

        // Ouput
        Console.WriteLine($"The average is {average:N2}");

    }
}