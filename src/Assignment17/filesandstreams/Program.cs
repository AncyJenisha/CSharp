// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FileProcessor
{
    /// <summary>
    /// Has the main method which is the entry of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Method Calls the read and write methods.
        /// </summary>
        private static async Task Main()
        {
            FileWriters.WriteToFile("Assignment17.txt", 100);
            await FileWriters.WriteToFileAsync("Jeni.txt", 100);

            FileReader.ReadFromFile("Assignment17.txt");
            FileReader.ReadUsingBufferedStream("Assignment17.txt");
            await FileReader.ReadUsingBufferedStreamAsync("Assignment17.txt");

            FileModifier.AddCapitalizedContentToFile("Assignment17.txt", "CapitalizedContent.txt");
            await FileModifier.AddCapitalizedContentToFileAsync("Assignment17.txt", "CapitalizedContentAsynchronously.txt");
        }
    }
}