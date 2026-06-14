using System;
namespace SelectionPractices;

public class Question02
{
    public static void Run()
    {
        /*
          02. Read two integers numbers and print the one with highest value.
              If the values are equal, print "EQUALS".
         */
        Console.Write("Number 1: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        int number2 = int.Parse(Console.ReadLine()!);

        if (number1 == number2) {
            Console.WriteLine("EQUALS");
        } else if (number1 > number2) {
            Console.WriteLine(number1);
        } else {
            Console.WriteLine(number2);
        }
        Console.WriteLine("Programs ends here");
    }
}