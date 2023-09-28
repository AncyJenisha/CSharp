// <copyright file="InputReaders.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Debugging
{
    /// <summary>
    /// The class InputReaders has the method to read input and convert to numbers.
    /// </summary>
    internal static class InputReaders
    {
        /// <summary>
        /// Gets string as input and converts into integer.
        /// </summary>
        /// <returns>Integer</returns>
        public static int GetIntegerInput()
        {
            int integer;
            string? inputRead = Console.ReadLine();
            while (!int.TryParse(inputRead, out integer))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
            }

            return integer;
        }

        /// <summary>
        /// Gets string as input and converts it to float.
        /// </summary>
        /// <returns>float value</returns>
        public static float GetFloatInput()
        {
            float floatnumber;
            string? inputRead = Console.ReadLine();
            while (!float.TryParse(inputRead, out floatnumber))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
            }

            return floatnumber;
        }
    }
}