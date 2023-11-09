// <copyright file="InputValidators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace InputValidator
{
    /// <summary>
    /// Program class.
    /// </summary>
    public class InputValidators
    {
        /// <summary>
        /// Gets String as input and validates it.
        /// </summary>
        /// <returns>Non empty string</returns>
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

        /// <summary>
        /// Gets string and converts it into float.
        /// </summary>
        /// <returns>float input</returns>
        public static float GetFloatInput()
        {
            string? inputRead;
            inputRead = Console.ReadLine();
            float number;
            while (!float.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Gets string as input and converts it to an integer.
        /// </summary>
        /// <returns>A integer number</returns>
        public static int GetIntegerInput()
        {
            string? inputRead;
            int integer;
            inputRead = Console.ReadLine();
            while (!int.TryParse(inputRead, out integer))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return integer;
        }
    }
}