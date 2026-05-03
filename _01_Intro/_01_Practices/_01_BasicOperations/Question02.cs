using System;
namespace BasicOperationsPractices;

public class Question2
{
    public static void Run()
    {
        Console.Write("Number:");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{number - 3} {number - 2} {number - 1} {number + 1} {number + 2} {number + 3}");

        int antecessor1 = number - 3;
        int antecessor2 = number - 2;
        int antecessor3 = number - 1;
        int sucessor1 = number + 1;
        int sucessor2 = number + 2;
        int sucessor3 = number + 3;
        Console.WriteLine($"{antecessor1} {antecessor2} {antecessor3} {sucessor1} {sucessor2} {sucessor3}");
    }
}