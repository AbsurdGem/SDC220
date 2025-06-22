/****************************************************************************************************************
// Morgan Moore
// Phase #1 - Console Calculator
// Date: [Insert Date]
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Console Calculator - Phase 1");
        Console.WriteLine("Developer: Morgan Moore");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Welcome! This calculator performs basic math operations.");
        Console.WriteLine("Follow the prompts below.\n");

        // Integer addition
        Console.WriteLine("Integer Operation: Addition");
        Console.Write("Enter first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        int intResult = int1 + int2;
        Console.WriteLine($"You entered: {int1} and {int2}");
        Console.WriteLine($"The result of {int1} + {int2} = {intResult}\n");

        // Floating-point subtraction
        Console.WriteLine("Floating-Point Operation: Subtraction");
        Console.Write("Enter first decimal number: ");
        double float1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second decimal number: ");
        double float2 = Convert.ToDouble(Console.ReadLine());

        double floatResult = Math.Round(float1 - float2, 2);
        Console.WriteLine($"You entered: {float1} and {float2}");
        Console.WriteLine($"The result of {float1} - {float2} = {floatResult}\n");

        // Closing message
        Console.WriteLine("Thank you for using the Console Calculator. Goodbye!");
    }
}
