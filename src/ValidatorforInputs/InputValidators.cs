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
            string? inputRead = Console.ReadLine();
            while (!double.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
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
            string? inputRead = Console.ReadLine();
            while (!int.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// It gets the string and check if it is valid.
        /// </summary>
        /// <returns>Valid String</returns>
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
    }
}