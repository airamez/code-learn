using System;

namespace SelectionPractices;

public class Question12
{
    public static void Run ()
    {
        // 12. Read a single digit number and print the description (name).

        // Using nested IFs
        Console.Write("Digit: ");
        int digit = int.Parse(Console.ReadLine()!);

        if (digit == 0) {
            Console.WriteLine("zero");
        } else if (digit == 1)
        {
            Console.WriteLine("one");
        } else if (digit == 2)
        {
            Console.WriteLine("two");
        } else if (digit == 3)
        {
            Console.WriteLine("three");
        } else if (digit == 4)
        {
            Console.WriteLine("four");
        } else if (digit == 5)
        {
            Console.WriteLine("five");
        } else if (digit == 6)
        {
            Console.WriteLine("six");
        } else if (digit == 7)
        {
            Console.WriteLine("seven");
        } else if (digit == 8)
        {
            Console.WriteLine("eight");
        } else if (digit == 9)
        {
            Console.WriteLine("nine");
        } else
        {
            Console.WriteLine("Invalid digit. Digit must be a value from {0..9}");
        }

        // Using swtich command
        
        string text = null;
        switch (digit)
        {
            case 0: text = "Zero";  break;
            case 1: text = "One";   break;
            case 2: text = "Two";   break;
            case 3: text = "Three"; break;
            case 4: text = "Four";  break;
            case 5: text = "Five";  break;
            case 6: text = "Six";   break;
            case 7: text = "Seven"; break;
            case 8: text = "Eight"; break;
            case 9: text = "Nine";  break;
        }
        if (text == null)
        {
            Console.WriteLine($"{digit} is invalid. Digit must be a value from {0..9}");
        } else {
            Console.WriteLine($"[{digit}] = [{text}]");
        }

        // New specs
        // 12. Read a single digit number and print the description (name).
        //     print the digit and the text following the formating [digit] = [text]
        string digitText = null;
        if (digit == 0) {
            digitText = "zero";
        } else if (digit == 1)
        {
           digitText = "one";
        } else if (digit == 2)
        {
            digitText = "two";
        } else if (digit == 3)
        {
            digitText ="three";
        } else if (digit == 4)
        {
            digitText = "four";
        } else if (digit == 5)
        {
           digitText = "five";
        } else if (digit == 6)
        {
            digitText = "six";
        } else if (digit == 7)
        {
           digitText = "seven";
        } else if (digit == 8)
        {
            digitText = "eight";
        } else if (digit == 9)
        {
            digitText = "nine";
        }
        if (digitText == null)
        {
            Console.WriteLine($"{digit} is invalid. Digit must be a value from {0..9}");
        } else {
            Console.WriteLine($"[{digit}] = [{digitText}]");
        }
    }   
}