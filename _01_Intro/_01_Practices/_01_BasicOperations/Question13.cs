using System;

namespace BasicOperationsPractices;

public class Question13
{
    public static void Run ()
    {
        // 13. Read two integer numbers and swap the variables content

        Console.Write("Number 1: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        int number2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Number 1: {number1}; Number 2: {number2}");

        int aux = number1;
        number1 = number2;
        number2 = aux;

        Console.WriteLine($"Number 1: {number1}; Number 2: {number2}");

        // AI Solution

        Console.Write("First integer: ");
        int first = int.Parse(Console.ReadLine()!);
        Console.Write("Second integer: ");
        int second = int.Parse(Console.ReadLine()!);

        int temp = first;
        first = second;
        second = temp;

        Console.WriteLine($"After swap: first = {first}, second = {second}");
    }   
}