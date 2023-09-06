// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DisplayApp
{
    using ValidatorsApp;

    /// <summary>
    /// Program class has the method to display numbers.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Display method gets a number as input and displays it.
        /// </summary>
        /// <param name="number">result of a mathematical operation.</param>
        public static void Display(float number)
        {
            Console.WriteLine($"The result: {number}\n");
            UtilityApp.Program.Message();
        }

        /// <summary>
        /// Main method.
        /// </summary>
        private static void Main()
        {
        }
    }
}