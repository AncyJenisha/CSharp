// <copyright file="Program1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    /// <summary>
    ///  class program has the enum for options to be used for the switch case in main class.
    /// </summary>
    internal partial class Program
    {
        /// <summary>
        /// Options has the different options for the user to perform.
        /// </summary>
        private enum Options
        {
            AddNewContact = 1,
            Display,
            Search,
            Edit,
            Delete,
            Stop,
        }
    }
}
