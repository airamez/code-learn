using System;

public class Variables
{
    public static void Run()
    {
        Console.WriteLine("Variables");
        /*
         * Variable
           * Declaration: TYPE name (identifier)
           * Assignment: name = value
         */
        string name = "Leila";
        Console.WriteLine(name);

        int age = 54;
        Console.WriteLine(age);

        string firstName = "Jose";
        string lastName = "Santos";

        Console.WriteLine(firstName + " " + lastName);

        int number1 = 10;
        int number2 = 5;
        int number3 = number1 + number2;
        Console.WriteLine(number3);
    }
}