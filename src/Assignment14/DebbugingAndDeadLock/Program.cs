// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DebuggingAndDeadLock
{
    /// <summary>
    /// Program class has main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets result from asyncOperation method.
        /// </summary>
        /// <returns>task</returns>
        public static async Task DeadLockMethod()
        {
            var result = await SomeAsyncOperation();
            Console.WriteLine(result);
        }

        /// <summary>
        /// Prints message after delay.
        /// </summary>
        /// <returns>Message as string</returns>
        public static async Task<string> SomeAsyncOperation()
        {
            await Task.Delay(10000).ConfigureAwait(false);
            return "Hello World";
        }

        /// <summary>
        /// Main method awaits DeadLockMethod.
        /// </summary>
        /// <returns>Task</returns>
        public static async Task Main()
        {
            await DeadLockMethod();
        }
    }
}