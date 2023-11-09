// <copyright file="Book.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ManipulatingRecords
{
    public record Book(string title, string author, long isbn);

    /// <summary>
    /// Has the method for displaying record class.
    /// </summary>
    public static class RecordDisplayer
    {
        /// <summary>
        /// Displays the book details.
        /// </summary>
        /// <param name="book">book as a record</param>
        public static void DisplayBookRecord(Book book)
        {
            var (bookTitle, authorName, isbn) = book;
            Console.WriteLine($"Book Details\n{bookTitle} by {authorName}\nISBN:{isbn}");
        }
    }
}