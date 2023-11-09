// <copyright file="JsonLogger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Has method to log in json format.
    /// </summary>
    public class JsonLogger : ILogger
    {
        /// <summary>
        /// Logs the message in Json Format.
        /// </summary>
        /// <param name="message">Message to be logged</param>
        public void Log(string message)
        {
            Console.WriteLine($"{message}:Logged as Json");
        }
    }
}