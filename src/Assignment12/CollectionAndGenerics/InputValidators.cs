﻿// <copyright file="InputValidators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace CollectionAndGenerics
{
    using System.Collections.Generic;

    /// <summary>
    /// InputValidators has methods to validate inputs entered by user.
    /// </summary>
    public static class InputValidators
    {
        /// <summary>
        /// Gets string and validates it.
        /// </summary>
        /// <returns>String Input</returns>
        public static string GetStringInput()
        {
            string? inputRead;
            inputRead = Console.ReadLine();
            while (string.IsNullOrEmpty(inputRead))
            {
                Console.WriteLine("Enter a valid name");
                inputRead = Console.ReadLine();
            }

            return inputRead;
        }

        /// <summary>
        /// Gets string and validates it to integer.
        /// </summary>
        /// <returns>Input Input</returns>
        public static int GetIntegerInput()
        {
            string? inputRead;
            inputRead = Console.ReadLine();
            int number;
            while (!int.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Gets string and validates it to float.
        /// </summary>
        /// <returns>Float number</returns>
        public static float GetFloatInput()
        {
            string? inputRead;
            inputRead = Console.ReadLine();
            float number;
            while (!float.TryParse(inputRead, out number))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return number;
        }

        /// <summary>
        /// Gets string and validates it to float.
        /// </summary>
        /// <returns>Float number</returns>
        public static char GetCharacterInput()
        {
            string? inputRead;
            inputRead = Console.ReadLine();
            char character;
            while (!char.TryParse(inputRead, out character))
            {
                Console.WriteLine("Enter a valid number");
                inputRead = Console.ReadLine();
            }

            return character;
        }
    }
}