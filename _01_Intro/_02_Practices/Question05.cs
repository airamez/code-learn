using System;
namespace SelectionPractices;

public class Question05
{
    public static void Run()
    {
        //05. Read 3 integers and print them in ascending order. (non descending)

        Console.Write("Number 1: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 2: ");
        int n2 = int.Parse(Console.ReadLine()!);
        Console.Write("Number 3: ");
        int n3 = int.Parse(Console.ReadLine()!);

        /*
         * Method 1
         */
        if (n1 <= n2 && n2 <= n3)
        {
            Console.WriteLine($"{n1} {n2} {n3}");
        } else if (n1 <= n3 && n3 <= n2)
        {
            Console.WriteLine($"{n1} {n3} {n2}");
        } else if (n2 <= n1 && n1 <= n3)
        {
            Console.WriteLine($"{n2} {n1} {n3}");
        } else if (n2 <= n3 && n3 <= n1)
        {
            Console.WriteLine($"{n2} {n3} {n1}");
        } else if (n3 <= n1 && n1 <= n2)
        {
            Console.WriteLine($"{n3} {n1} {n2}");
        } else
        {
            Console.WriteLine($"{n3} {n2} {n1}");
        }

        /*
         * Method 2
         */
        if (n1 > n2)
        {
            int aux = n1;
            n1 = n2;
            n2 = aux;
        }
        if (n3 <= n1)
        {
            Console.WriteLine($"{n3} {n1} {n2}");
        } else if (n3 <= n2)
        {
            Console.WriteLine($"{n1} {n3} {n2}");
        } else
        {
            Console.WriteLine($"{n1} {n2} {n3}");
        }
    }
}