// <copyright file="FileOperations.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace IDisposableDemo
{
    /// <summary>
    /// Class has methods to write and read contents of file.
    /// </summary>
    public class FileOperations : IDisposable
    {
        /// <summary>
        /// Writes contents to a file.
        /// </summary>
        public static void WriteToFile()
        {
            string? contentstoadd;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Ancy.Vijayaraj\Desktop\CSharpTips\CSharp\src\Assignment8\IDisposableDemo\Task8.txt"))
            {
                Console.WriteLine("Enter your contents here:");
                Console.WriteLine("Enter q to Quit");
                do
                {
                    contentstoadd = Console.ReadLine();
                    sw.WriteLine(contentstoadd);
                }
                while (contentstoadd != "q");
                sw.Dispose();
                Console.WriteLine("Content successfully written on file.\n\n");
            }
        }

        /// <summary>
        /// Read contents from file and displays it.
        /// </summary>
        public static void ReadFromFile()
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\Ancy.Vijayaraj\Desktop\CSharpTips\CSharp\src\Assignment8\IDisposableDemo\Task8.txt"))
            {
                string? content = null;

                while ((content = sr.ReadLine()) != "q")
                {
                    Console.WriteLine("{0}", content);
                }

                Console.WriteLine("\nContents Printed.");
            }
        }

        /// <summary>
        /// Disposes the file after use.
        /// </summary>
        public void Dispose()
        {
        }
    }
}