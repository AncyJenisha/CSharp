// <copyright file="FileModifier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FileProcessor
{
    using System;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Has methods to modify file content.
    /// </summary>
    public class FileModifier
    {
        /// <summary>
        /// Capitalizes and adds content to a file.
        /// </summary>
        /// <param name="sourceFile">Name of the file to be read</param>
        /// <param name="destinationFile">Name of the file to be written</param>
        public static void AddCapitalizedContentToFile(string sourceFile, string destinationFile)
        {
            using FileStream fileStreamReader = new (sourceFile, FileMode.Open);
            UTF8Encoding encoder = new ();
            byte[] buffer = new byte[1024];
            int bytesRead = fileStreamReader.Read(buffer, 0, buffer.Length);
            string contentRead = encoder.GetString(buffer, 0, bytesRead).ToUpper();

            Stopwatch stopwatch = Stopwatch.StartNew();

            using (FileStream fileStreamWriter = new (destinationFile, FileMode.Create))
            {
                using BufferedStream bufferStreamWritter = new (fileStreamWriter);
                buffer = Encoding.Default.GetBytes(contentRead);
                fileStreamWriter.Write(buffer, 0, bytesRead);
            }

            stopwatch.Stop();

            Console.WriteLine($"Modify Synchronously:{stopwatch.Elapsed}");
        }

        /// <summary>
        /// Capitalizes the content asynchronously.
        /// </summary>
        /// <param name="sourceFile">Name of the file to be read</param>
        /// <param name="destinationFile">Name of the file to be written</param>
        /// <returns>Task object</returns>
        public static async Task AddCapitalizedContentToFileAsync(string sourceFile, string destinationFile)
        {
            using FileStream fileStreamReader = new (sourceFile, FileMode.Open);
            UTF8Encoding encoder = new ();
            byte[] buffer = new byte[1024];
            int byteRead = await fileStreamReader.ReadAsync(buffer, 0, buffer.Length);
            string contentRead = encoder.GetString(buffer, 0, byteRead);
            contentRead = contentRead.ToUpper();

            Stopwatch stopwatch = new ();
            stopwatch.Start();

            using (FileStream fileStreamWriter = new (destinationFile, FileMode.Create))
            {
                using BufferedStream bufferStreamWritter = new (fileStreamWriter);
                buffer = Encoding.Default.GetBytes(contentRead);
                await fileStreamWriter.WriteAsync(buffer, 0, byteRead);
            }

            stopwatch.Stop();

            Console.WriteLine($"Modify Asynchronously:{stopwatch.Elapsed}");
        }
    }
}