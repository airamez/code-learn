using System;

namespace SelectionPractices;

public class Question09
{
    public static void Run ()
    {
        // 09. Read an integer number and print if the number is Even or Odd 

        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number % 2 == 0)
        {
                Console.WriteLine("Even");
        } else
        {
            Console.WriteLine("Odd");
        }
    }   
}