// <copyright file="InputValidators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ValidatorforInputs
{
    /// <summary>
    /// InputValidators has the methods to validate the input.
    /// </summary>
    public static class InputValidators
    {
        /// <summary>
        /// ReadDoubleInput method gets input and converts it into integer.
        /// </summary>
        /// <returns>Number as double</returns>
        public static double ReadDoubleInput()
        {
            double number;
            string? n = Console.ReadLine();
            while (!double.TryParse(n, out number))
            {
                Console.WriteLine("Enter valid Number");
                n = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// ReadIntegerInput method gets input and converts it into integer.
        /// </summary>
        /// <returns>Number as double</returns>
        public static int ReadIntegerInput()
        {
            int number;
            string? n = Console.ReadLine();
            while (!int.TryParse(n, out number))
            {
                Console.WriteLine("Enter valid Number");
                n = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// It gets the string and check if it is valid.
        /// </summary>
        /// <returns>Valid String</returns>
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