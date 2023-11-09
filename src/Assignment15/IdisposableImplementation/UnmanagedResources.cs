// <copyright file="UnmanagedResources.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace IdisposableImplementation
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Has the methods for Write and close unmanaged resources.
    /// </summary>
    public class UnmanagedResources : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnmanagedResources"/> class.
        /// </summary>
        /// <param name="filePath">Directory location as string</param>
        public UnmanagedResources(string filePath)
        {
            FileWriter = new StreamWriter(filePath);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="UnmanagedResources"/> class.
        /// </summary>
        ~UnmanagedResources()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Gets or sets the file writer.
        /// </summary>
        /// <value>Filewriter</value>
        public static StreamWriter? FileWriter { get; set; }

        /// <summary>
        /// Writes content to file.
        /// </summary>
        /// <param name="content">Content entered as string</param>
        public void WriteToFile(string content)
        {
            FileWriter?.Write(content);
        }

        /// <summary>
        /// Closes the file.
        /// </summary>
        public void CloseFile()
        {
            FileWriter?.Close();
        }

        /// <summary>
        /// Disposes the fileWriter
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Disposes the file.
        /// </summary>
        /// <param name="disposing">state of disposed file</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (FileWriter != null)
                {
                    FileWriter.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}