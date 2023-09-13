// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace IDisposableDemo
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// calls the methods and gets input from user.
        /// </summary>
        private static void Main()
        {
            FileOperations.WriteToFile();
            FileOperations.ReadFromFile();
        }
    }
}