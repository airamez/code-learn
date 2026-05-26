using System;

namespace BasicOperationsPractices;

public class Question08
{
    public static void Run ()
    {
        // 08. Read a temperature in Celsius and convert to Fahrenheit: F = C x 1.8 + 32.

        Console.Write("Temperature in Celsius: ");
        decimal celsius = decimal.Parse(Console.ReadLine()!);

        decimal fahrenheit = celsius * 1.8m + 32;
        
        Console.WriteLine($"{celsius} =in celsius is {fahrenheit:N2} in Fahrenheit");
    }   
}