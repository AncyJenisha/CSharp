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
        /// The CheckIfEmpty method checks if the contact list is empty.
        /// </summary>
        /// <param name="contactList"> The contact list is passed as input </param>
        /// <returns>Returns 0 if there is no contact in the list and 1 if the list has contacts</returns>
        public static int CheckIfEmpty(List<Contact> contactList)
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("The contact list is empty");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Validates the email
        /// </summary>
        /// <param name="email"> The email entered by user is validated. </param>
        /// <returns>Returns 0 if email is invalid and 1 if emailis valid.</returns>
        public static int EmailValidate(string email)
        {
            string emailpattern = "^(\\w+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            if (!Regex.IsMatch(email, emailpattern))
            {
                Console.WriteLine("Enter a valid Email");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// GetInput method gets input and converts it into integer.
        /// </summary>
        /// <returns>integer</returns>
        public static int GetInput()
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

        /// <summary>
        /// Validates the name entered by user
        /// </summary>
        /// <param name="name"> The name entered as string by the user</param>
        /// <returns> Returns 0 if name is invalid and 1 if the name is valid.</returns>
        public static int NameValidate(string name)
        {
            string namepattern = "^[A-Za-z0-9]+($| +([A-Za-z])+){0,2}$";
            if (!Regex.IsMatch(name, namepattern))
            {
                Console.WriteLine("Enter correct name");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Checks if the phone number is valid.
        /// </summary>
        /// <param name="phone">The phone number enetered by user as string</param>
        /// <returns>returns 0 if the phone number is invalid and 1 if the phone number is valid.</returns>
        public static int PhoneValidate(string phone)
        {
            string phonepattern = "^[6-9]+[0-9]{9}";
            if (!Regex.IsMatch(phone, phonepattern))
            {
                Console.WriteLine("Enter a valid phone number");
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}