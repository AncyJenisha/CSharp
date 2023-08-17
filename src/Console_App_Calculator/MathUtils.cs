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
    public static void Add(int a, int b)
    {
        Console.WriteLine($"Sum of {a} and {b} is {a + b}");
    }

    /// <summary>
    /// Divides Integer1 by Integer2
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
    public static void Divide(int a, int b)
    {
        try
        {
            Console.WriteLine($"Quotient of  {a} and {b} is {a / b}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Integer2 cannot be zero");
        }
    }

    /// <summary>
    /// Mutiplies Integer1 and Integer2
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
    public static void Multiply(int a, int b)
    {
        Console.WriteLine($"Product of {a} and {b} is {a * b}");
    }

    /// <summary>
    /// Subtracts Integer22 from Integer1
    /// </summary>
    /// <param name="a">Integer1</param>
    /// <param name="b">Integer2</param>
    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"Difference of {a} and {b} is {a - b}");
    }
}