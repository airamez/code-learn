using System;

namespace BasicOperationsPractices; //ATTENTION: Explain Namespaces

public class Question1
{
    public static void Run()
    {
        // 01. Read a value in miles and convert to kilometers: 1 Mile = 1.60934KM.
        Console.Write("Distance in miles: ");
        decimal miles = decimal.Parse(Console.ReadLine());
        decimal kilometers = miles * 1.60934m;
        Console.WriteLine($"{miles} miles is equals to {kilometers}KM");
    }
}