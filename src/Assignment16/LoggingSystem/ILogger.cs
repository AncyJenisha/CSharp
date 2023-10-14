// <copyright file="ILogger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Interface ILogger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="message">The message as string</param>
        public void Log(string message);
    }
}