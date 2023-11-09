// <copyright file="AsynchronousMethods.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ConfigureAwaitImplementation
{
    /// <summary>
    /// Has asynchronous methods to run in seperate threads.
    /// </summary>
    public static class AsynchronousMethods
    {
        /// <summary>
        /// A long running process.
        /// </summary>
        /// <returns>Task object</returns>
        public static async Task LongRunningProcess()
        {
            Console.WriteLine($"Method A Before Task:{Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(() =>
            {
                Console.WriteLine($"Method A Start Task:{Thread.CurrentThread.ManagedThreadId}");
                Task.Delay(10000);
                Console.WriteLine($"Method A End Task:{Thread.CurrentThread.ManagedThreadId}");
            }).ConfigureAwait(false);
            Console.WriteLine($"Method A After Task:{Thread.CurrentThread.ManagedThreadId}");
        }

        /// <summary>
        /// Performs Squaring operation on the array elements.
        /// </summary>
        /// <returns>Array of numbers</returns>
        public static async Task<int[]> SecondLongProcess()
        {
            await LongRunningProcess();
            Console.WriteLine($"Method B After Method A call:{Thread.CurrentThread.ManagedThreadId}");
            int[] arrayOfNumbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                arrayOfNumbers[i] = i * i;
            }

            Console.WriteLine($"Method B End :{Thread.CurrentThread.ManagedThreadId}");
            return arrayOfNumbers;
        }
    }
}