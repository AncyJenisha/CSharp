// <copyright file="MathOperaters.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MultithreadImplementation
{
    /// <summary>
    /// MathOperaters class has methods of math opeartions
    /// </summary>
    public static class MathOperaters
    {
        /// <summary>
        /// Create an array of integers.
        /// </summary>
        /// <returns>Array of integers</returns>
        public static int[] CreateArray()
        {
            int[] arrayOfNumbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrayOfNumbers[i] = i + 1;
            }

            return arrayOfNumbers;
        }

        /// <summary>
        /// Squares the array elements.
        /// </summary>
        /// <param name="arrayOfNumbers">array of integers</param>
        /// <returns>array of squared numbers</returns>
        public static int[] SquareArrayElements(int[] arrayOfNumbers)
        {
            int[] arrayOfSquaredNumbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrayOfSquaredNumbers[i] = arrayOfNumbers[i] * arrayOfNumbers[i];
            }

            return arrayOfSquaredNumbers;
        }

        /// <summary>
        /// Displays the array elements
        /// </summary>
        /// <param name="arrayOfNumbers">Array of integers</param>
        public static void DisplayArrayElements(int[] arrayOfNumbers)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}