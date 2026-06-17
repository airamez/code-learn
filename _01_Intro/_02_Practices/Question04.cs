using System;
namespace SelectionPractices;

public class Question04
{
    public static void Run()
    {
        //04. Read 5 integer numbers and print the biggest one.

        Console.Write("Number 1: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        int n2 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 3: ");
        int n3 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 4: ");
        int n4 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 5: ");
        int n5 = int.Parse(Console.ReadLine()!);

        /*
         * Method 1: Using nested if-else
         */

        // Checking if Number1 is the greatest
        if (n1 >= n2 &&
            n1 >= n3 && 
            n1 >= n4 && 
            n1 >= n5)
        {
            Console.WriteLine(n1);
        } // Checking if Number2 is the greatest
        else if (n2 >= n1 &&
                 n2 >= n3 &&
                 n2 >= n4 &&
                 n2 >= n5)
        {
            Console.WriteLine(n2);
        }
        // Checking if Number3 is the greatest
        else if (n3 >= n1 &&
                 n3 >= n2 &&
                 n3 >= n4 &&
                 n3 >= n5)
        {
            Console.WriteLine(n3);
        }
        // Checking if Number4 is the greatest
        else if (n4 >= n1 &&
                 n4 >= n2 &&
                 n4 >= n3 &&
                 n4 >= n5)
        {
            Console.WriteLine(n4);
        }
        // Assuming Number5 is the greatest
        else {
            Console.WriteLine(n5);
        }

        /*
         * Method 2: Using Math.Max
         */

        int max = Math.Max(n1, n2);
        max = Math.Max(max, n3);
        max = Math.Max(max, n4);
        max = Math.Max(max, n5);

        Console.WriteLine(max);

        Console.WriteLine("End of the program");
    }
}