// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MultithreadImplementation
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method makes the methods to run on seperate threads.
        /// </summary>
        private static void Main()
        {
            int[] arrayOfNumbers = new int[10];
            int[] arrayOfSquareNumbers = new int[10];
            Thread firstThread = new (() => { arrayOfNumbers = MathOperaters.CreateArray(); });
            firstThread.Start();
            Thread secondThread = new (() => arrayOfSquareNumbers = MathOperaters.SquareArrayElements(arrayOfNumbers));
            firstThread.Join();
            secondThread.Start();
            Thread thirdThread = new (() => MathOperaters.DisplayArrayElements(arrayOfSquareNumbers));
            secondThread.Join();
            thirdThread.Start();
        }
    }
}