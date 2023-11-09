// <copyright file="Logger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace LoggingSystemForMultipleUsers
{
    using System.Text;

    /// <summary>
    /// Logger class has the method to log error messages.
    /// </summary>
    public class Logger
    {
        private static Logger? instance;

        private static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (Padlock)
                    {
                        instance ??= new Logger();
                    }
                }

                return instance;
            }
        }

        private static object Padlock { get; set; } = new ();

        /// <summary>
        /// LogError logs the error message.
        /// </summary>
        /// <param name="filepath">The filepath as string</param>
        /// <param name="message">The error message</param>
        public static void LogError(string filepath, string message)
        {
            lock (Padlock)
            {
                using FileStream fileStream = new (filepath, FileMode.Create);
                byte[] errorBytes = Encoding.UTF8.GetBytes(message);
                fileStream.Write(errorBytes, 0, errorBytes.Length);
            }
        }
    }
}