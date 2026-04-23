using System;

public class DataTypes
{
    public static void Run ()
    {
        // Integral types: used for whole numbers
        
        // sbyte: 8-bit signed integer, range -128 to 127. Use for small numbers where space is critical.
        sbyte smallSigned = -50;
        Console.WriteLine($"sbyte: {smallSigned}");
        
        // byte: 8-bit unsigned integer, range 0 to 255. Use for small positive numbers, like RGB color values.
        byte smallUnsigned = 200;
        Console.WriteLine($"byte: {smallUnsigned}");
        
        // short: 16-bit signed integer, range -32,768 to 32,767. Use for moderate-sized integers.
        short mediumSigned = -15000;
        Console.WriteLine($"short: {mediumSigned}");
        
        // ushort: 16-bit unsigned integer, range 0 to 65,535. Use for positive moderate-sized integers.
        ushort mediumUnsigned = 45000;
        Console.WriteLine($"ushort: {mediumUnsigned}");
        
        // int: 32-bit signed integer, range -2,147,483,648 to 2,147,483,647. Most common integer type.
        int standardInt = -1000000;
        Console.WriteLine($"int: {standardInt}");
        
        // uint: 32-bit unsigned integer, range 0 to 4,294,967,295. Use when you need large positive numbers.
        uint largeUnsigned = 3000000000;
        Console.WriteLine($"uint: {largeUnsigned}");
        
        // long: 64-bit signed integer, range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. Use for very large numbers.
        long veryLargeSigned = -5000000000000;
        Console.WriteLine($"long: {veryLargeSigned}");
        
        // ulong: 64-bit unsigned integer, range 0 to 18,446,744,073,709,551,615. Use for very large positive numbers.
        ulong veryLargeUnsigned = 15000000000000;
        Console.WriteLine($"ulong: {veryLargeUnsigned}");
        
        // Floating-point types: used for decimal numbers
        
        // float: 32-bit floating-point, precision about 7 digits. Use for scientific calculations where memory is important.
        float singlePrecision = 3.14159f;
        Console.WriteLine($"float: {singlePrecision}");
        
        // double: 64-bit floating-point, precision about 15 digits. Default for floating-point literals.
        double doublePrecision = 3.141592653589793;
        Console.WriteLine($"double: {doublePrecision}");
        
        // decimal: 128-bit decimal, precision about 28-29 digits. Use for financial applications where precision is critical.
        // Decimal constants are denoted with 'm' suffix, e.g., 1.23m
        decimal financialValue = 1234.56m;
        Console.WriteLine($"decimal: {financialValue}");
        
        // Boolean type: represents true or false
        
        // bool: Use for logical operations and flags.
        bool isActive = true;
        bool hasPermission = false;
        Console.WriteLine($"bool isActive: {isActive}, hasPermission: {hasPermission}");
        
        // Character type: represents a single Unicode character
        
        // char: Use for single characters. Literals are in single quotes.
        char letter = 'A';
        char digit = '5';
        char symbol = '$';
        Console.WriteLine($"char: {letter}, {digit}, {symbol}");
        
        // String type: represents a sequence of characters
        
        // string: Use for text. Literals are in double quotes. Strings are immutable.
        string greeting = "Hello, World!";
        string name = "Alice";
        Console.WriteLine($"string: {greeting} My name is {name}");
    }
}