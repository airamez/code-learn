using System;

namespace BasicOperationsPractices;

public class Question12
{
    public static void Run ()
    {
        /*
        12. Read the name, salary, years of experience and the numbers of kids of a employee and
            calculate the name and the new salary using the following formula: 
            - 0.5% per year of experience
            - 2% per kid
         */
         Console.Write("Name: ");
         string name = Console.ReadLine()!;
         Console.Write("Salary: ");
         decimal salary = decimal.Parse(Console.ReadLine()!);
         Console.Write("Years of experience: ");
         int years = int.Parse(Console.ReadLine()!);
         Console.Write("Number of kids: ");
         int kids = int.Parse(Console.ReadLine()!);

         decimal percentFromExperience = 0.5m * years; // percent
         decimal percentFromKids = 2m * kids; // percent
         decimal totalPercent = percentFromExperience + percentFromKids;

         decimal salaryRaise = salary * totalPercent / 100m;
         decimal newSalary = salary + salaryRaise;

        Console.WriteLine($"{name} - new Salary: {newSalary:N2}");
    }   
}