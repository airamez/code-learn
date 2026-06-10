using System;

namespace BasicOperationsPractices;

public class Question15
{
    public static void Run ()
    {
        // 15. Read an integer number with 6 digits and separate it into two integers with 3 digits each
        
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()!);
        int left = number / 1000;
        int right = number % 1000;
        Console.WriteLine($"{left}  {right}");
    }   
}