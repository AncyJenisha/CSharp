// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyConsoleApplication
{
    using System.Numerics;
    using MyMathLibrary;

    /// <summary>
    /// Program class has main method which is the entry of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method calls the fibonaccisequence method to generate the fibonacciSequence.
        /// </summary>
        private static void Main()
        {
            int lengthOfFibonnaciSequence;
            FibonnaciCalculator fibonnaciCalculator = new FibonnaciCalculator();
            Console.WriteLine("Enter the length of the Fibonacci sequence:\n");
            lengthOfFibonnaciSequence = InputValidators.GetIntegerInput();
            BigInteger[] fibonnaciSequence = fibonnaciCalculator.CalculateFibonnaci(lengthOfFibonnaciSequence);

            for (int i = 0; i < fibonnaciSequence.Length; i++)
            {
                Console.WriteLine(fibonnaciSequence[i]);
            }
        }
    }
}