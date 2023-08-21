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
    /// Adds Integer1 to Integer2
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
    public static void Add(float a, float b)
    {
        Console.WriteLine($"Sum of {a} and {b} is {a + b}");
    }

    /// <summary>
    /// Divides Integer1 by Integer2
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
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
    /// Mutiplies Integer1 and Integer2
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
    public static void Multiply(float a, float b)
    {
        Console.WriteLine($"Product of {a} and {b} is {a * b}");
    }

    /// <summary>
    /// Subtracts Integer22 from Integer1
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
    public static void Subtract(float a, float b)
    {
        Console.WriteLine($"Difference of {a} and {b} is {a - b}");
    }
}