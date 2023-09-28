// <copyright file="ArrayOperation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ErrorHandling
{
    using System;

    /// <summary>
    /// DisplayMessage class has a method to display the message recieved from user.
    /// </summary>
    public static class ArrayOperation
    {
        /// <summary>
        /// Displays the message from user.
        /// </summary>
        /// <param name="array">Empty array</param>
        /// <returns>Updated Array</returns>
        public static int[] AddElementsToArray(int[] array)
        {
            Console.WriteLine("Enter 5 numbers as elements of array");
            for (int i = 0; i < array.Length; i++)
            {
                int number = InputReaders.GetInteger();
                array[i] = number;
            }

            return array;
        }
    }
}