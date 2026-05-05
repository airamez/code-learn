using System;
namespace BasicOperationsPractices;

public class Question5
{
    public static void Run()
    {
        // 05. Read the base and length of a rectangle and calculate its area.
        
        Console.Write("Base: ");
        decimal rectangleBase = decimal.Parse(Console.ReadLine());

        Console.Write("Length: ");
        decimal rectangleLength = decimal.Parse(Console.ReadLine());

        decimal area = rectangleBase * rectangleLength;

        Console.WriteLine($"Base = {rectangleBase}; Length = {rectangleLength}; Area = {area}");
    }
}