using System;

namespace BasicOperationsPractices;

public class Question07
{
    public static void Run ()
    {
        // 07. Read two integer numbers A and B and print True if A is divisible to B and False otherwise
        Console.Write("Number A = ");
        int numberA = int.Parse(Console.ReadLine()!);

        Console.Write("Number B = ");
        int numberB = int.Parse(Console.ReadLine()!);

        Console.WriteLine(numberA % numberB == 0);
    }   
}