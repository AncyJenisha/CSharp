// <copyright file="InvalidInputException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ErrorHandling
{
    /// <summary>
    /// InvalidInputException throws exception when the input is invalid.
    /// </summary>
    public class InvalidInputException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidInputException"/> class.
        /// Basic Exception constructor
        /// </summary>
        public InvalidInputException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidInputException"/> class.
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        public InvalidInputException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidInputException"/> class.
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        /// <param name="inner">Inner message</param>
        public InvalidInputException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}