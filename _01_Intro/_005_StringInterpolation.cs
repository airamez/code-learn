using System;

public class StringInterpolation
{
    public static void Run ()
    {
        string firstName = "Jose";
        string lastName = "Santos";

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        Console.WriteLine(firstName + lastName);
        Console.WriteLine(firstName + " " + lastName);

        string email = "jose@noemail.com";
        Console.WriteLine(firstName + " " + lastName + " " + email);
        Console.WriteLine("[" + firstName + " " + lastName + "]" + "[" + email + "]" );

        // String Interpolation
        Console.WriteLine("[ firstName lastName ] [ email]");
        Console.WriteLine($"[ {firstName} {lastName} ] [ {email} ]");
        Console.WriteLine($"Full Name = {firstName} {lastName}; Email = {email} ]");
        // Without String Interpolation
        Console.WriteLine("Full Name = " + firstName + " " +  lastName + "; Email = " + email + "]");

        decimal salary = 7651.51234m;
        Console.WriteLine($"Full Name = {firstName} {lastName}; Salary = {salary}");
        Console.WriteLine($"Full Name = {firstName} {lastName}; Salary = {salary:N2}");

        // String Interpolation Formatting Examples
        Console.WriteLine("\n--- Number Formatting ---");
        Console.WriteLine($"N2 Format (2 decimals): {salary:N2}");
        Console.WriteLine($"C2 Format (Currency): {salary:C2}");
        Console.WriteLine($"N0 Format (No decimals): {salary:N0}");
        
        Console.WriteLine("\n--- Percentage Formatting ---");
        double percentage = 0.85;
        Console.WriteLine($"Percentage: {percentage:P}");
        Console.WriteLine($"Percentage 2 decimals: {percentage:P2}");
        
        Console.WriteLine("\n--- Date Formatting ---");
        DateTime today = DateTime.Now;
        Console.WriteLine($"Default Date: {today}");
        Console.WriteLine($"Short Date: {today:d}");
        Console.WriteLine($"Long Date: {today:D}");
        Console.WriteLine($"Date with Time: {today:g}");
        
        Console.WriteLine("\n--- Alignment and Padding ---");
        Console.WriteLine($"Left aligned (10 chars):  '{firstName,-10}'");
        Console.WriteLine($"Right aligned (10 chars): '{firstName,10}'");
        
        Console.WriteLine("\n--- Hexadecimal Formatting ---");
        int number = 255;
        Console.WriteLine($"Decimal: {number}");
        Console.WriteLine($"Hexadecimal: {number:X}");
        Console.WriteLine($"Hexadecimal lowercase: {number:x}");
    }
}