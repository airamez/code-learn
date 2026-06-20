using System;

namespace SelectionPractices;

public class Question10
{
    public static void Run ()
    {
        // 10. Read two numbers, desired operation (+, -, *, /) and 
        // print a string representing the operation with the result
        /*
          Ex1
          Number 1: 5
          Number 2 : 4
          Operation: +
          5 + 4 = 9

          Number 1: 5
          Number 2 : 4
          Operation: *
          5 * 4 = 20

        */

        Console.Write("Number 1: ");
        decimal number1 = decimal.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        decimal number2 = decimal.Parse(Console.ReadLine()!);
        Console.Write("Operation (+, -, *, /): ");
        string operation = Console.ReadLine()!;

        decimal result = 0;

        if (operation == "+" || 
            operation == "-" || 
            operation == "*" || 
            operation == "/")
        {
            if (operation == "+")
            {
                result = number1 + number2;
            } else if (operation == "-")
            {
                result = number1 - number2;
            } else if (operation == "*")
            {
                result = number1 * number2;
            } else {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
            }
            if (operation == "/" && number2 == 0)
            {
                Console.WriteLine("Invalid operation. We can't divide by zero!");
            } else
            {
                Console.WriteLine($"{number1} {operation} {number2} = {result:N4}");
            }
        } else
        {
            Console.WriteLine($"The {operation} operation is invalid");
        }
    }
}