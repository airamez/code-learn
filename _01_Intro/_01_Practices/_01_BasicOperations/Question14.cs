using System;

namespace BasicOperationsPractices;

public class Question14
{
    public static void Run ()
    {
        /*
         * 14. Read the duration of an experiment in seconds and 
         *     calculate the duration in Hours, Minutes and Seconds.
        */
        Console.Write("Duration in seconds: ");
        int duration = int.Parse(Console.ReadLine()!);
        
        int hours = duration / (60 * 60);
        int left = duration % (60 * 60);
        int minutes = left / 60;
        int seconds = left % 60;

        Console.WriteLine($"{hours} hours; {minutes} minutes; {seconds} seconds");
        Console.WriteLine($"{hours}:{minutes}:{seconds}");
        Console.WriteLine($"Hours: {hours}; Minutes: {minutes}; Seconds: {seconds}");
    }   
}