// <copyright file="InputReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ValidatorsApp
{
    /// <summary>
    /// Class InputReader have method to read input from user and validate it.
    /// </summary>
    public static class InputReader
    {
        /// <summary>
        /// Gets string and converts it into float.
        /// </summary>
        /// <returns>float input</returns>
        public static float GetInput()
        {
            string? n;
            n = Console.ReadLine();
            float number;
            while (!float.TryParse(n, out number))
            {
                Console.WriteLine("Enter a valid number");
                n = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Gets string as input and converts it to an integer.
        /// </summary>
        /// <returns>A integer number</returns>
        public static int GetIntegerInput()
        {
            string? n;
            int integer;
            n = Console.ReadLine();
            while (!int.TryParse(n, out integer))
            {
                Console.WriteLine("Enter a valid number");
                n = Console.ReadLine();
            }

            return integer;
        }
    }
}