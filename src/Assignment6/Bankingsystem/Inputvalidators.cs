// <copyright file="Inputvalidators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Has methods to validate inputs.
    /// </summary>
    internal static class Inputvalidators
    {
        /// <summary>
        /// Gets String as input and converts it into integer.
        /// </summary>
        /// <returns>Integer</returns>
        public static int IntegerValidator()
        {
            int integer;
            string? n = Console.ReadLine();
            while (!int.TryParse(n, out integer))
            {
                Console.WriteLine("Enter valid Number");
                n = Console.ReadLine();
            }

            return integer;
        }

        /// <summary>
        /// Gets String as input and validates it.
        /// </summary>
        /// <returns>Non empty string</returns>
        public static string StringValidator()
        {
            string? n = Console.ReadLine();
            while (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Enter a valid Input");
                n = Console.ReadLine();
            }

            return n;
        }

        /// <summary>
        /// Gets String as input and converts it into float.
        /// </summary>
        /// <returns>Float number</returns>
        public static float FloatValidator()
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
        /// Checks and validates the account number
        /// </summary>
        /// <param name="accountnumber">String</param>
        /// <returns>Returns true if the account number is valid.</returns>
        public static bool AccountNumberValidate(string accountnumber)
        {
            string accountnumberpattern = "^([0-9]{9})$";
            if (!Regex.IsMatch(accountnumber, accountnumberpattern))
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