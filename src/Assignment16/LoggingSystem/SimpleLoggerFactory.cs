// <copyright file="SimpleLoggerFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleLoggerFactory : LoggerFactory
    {
        /// <summary>
        /// Creates Ilogger based on the type.
        /// </summary>
        /// <param name="type">Type of logger</param>
        /// <returns>An object</returns>
        public ILogger CreateLogger(string type)
        {
            ILogger loggerType = null;

            if (type == "SimpleText")
            {
                loggerType = new TextLogger();
            }
            else if (type == "Json")
            {
                loggerType = new JsonLogger();
            }
        }

    }

}