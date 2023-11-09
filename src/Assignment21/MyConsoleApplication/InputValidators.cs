// <copyright file="InputValidators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyConsoleApplication
{
    /// <summary>
    /// InputValidators - Has methods to get and validate input.
    /// </summary>
    public static class InputValidators
    {
        /// <summary>
        /// This method reads string from user and converts it into integer.
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
    }
}