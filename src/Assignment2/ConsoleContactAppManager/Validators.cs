// <copyright file="Validators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class validators have the methods to check if the fields enetered by user are valid.
    /// </summary>
    internal static class Validators
    {
        /// <summary>
        /// Validates the email
        /// </summary>
        /// <param name="email"> The email entered by user is validated. </param>
        /// <returns>Returns 0 if email is invalid and 1 if emailis valid.</returns>
        public static bool EmailValidate(string email)
        {
            string emailpattern = "^(\\w+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            if (!Regex.IsMatch(email, emailpattern))
            {
                Console.WriteLine("Enter a valid Email");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Validates the name entered by user
        /// </summary>
        /// <param name="name"> The name entered as string by the user</param>
        /// <returns> Returns 0 if name is invalid and 1 if the name is valid.</returns>
        public static bool NameValidate(string name)
        {
            string namepattern = "^[A-Za-z0-9]+($| +([A-Za-z])+){0,2}$";
            if (!Regex.IsMatch(name, namepattern))
            {
                Console.WriteLine("Enter correct name");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks if the phone number is valid.
        /// </summary>
        /// <param name="phone">The phone number enetered by user as string</param>
        /// <returns>returns 0 if the phone number is invalid and 1 if the phone number is valid.</returns>
        public static bool PhoneValidate(string phone)
        {
            string phonepattern = "^[6-9]+[0-9]{9}";
            if (!Regex.IsMatch(phone, phonepattern))
            {
                Console.WriteLine("Enter a valid phone number");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}