// <copyright file="TextLogger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Logs the text
    /// </summary>
    public class TextLogger : ILogger
    {
        /// <summary>
        /// Logs the text message
        /// </summary>
        /// <param name="message">The message as string</param>
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}