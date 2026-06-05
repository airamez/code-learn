using System;

namespace BasicOperationsPractices;

public class Question11
{
    public static void Run ()
    {
        /*
         * 11. Read the name, salary and salary increase percentage and 
         *     print the name and the new salary.
         */
         Console.Write("Name: ");
         string name = Console.ReadLine()!;
         Console.Write("Salary: ");
         decimal salary = decimal.Parse(Console.ReadLine()!);
         Console.Write("Salary increase %: ");
         decimal salaryIncreasePercentage = decimal.Parse(Console.ReadLine()!);

         decimal salaryRaise = salary * salaryIncreasePercentage / 100;
         decimal newSalary = salary + salaryRaise;

        Console.WriteLine($"{name} - new Salary: {newSalary:N2}");
    }   
}