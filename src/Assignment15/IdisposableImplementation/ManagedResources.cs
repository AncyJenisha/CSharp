// <copyright file="ManagedResources.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace IdisposableImplementation
{
    /// <summary>
    /// Has the methods for list.
    /// </summary>
    public class ManagedResources : IDisposable
    {
        /// <summary>
        /// Finalizes an instance of the <see cref="ManagedResources"/> class.
        /// </summary>
        ~ManagedResources()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Gets or sets Data has elements as string.
        /// </summary>
        /// <value>List elements as string </value>
        public List<string> Data { get; set; } = new List<string>();

        /// <summary>
        /// Adds content to the list.
        /// </summary>
        /// <param name="data">string entered as input</param>
        public void AddData(string data)
        {
            this.Data.Add(data);
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        public void ClearData()
        {
            this.Data.Clear();
        }

        /// <summary>
        /// Disposes the managed resources.
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
                if (this.Data != null)
                {
                    this.Data.Clear();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}