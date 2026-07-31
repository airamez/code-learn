using System;

namespace SelectionPractices;

public class Question13
{
    public static void Run ()
    {
        // 13. Read an letter and print if it is a consonant or vowel

        Console.Write("Letter: ");
        string letter = Console.ReadLine()!;

        // Method 1

        if (letter == "a" || letter == "A" ||
            letter == "e" || letter == "E" ||
            letter == "i" || letter == "I" ||
            letter == "o" || letter == "O" ||
            letter == "u" || letter == "U")
        {
            Console.WriteLine("vowel");
        } else
        {
            Console.WriteLine("Consonant");
        }

        // Method 2
        letter = letter.ToLower();
        if (letter == "a" ||
            letter == "e" ||
            letter == "i" ||
            letter == "o" ||
            letter == "u")
        {
            Console.WriteLine("vowel");
        } else
        {
            Console.WriteLine("Consonant");
        }

        // Method 3
        if (letter.Length == 1 && char.IsLetter(letter[0]))
        {
            char ch = char.ToLower(letter[0]);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
        else
        {
            Console.WriteLine("Not a letter");
        }
    }   
}