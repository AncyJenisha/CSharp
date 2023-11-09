// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousMethods
{
    using InputValidator;

    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Points to a function that gets integer and returns void.
        /// </summary>
        /// <param name="numbers">Integers entered by user</param>
        public delegate void Operations(int[] numbers);

        /// <summary>
        /// Gets the input numbers from user.
        /// </summary>
        public static void Main()
        {
            int[] arrayToBeSorted = new int[10];
            Console.WriteLine("Enter the numbers to be sorted");
            for (int i = 0; i < 10; i++)
            {
                arrayToBeSorted[i] = InputValidators.GetIntegerInput();
            }

            Operations obj = x =>
            {
                Console.WriteLine("Anonymous method");
                Array.Sort(arrayToBeSorted);
            };
            obj(arrayToBeSorted);

            foreach (int number in arrayToBeSorted)
            {
                Console.WriteLine(number);
            }
        }
    }
}