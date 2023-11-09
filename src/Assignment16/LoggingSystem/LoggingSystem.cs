// <copyright file="LoggingSystem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystem
{
    /// <summary>
    /// Logging System is a thread safe singleton class.
    /// </summary>
    public class LoggingSystem
    {
        /// <summary>
        /// A new object padlock is instantiated.
        /// </summary>
        private static readonly object Padlock = new ();

        /// <summary>
        /// An instance for the loggingSystem.
        /// </summary>
        private static LoggingSystem? instance;

        /// <summary>
        /// Gets the thread and creates new objectinstance for it.
        /// </summary>
        /// <value>An object being assigned to the thread</value>
        private static LoggingSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (Padlock)
                    {
                        if (instance == null)
                        {
                            instance = new LoggingSystem();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Logs the message in the given type.
        /// </summary>
        /// <param name="message">The message entered by user as string</param>
        /// <param name="type">Message Type</param>
        public static void LogMethod(string message, string type)
        {
            SimpleLoggerFactory simpleLoggerFactory = new ();
            if (type != "Json" && type != "SimpleText")
            {
                Console.WriteLine("Enter a valid logger type");
            }
            else
            {
                ILogger logger = simpleLoggerFactory.CreateLogger(type);
                logger.Log(message);
            }
        }
    }
}