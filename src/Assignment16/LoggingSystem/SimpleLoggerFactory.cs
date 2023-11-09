// <copyright file="SimpleLoggerFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Creates Ilogger based on the type.
    /// </summary>
    public class SimpleLoggerFactory : LoggerFactory
    {
        /// <summary>
        /// Creates Ilogger based on the type.
        /// </summary>
        /// <param name="type">Type of logger</param>
        /// <returns>An object</returns>
        public override ILogger CreateLogger(string type)
        {
            if (type == "Json")
            {
                return new JsonLogger();
            }
            else
            {
                return new TextLogger();
            }
        }
    }
}