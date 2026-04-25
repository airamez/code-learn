using System;

public class TypeConversion
{
    public static void Run()
    {
        string priceAsString = "19.99";

        decimal priceAsDecimal = decimal.Parse(priceAsString);

        decimal priceAsDecimal2 = Convert.ToDecimal(priceAsString);

        Console.WriteLine($"Price as String: ${priceAsString}; Price as Decimal: {priceAsDecimal:C2}");
    }
}