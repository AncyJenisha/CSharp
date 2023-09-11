// <copyright file="InputReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeHierarchy
{
    /// <summary>
    /// Input reader has the method to get input from user.
    /// </summary>
    internal static class InputReader
    {
        /// <summary>
        /// This method reads string from user and converts it into float.
        /// </summary>
        /// <returns>Float number</returns>
        public static float GetFloatInput()
        {
            float number;
            string? n = Console.ReadLine();
            while (!float.TryParse(n, out number))
            {
                Console.WriteLine("Enter valid Number");
                n = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Gets the string and validates it.
        /// </summary>
        /// <returns>A valid string</returns>
        public static string GetStringInput()
        {
            string? n = Console.ReadLine();
            while (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Enter a valid Input");
                n = Console.ReadLine();
            }

            return n;
        }
    }
}