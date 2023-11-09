// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace MemoryLeakInvestigator
{
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Program class has main method which Writes and reads a file.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to understand the memory leaks.
        /// </summary>
        public static void Main()
        {
            string path = "CodeOptimzation.txt";
            string data = "This is some test data";

            using (FileStream fileStream = new (path, FileMode.Create))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                Console.WriteLine(buffer);
                fileStream.Write(buffer, 0, buffer.Length);
            }

            Stopwatch stopwatch = new ();
            UTF8Encoding encoder = new ();
            stopwatch.Start();

            using (FileStream fileStream = new (path, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                while (fileStream.Read(buffer, 0, buffer.Length) > 0)
                {
                    Console.WriteLine(encoder.GetString(buffer));
                }
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}