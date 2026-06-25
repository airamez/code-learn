using System;

namespace SelectionPractices;

public class Question11
{
    public static void Run()
    {
        // 11. Read the current hour (military time: 0 to 23) and print the appropriate salutation:
        //     Good morning
        //     Good Afternoon
        //     Good evening
        //     Good night
        /*
        Typically, the ranges are:
        Good morning: 5-11 (early morning through late morning)
        Good afternoon: 12-16 (noon through mid-afternoon)
        Good evening: 17-20 (late afternoon through evening)
        Good night: 21-4 (night and early morning hours)
        */

        Console.Write("Hour (military time: 0 to 23): ");
        int hour = int.Parse(Console.ReadLine()!);

        if (hour < 0 || hour > 23)
        {
            Console.WriteLine($"Invalid hour: {hour}. The hour has to be a value between 0 and 23 inclusive");
        }
        else
        {
            string salutation;
            if (hour >= 5 && hour <= 11)
            {
                salutation = "Good morning";
            }
            else if (hour >= 12 && hour <= 16)
            {
                salutation ="Good afternoon";
            }
            else if (hour >= 17 && hour <= 20)
            {
                salutation ="Good evening";
            }
            else
            {
                salutation = "Good night";
            }
            Console.WriteLine(salutation);
        }
    }
}