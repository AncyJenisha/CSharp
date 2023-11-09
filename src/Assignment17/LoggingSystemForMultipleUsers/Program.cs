// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystemForMultipleUsers
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Calls the logerror method with the error message and name of file.
        /// </summary>
        public static void Main()
        {
            Parallel.For(1, 10, i =>
            {
                Parallel.For(1, 10, j =>
                {
                    Logger.LogError($"Log{i}.txt", "Error\n");
                });
            });
        }
    }
}