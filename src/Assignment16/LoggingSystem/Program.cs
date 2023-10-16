// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets the message the logging type.
        /// </summary>
        private static void Main()
        {
            LoggingSystem.LogMethod("Log Data", "SimpleText");
            LoggingSystem.LogMethod("Log Data as Json", "Json");
            SimpleLoggerFactory simpleLoggerFactory = new ();
            Console.WriteLine(simpleLoggerFactory.CreateLogger("Json").GetType());
        }
    }
}