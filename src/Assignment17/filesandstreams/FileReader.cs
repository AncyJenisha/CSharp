// <copyright file="FileReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace FileProcessor
{
    using System;
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// FileReader has methods to read contents from file.
    /// </summary>
    public class FileReader
    {
        /// <summary>
        /// Reads content from file.
        /// </summary>
        /// <param name="fileName">Name of the file to be read.</param>
        public static void ReadFromFile(string fileName)
        {
            Stopwatch stopwatch = new ();
            FileStream fileStream = new (fileName, FileMode.Open);
            int byteRead = 0;

            stopwatch.Start();
            do
            {
                byte[] buffer = new byte[1024];
                int bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                byteRead += bytesRead;
            }
            while (byteRead < 1000000000);

            stopwatch.Stop();

            Console.WriteLine($"Time for reading file using buffer: {stopwatch.Elapsed}");
            fileStream.Close();
        }

        /// <summary>
        /// Reads content from file using buffered Stream.
        /// </summary>
        /// <param name="fileName">Name of the file to be read using bufferedstream</param>
        public static void ReadUsingBufferedStream(string fileName)
        {
            byte[] buffer = new byte[1024];
            FileStream fileStream = new (fileName, FileMode.Open);
            using BufferedStream bufferedStream = new (fileStream);
            long bytesReceived = 0;
            int numberOfBytesToRead = buffer.Length;

            Stopwatch stopwatch = new ();
            stopwatch.Start();

            while (numberOfBytesToRead > 0)
            {
                int bytesRead = bufferedStream.Read(buffer, 0, 1024);
                if (numberOfBytesToRead == 0)
                {
                    break;
                }

                bytesReceived += bytesRead;
                numberOfBytesToRead -= bytesRead;
            }

            fileStream.Close();

            stopwatch.Stop();

            Console.WriteLine($"Time taken to read using bufferStream:{stopwatch.Elapsed}\n");
        }

        /// <summary>
        /// Reads all content of file using async.
        /// </summary>
        /// <param name="fileName">Name of the file to be read asynchronously</param>
        /// <returns>Task object.</returns>
        public static async Task ReadUsingBufferedStreamAsync(string fileName)
        {
            byte[] buffer = new byte[1024];
            using FileStream fileStream = new (fileName, FileMode.Open);
            using BufferedStream bufferedStream = new (fileStream);
            long bytesReceived = 0;
            int numberOfBytesToRead = buffer.Length;

            Stopwatch stopwatch = new ();
            stopwatch.Start();

            while (numberOfBytesToRead > 0)
            {
                int bytesRead = await bufferedStream.ReadAsync(buffer, 0, 1024);
                if (numberOfBytesToRead == 0)
                {
                    break;
                }

                bytesReceived += bytesRead;
                numberOfBytesToRead -= bytesRead;
            }

            stopwatch.Stop();

            Console.WriteLine($"Time taken to read Asynchronously:{stopwatch.Elapsed}");
        }
    }
}