using System;

namespace SelectionPractices;

public class Question01
{
    public static void Run()
    {
        /*
        01. Read two integers numbers and print the one with highest value.
            Assume the values are not the same
         */
        Console.Write("Number 1: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        int number2 = int.Parse(Console.ReadLine()!);

        // Option 1
        if (number1 > number2) {
            Console.WriteLine(number1);
        } else {
            Console.WriteLine(number2);
        }

        // Option 2
        if (number1 < number2) {
            Console.WriteLine(number2);
        } else {
            Console.WriteLine(number1);
        }

        // Option 3
        if (number2 > number1) {
            Console.WriteLine(number2);
        } else {
            Console.WriteLine(number1);
        }

        // Option 4
        if (number2 < number1) {
            Console.WriteLine(number1);
        } else {
            Console.WriteLine(number2);
        }

        // Option 5
        Console.WriteLine(Math.Max(number1, number2));

        Console.WriteLine("The program is completed");
    }
}