using System;

public class LogicOperations
{
    public static void Run ()
    {
        /*
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
         * AND: &&
         *    Result is true only if all the conditions are true
         * OR: ||
              Result is false only if all condictions are false
         * NOT: !
         */

        int age = 17;
        int score = 82;
        bool hasPermissionSlip = true;

        bool canRideRollercoaster = age >= 16 && hasPermissionSlip;
        bool canEnterClub = age >= 18 || score >= 90;

        Console.WriteLine("age = " + age);
        Console.WriteLine("score = " + score);
        Console.WriteLine("hasPermissionSlip = " + hasPermissionSlip);
        Console.WriteLine();

        Console.WriteLine("canRideRollercoaster (age >= 16 && hasPermissionSlip): " + canRideRollercoaster);
        Console.WriteLine("canEnterClub (age >= 18 || score >= 90): " + canEnterClub);
    }
}