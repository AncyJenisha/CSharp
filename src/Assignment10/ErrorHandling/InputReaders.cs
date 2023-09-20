// <copyright file="InputReaders.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ErrorHandling
{
    /// <summary>
    /// Has methods to read input from user
    /// </summary>
    internal static class InputReaders
    {
        /// <summary>
        /// Gets string from user and converts it into integer.
        /// </summary>
        /// <returns>Integer</returns>
        public static int GetInteger()
        {
            int integer;
            string? n = Console.ReadLine();
            while (!int.TryParse(n, out integer))
            {
                Console.WriteLine("Enter a valid Number\n");
                n = Console.ReadLine();
            }

            return integer;
        }
    }
}