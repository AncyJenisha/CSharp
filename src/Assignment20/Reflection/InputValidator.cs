// <copyright file="InputValidator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    /// <summary>
    /// InputValidator - Has method to get input from user and validate it.
    /// </summary>
    public class InputValidator
    {
        /// <summary>
        /// Gets input from user and converts it into Integer.
        /// </summary>
        /// <returns>Integer number</returns>
        public int GetIntegerInput()
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