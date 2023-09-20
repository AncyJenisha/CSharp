// <copyright file="DisplayResult.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DisplayApp
{
    using UtilityApp;

    /// <summary>
    /// Contains method to display the result of the mathematical operation.
    /// </summary>
    public static class DisplayResult
    {
        /// <summary>
        /// Display method gets a number as input and displays it.
        /// </summary>
        /// <param name="number">Result of a mathematical operation.</param>
        public static void Display(float number)
        {
            Console.WriteLine($"The result: {number}\n");
            MessageDisplayer.Message();
        }
    }
}