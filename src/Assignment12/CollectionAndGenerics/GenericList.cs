// <copyright file="GenericList.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// Generic
    /// </summary>
    /// <typeparam name="T">fskjdf</typeparam>
    public class GenericList<T>
    {
        /// <summary>
        /// Gets or sets the books list in generic type.
        /// </summary>
        /// <value>Book name as String</value>
        public List<T> GenericListOfBooks { get; set; } = new List<T>();

        /// <summary>
        /// Gets count of the GenericListOfBooks.
        /// </summary>
        /// <value>
        /// Count of the GenericListOfBooks.
        /// </value>
        public int Count => this.GenericListOfBooks.Count;

        /// <summary>
        /// jhghfh
        /// </summary>
        /// <param name="bookName">hjghj</param>
        public void Add(T bookName)
        {
            this.GenericListOfBooks.Add(bookName);
        }

        /// <summary>
        /// Removes element of the generic GenericListOfBooks.
        /// </summary>
        /// <param name="index">Index of the element to be removed.</param>
        public void RemoveAt(int index)
        {
            this.GenericListOfBooks.RemoveAt(index);
        }

        /// <summary>
        /// Displays the BookList.
        /// </summary>
        public void DisplayBookList()
        {
            Console.WriteLine("The Book List\n");
            foreach (var bookName in this.GenericListOfBooks)
            {
                Console.WriteLine(bookName);
            }
        }
    }
}