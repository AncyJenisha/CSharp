// <copyright file="Inputreader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MathApp
{
    using System.Runtime.CompilerServices;
    using Task5DisplayApp;
    using Task5MathApp;

    /// <summary>
    /// Class Inputconvertors has the methods for converting inputs.
    /// </summary>
    public class Inputreader
    {
        /// <summary>
        /// Reads string and converts it into float.
        /// </summary>
        /// <returns>float input</returns>
        public static float GetInput()
        {
            string? n;
        getfloat:
            n = Console.ReadLine();
            if (!float.TryParse(n, out float number))
            {
                Console.WriteLine("Enter a valid number");
                goto getfloat;
            }

            return number;
        }

        /// <summary>
        /// Gets string as input and converts it to an integer.
        /// </summary>
        /// <returns>A integer number.</returns>
        public static int GetIntegerInput()
        {
            string? n;
        getinteger:
            n = Console.ReadLine();
            if (!int.TryParse(n, out int integer))
            {
                Console.WriteLine("Enter a valid number");
                goto getinteger;
            }

            return integer;
        }
    }
}