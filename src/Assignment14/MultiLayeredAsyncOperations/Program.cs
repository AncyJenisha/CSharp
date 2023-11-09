// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MultiLayeredAsyncOperations
{
    /// <summary>
    /// Program class has main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method calls the JsonCounter and awaits it.
        /// </summary>
        /// <returns>task</returns>
        public static async Task Main()
        {
            Console.WriteLine(await CpuBoundOperations.JsonCounterOfContentsOfUrl());
        }
    }
}