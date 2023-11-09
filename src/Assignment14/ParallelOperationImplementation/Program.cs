// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics;

namespace ParallelOperationImplementation
{
    /// <summary>
    /// Has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method has the implementation of parallel for each loop.
        /// </summary>
        protected static void Main()
        {
            int[] arrayOfNumbers = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                arrayOfNumbers[i] = i + 1;
            }

            Stopwatch stopWatchForSequentialLoop = new ();
            stopWatchForSequentialLoop.Start();
            for (int i = 0; i < 10000; i++)
            {
                int squareOfNumbersBySquentialCalculation = arrayOfNumbers[i] * arrayOfNumbers[i];
                Console.WriteLine(squareOfNumbersBySquentialCalculation);
            }

            stopWatchForSequentialLoop.Stop();
            TimeSpan timeSpanForSequentialLoop = stopWatchForSequentialLoop.Elapsed;

            Stopwatch stopWatchForParallelLoop = new ();
            stopWatchForParallelLoop.Start();
            Parallel.For(1, 10000, i =>
            {
                int squareOfNumber = arrayOfNumbers[i] * arrayOfNumbers[i];
                Console.WriteLine(squareOfNumber);
            });
            stopWatchForParallelLoop.Stop();
            TimeSpan timeSpanForParallelLoop = stopWatchForParallelLoop.Elapsed;
            Console.WriteLine($"TimeSpan of Sequential Loop:{timeSpanForSequentialLoop}");
            Console.WriteLine($"TimeSpan of Parallel Loop:{timeSpanForParallelLoop}");
        }
    }
}