using System;

namespace SelectionPractices;

public class Question08
{
    public static void Run ()
    {
        /*
         * 08. Read an age and print "Minor" if the age is smaller than 18 and 
         *     "ADULT" otherwise
         */

        Console.Write("What is your Age: ");
        int age = int.Parse(Console.ReadLine()!);

        if (age <= 0)
        {
            Console.WriteLine("Invalid age. Age has to be a positive value");
        } else
        {
            if (age < 18)
            {
                Console.WriteLine("Your are a Minor!");
            } else
            {
                Console.WriteLine("Your are a ADULT!");
            }
        }
    }   
}