using System;

namespace BasicOperationsPractices;

public class Question09
{
    public static void Run ()
    {
        /*
         * 09. Read the buying price (cost), the desired profit percentage and
         * calculate the sales price of a product.
        */

        Console.Write("Buying price (cost): ");
        decimal cost = decimal.Parse(Console.ReadLine()!);

        Console.Write("Desired profit percentage : ");
        decimal profitPercentage = decimal.Parse(Console.ReadLine()!);

        decimal profit = cost * profitPercentage / 100;
        decimal salesPrice = cost + profit;
        Console.WriteLine($"Cost = {cost}; Profit Percentate = {profitPercentage}%; Profit = {profit:N2}; Sales Price = {salesPrice:N2}");
    }   
}