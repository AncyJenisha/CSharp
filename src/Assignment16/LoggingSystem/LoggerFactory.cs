// <copyright file="LoggerFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Abstract class which has the method to create the instance of the object.
    /// </summary>
    public abstract class LoggerFactory
    {
        /// <summary>
        /// Creates a new logger.
        /// </summary>
        /// <param name="type">Type of logging message</param>
        /// <returns>Instance of Ilogger</returns>
        public abstract ILogger CreateLogger(string type);
    }
}