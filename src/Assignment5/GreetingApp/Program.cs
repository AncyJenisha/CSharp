// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GreetingApp
{
    using MathApp;

    /// <summary>
    /// Program class contains the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method has the greeting message to display.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Welcome to console Application!!\n");
            do
            {
                MathUtilis.Readinput();
            }
            while (true);
        }
    }
}