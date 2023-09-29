// <copyright file="InputValidators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Has methods to validate inputs.
    /// </summary>
    internal static class InputValidators
    {
        /// <summary>
        /// Gets String as input and converts it into integer.
        /// </summary>
        /// <returns>Integer</returns>
        public static int IntegerValidator()
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
        /// Gets String as input and validates it.
        /// </summary>
        /// <returns>Non empty string</returns>
        public static string StringValidator()
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
        /// Gets String as input and converts it into float.
        /// </summary>
        /// <returns>Float number</returns>
        public static float FloatValidator()
        {
            float number;
            string? inputRead = Console.ReadLine();
            while (!float.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter valid Number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Checks and validates the account number
        /// </summary>
        /// <param name="accountNumber">String</param>
        /// <returns>Returns true if the account number is valid.</returns>
        public static bool AccountNumberValidate(string accountNumber)
        {
            string accountNumberPattern = "^([0-9]{9})$";
            if (!Regex.IsMatch(accountNumber, accountNumberPattern))
            {
                Console.WriteLine("Enter the correct account number");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}