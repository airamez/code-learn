using System;

namespace BasicOperationsPractices;

public class Question10
{
    public static void Run ()
    {
        /*
         * 10. Read the buying price (cost), the desired profit percentage and the sales tax % and
         *     calculate the final sales price of a product.
         */
        Console.Write("Buying price (cost): ");
        decimal cost = decimal.Parse(Console.ReadLine()!);

        Console.Write("Desired profit %: ");
        decimal profitPercentage = decimal.Parse(Console.ReadLine()!);

        Console.Write("Sales tax %: ");
        decimal salesTaxPercentage = decimal.Parse(Console.ReadLine()!);
        
        /*
         * Method 1
         */
        decimal profit = cost * profitPercentage / 100;
        decimal salesTax = profit * salesTaxPercentage / 100;
        decimal totalPriceBeforeTax = cost + profit;
        decimal salesPrice = totalPriceBeforeTax + salesTax;
        Console.WriteLine($"Cost: {cost}");
        Console.WriteLine($"Profit Percentate: {profitPercentage}%");
        Console.WriteLine($"Profit: {profit:N2}");
        Console.WriteLine($"Sales Tax % = {salesTaxPercentage}");
        Console.WriteLine($"Sales Tax: {salesTax}");
        Console.WriteLine($"Sales Price: {salesPrice:N2}");

        /*
         * Method 2: Correct USA sales tax calculation (tax applied to total sale price, not just profit)
         */
        decimal correctProfit = cost * profitPercentage / 100;
        decimal correctTotalPriceBeforeTax = cost + correctProfit;
        decimal correctSalesTax = correctTotalPriceBeforeTax * salesTaxPercentage / 100;
        decimal correctSalesPrice = correctTotalPriceBeforeTax + correctSalesTax;
        Console.WriteLine("\n--- Corrected Calculation ---");
        Console.WriteLine($"Cost: {cost}");
        Console.WriteLine($"Profit Percentage: {profitPercentage}%");
        Console.WriteLine($"Profit: {correctProfit:N2}");
        Console.WriteLine($"Sales Tax % = {salesTaxPercentage}");
        Console.WriteLine($"Sales Tax (on total price): {correctSalesTax:N2}");
        Console.WriteLine($"Sales Price: {correctSalesPrice:N2}");
    }
}