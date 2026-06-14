using System;
namespace SelectionPractices;

public class Question03
{
    public static void Run()
    {
        /*
         * 03. Read 3 integers and print the highest value.
         */
        Console.Write("Number 1: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        int number2 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 3: ");
        int number3 = int.Parse(Console.ReadLine()!);

        // Method 1
        if (number1 >= number2 && number1 >= number3)
        {
            Console.WriteLine(number1);
        } else if (number2 >= number1 && number2 >= number3)
        {
            Console.WriteLine(number2);
        } else
        {
            Console.WriteLine(number3);
        }

        // Method 2
        int max1 = Math.Max(number1, Math.Max(number2, number3));
        Console.WriteLine(max1);

        // Method 3
        int max2 = Math.Max(number1, number2);
        max2 = Math.Max(max2, number3);
        Console.WriteLine(max2);

    }
}