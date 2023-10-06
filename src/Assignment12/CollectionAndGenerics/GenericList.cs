// <copyright file="GenericList.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// Class with methods for generic list.
    /// </summary>
    /// <typeparam name="T">Generic Type parameter.</typeparam>
    public class GenericList<T>
    {
        /// <summary>
        /// Gets or sets the books list in generic type.
        /// </summary>
        /// <value>Book name as String</value>
        public static List<T> GenericListOfBooks { get; set; } = new ();

        /// <summary>
        /// Gets count of the GenericListOfBooks.
        /// </summary>
        /// <value>
        /// Count of the GenericListOfBooks.
        public int Count => GenericListOfBooks.Count;

        /// <summary>
        /// jhghfh
        /// </summary>
        /// <param name="bookName">hjghj</param>
        public void Add(T bookName)
        {
            GenericListOfBooks.Add(bookName);
        }

        /// <summary>
        /// Removes element of the generic GenericListOfBooks.
        /// </summary>
        /// <param name="index">Index of the element to be removed.</param>
        public void RemoveAt(int index)
        {
            GenericListOfBooks.RemoveAt(index);
        }

        /// <summary>
        /// Displays the BookList.
        /// </summary>
        public void DisplayBookList()
        {
            if (GenericListOfBooks.Count == 0)
            {
                Console.WriteLine("No books to display");
            }
            else
            {
                Console.WriteLine("The Book List");
                foreach (var bookName in GenericListOfBooks)
                {
                    Console.WriteLine(bookName);
                }
            }
        }
    }
}