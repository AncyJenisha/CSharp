// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConfigureAwaitImplementation
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method waits for the execution of SecondLongProcess.
        /// </summary>
        private static async Task Main()
        {
            int[] arrayOfNumbers = await AsynchronousMethods.SecondLongProcess();
            for (int i = 0; i < 1000;  i++)
            {
               Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}