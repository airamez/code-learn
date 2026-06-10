using System;

namespace BasicOperationsPractices;

public class Question16
{
    public static void Run ()
    {
        // 16. Read an integer number with 6 digits and generate 
        //     a new number with the digits in reverse order

        Console.Write("Number: ");
        int originalNumber = int.Parse(Console.ReadLine()!);

        int digit1 = originalNumber % 10;
        int remaining = originalNumber / 10;

        int digit2 = remaining % 10;
        remaining /= 10;

        int digit3 = remaining % 10;
        remaining /= 10;

        int digit4 = remaining % 10;
        remaining /= 10;

        int digit5 = remaining % 10;
        int digit6 = remaining / 10;

        int reversedNumber = digit1;
        reversedNumber = reversedNumber * 10 + digit2;
        reversedNumber = reversedNumber * 10 + digit3;
        reversedNumber = reversedNumber * 10 + digit4;
        reversedNumber = reversedNumber * 10 + digit5;
        reversedNumber = reversedNumber * 10 + digit6;

        Console.WriteLine($"{digit1}{digit2}{digit3}{digit4}{digit5}{digit6}");
        Console.WriteLine($"{reversedNumber}");
    }   
}