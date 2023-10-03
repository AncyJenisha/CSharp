// <copyright file="InputReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/// <summary>
/// It has the methods to read input from user.
/// </summary>
internal static class InputReader
{
    /// <summary>
    /// Gets input from user and converts it into float.
    /// </summary>
    /// <returns>Float number</returns>
    public static float GetFloatInput()
    {
        float number;
        string? inputRead = Console.ReadLine();
        while (!float.TryParse(inputRead, out number))
        {
            Console.WriteLine("Enter the correct salary");
            inputRead = Console.ReadLine();
        }

        return number;
    }

    /// <summary>
    /// Gets input from user and converts it into Integer.
    /// </summary>
    /// <returns>Integer number</returns>
    public static int GetIntegerInput()
    {
        int number;
        string? inputRead = Console.ReadLine();
        while (!int.TryParse(inputRead, out number))
        {
            Console.WriteLine("Enter valid Number");
            inputRead = Console.ReadLine();
        }

        return number;
    }

    /// <summary>
    /// Gets the string and validates it.
    /// </summary>
    /// <returns>A valid string</returns>
    public static string GetStringInput()
    {
        string? inputRead = Console.ReadLine();
        while (string.IsNullOrEmpty(inputRead))
        {
            Console.WriteLine("Enter a valid Input");
            inputRead = Console.ReadLine();
        }

        return inputRead;
    }
}