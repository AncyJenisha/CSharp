// <copyright file="MathUtils.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ConsoleAppCalculator;

/// <summary>
/// MathUtils contains the methods for arithmetic operations.
/// </summary>
internal static class MathUtils
{
    /// <summary>
    /// Adds Number1 to Number2.
    /// </summary>
    /// <param name="a">The number1 recieved from user</param>
    /// <param name="b">The number2 recieved from user</param>
    public static void Add(float a, float b)
    {
        Console.WriteLine($"Sum of {a} and {b} is {a + b}");
    }

    /// <summary>
    /// Divides number1 by number2
    /// </summary>
    /// <param name="a">number1 recieved from user ,which is the dividend</param>
    /// <param name="b">number2 recieved from user, which is the divisor.</param>
    public static void Divide(float a, float b)
    {
        if (b == 0)
        {
            Console.WriteLine("The second number cannot be zero");
        }
        else
        {
            Console.WriteLine($"Quotient of  {a} and {b} is {a / b}");
        }
    }

    /// <summary>
    /// Mutiplies number1 and number2
    /// </summary>
    /// <param name="a">number1, which is the multiplicant</param>
    /// <param name="b">number2, which is the multiplier</param>
    public static void Multiply(float a, float b)
    {
        Console.WriteLine($"Product of {a} and {b} is {a * b}");
    }

    /// <summary>
    /// Subtracts number2 from number1
    /// </summary>
    /// <param name="a">number1 is the minuend</param>
    /// <param name="b">number2 is the subtrahend</param>
    public static void Subtract(float a, float b)
    {
        Console.WriteLine($"Difference of {a} and {b} is {a - b}");
    }
}