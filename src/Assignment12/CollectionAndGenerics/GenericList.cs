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
        public static List<T> Books { get; set; } = new ();

        /// <summary>
        /// Gets count of the Books.
        /// </summary>
        /// <value>
        /// Count of the Books.
        public int Count => Books.Count;

        /// <summary>
        /// jhghfh
        /// </summary>
        /// <param name="bookName">hjghj</param>
        public void Add(T bookName)
        {
            Books.Add(bookName);
        }

        /// <summary>
        /// Removes element of the generic Books.
        /// </summary>
        /// <param name="index">Index of the element to be removed.</param>
        public void RemoveAt(int index)
        {
            Books.RemoveAt(index);
        }

        /// <summary>
        /// Displays the BookList.
        /// </summary>
        public void DisplayBookList()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books to display");
            }
            else
            {
                Console.WriteLine("The Book List");
                foreach (var bookName in Books)
                {
                    Console.WriteLine(bookName);
                }
            }
        }
    }
}