// <copyright file="JsonLogger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Logs Json
    /// </summary>
    public class JsonLogger : ILogger
    {
        /// <summary>
        /// Logs
        /// </summary>
        /// <param name="message">Message to be logged</param>
        public void Log(string message)
        {
            Console.WriteLine($"{message}:Logged as Json");
        }
    }

}