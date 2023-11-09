// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DynamicAndVar
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets input from user.
        /// </summary>
        private static void Main()
        {
            var firstNumber = 13;
            Console.WriteLine($"Before change:{firstNumber}");
            firstNumber += 3;
            Console.WriteLine($"After Change:{firstNumber}");
            dynamic secondNumber = 13;
            Console.WriteLine($"Before change:{secondNumber}");
            secondNumber = "Thirteen";
            Console.WriteLine($"After Change:{secondNumber}");
        }
    }
}