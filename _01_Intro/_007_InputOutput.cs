using System;

public class InputOutput
{
    public static void Run()
    {
        Console.WriteLine("Hello to Input/Output");

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Hello {firstName} {lastName}, Nice to meet you!");
    }
}