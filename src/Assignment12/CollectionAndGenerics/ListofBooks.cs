// <copyright file="ListofBooks.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// It has methods to add, delete and display the bookList.
    /// </summary>
    /// <typeparam name = "T" >The value is string.</typeparam>
    public static class ListofBooks
    {
        /// <summary>
        /// Gets or Sets book names.
        /// </summary>
        /// <value>Boookname as string</value>
        public static GenericList<string> ListObj { get; set; } = new GenericList<string>();

        /// <summary>
        /// Adds a book name to the BookList
        /// </summary>
        public static void AddBooks()
        {
            Console.WriteLine("Enter the Book name");
            string bookName = InputValidators.GetStringInput();
            ListObj.Add(bookName);
        }

        /// <summary>
        /// Removes a book name from BookList
        /// </summary>
        public static void RemoveBooks()
        {
            Console.WriteLine("Enter the serial number of book to be deleted.");
            int idOfBookToDelete = InputValidators.GetIntegerInput();
            if (ListObj.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else if (idOfBookToDelete > 0 && idOfBookToDelete <= ListObj.Count)
            {
                ListObj.RemoveAt(idOfBookToDelete - 1);
                Console.WriteLine("Book Name Removed");
            }
            else
            {
                Console.WriteLine("Enter a valid index");
            }
        }
    }
}