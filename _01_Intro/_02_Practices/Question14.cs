using System;

namespace SelectionPractices;

public class Question14
{
    public static void Run ()
    {
        // 14. Read an age and print the age classification using the table below
        //     - unborn      = 0
        //     - Infant:     < 1
        //     - Child:      1 to 12 years
        //     - Adolescent: 13 to 17
        //     - Adult:      18 to 55
        //     - Senior:     56 to 75
        //     - Elderly:    76+

        Console.Write("Age: ");
        decimal age = decimal.Parse(Console.ReadLine()!);

        if (age < 0)
        {
            Console.WriteLine("Invalid Age: Age has to a non-negative number");
        } else if (age == 0)
        {
            Console.WriteLine("Unborn");
        } else if (age < 1)
        {
            Console.WriteLine("Infant");
        } else if (age <= 12)
        {
            Console.WriteLine("Child");
        } else if (age <= 17)
        {
            Console.WriteLine("Adolescent");
        } else if (age <= 55)
        {
            Console.WriteLine("Adult");
        } else if (age <= 75)
        {
            Console.WriteLine("Senior");
        } else
        {
            Console.WriteLine("Elderly");
        }
    }   
}