using System;

namespace SelectionPractices;

public class Question06
{
    public static void Run ()
    {
        // 06. Read a integer number and print if it is positive or negative.
        
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()!);

        /*
         * Method 1
         */
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is Positive");
        }

        if (number < 0)
        {
            Console.WriteLine($"The number {number} is Negative");
        }

        /*
         * Method 2
         */
        if (number != 0)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is Positive");
            } else {
                Console.WriteLine($"The number {number} is Negative");
            }

            // if (number < 0)
            // {
            //     Console.WriteLine($"The number {number} is Negative");
            // } else {
            //     Console.WriteLine($"The number {number} is Positive");
            // }
        }
    }   
}