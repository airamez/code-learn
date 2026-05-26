using System;

namespace BasicOperationsPractices;

public class Question06
{
    public static void Run ()
    {
        // 06. Read an integer and print True if the number is Even and False if it is Odd.
        Console.Write("Number = ");
        int number = int.Parse(Console.ReadLine()!);

        Console.WriteLine(number);
        Console.WriteLine(number % 2 == 0);
        Console.WriteLine(number % 2 != 1);
    }   
}