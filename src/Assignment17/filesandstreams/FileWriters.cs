// <copyright file="FileWriters.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FileProcessor
{
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// FileWriters has methods to write to a file.
    /// </summary>
    public static class FileWriters
    {
        /// <summary>
        /// Writes the content to file.
        /// </summary>
        /// <param name="fileName">The file name for the content to be written.</param>
        /// <param name="fileSize">Size of the file to be generated</param>
        public static void WriteToFile(string fileName, long fileSize)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            using FileStream fileStream = new (fileName, FileMode.Create);
            while (fileStream.Length < fileSize)
            {
                byte[] bytedata = Encoding.Default.GetBytes("Assignment17 Files and Streams\n");
                fileStream.Write(bytedata, 0, bytedata.Length);
            }

            stopwatch.Stop();
            Console.WriteLine($"Time to Write to a file:{stopwatch.Elapsed}");
        }

        /// <summary>
        /// Writes the content to file asynchronously.
        /// </summary>
        /// <param name="fileName">Name of the file for the content to be written.</param>
        /// <param name="fileSize">size of the file to be generated</param>
        /// <returns>Task object</returns>
        public static async Task WriteToFileAsync(string fileName, long fileSize)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            using FileStream fileStreamWriter = new (fileName, FileMode.Create);
            stopwatch.Start();
            while (fileStreamWriter.Length < fileSize)
            {
                byte[] bytedata = Encoding.Default.GetBytes("Assignment17 Files and Streams\n");
                await fileStreamWriter.WriteAsync(bytedata, 0, bytedata.Length);
            }

            stopwatch.Stop();
            Console.WriteLine($"Time taken to write Asynchronously: {stopwatch.Elapsed}");
        }
    }
}