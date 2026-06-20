using System;

namespace SelectionPractices;

public class Question07
{
    public static void Run ()
    {
        // 07. Read an age and print "Minor" if the age is smaller than 18

        Console.Write("What is your Age: ");
        int age = int.Parse(Console.ReadLine()!);

        /*
         * Method 1: Junior ;)
         */

        if (age < 18)
        {
            Console.WriteLine("Your are a minor!");
        }

        /*
         * Method 2: Senior+ ;)
         */
        if (age <= 0)
        {
            Console.WriteLine("Invalid age. Age has to be a positive value");
        } else
        {
            if (age < 18)
            {
                Console.WriteLine("Your are a minor!");
            }
        }
    }   
}