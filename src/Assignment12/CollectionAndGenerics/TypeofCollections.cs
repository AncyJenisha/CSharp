// <copyright file="TypeofCollections.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ValidatorsApp
{
    /// <summary>
    /// It has the different types of collections.
    /// </summary>
    public enum TypeofCollections
    {
        /// <summary>
        /// Shows options to work with List.
        /// </summary>
        List = 1,

        /// <summary>
        /// Shows the options for Stack.
        /// </summary>
        Stack,

        /// <summary>
        /// Shows the options for Queue.
        /// </summary>
        Queue,

        /// <summary>
        /// Shows the options for Dictionary.
        /// </summary>
        Dictionary,

        /// <summary>
        /// Exits the Collections loop.
        /// </summary>
        Exit,
    }

    /// <summary>
    /// ListOperations has the operations to be performed on BookList.
    /// </summary>
    public enum ListOperations
    {
        /// <summary>
        /// Adds a book name to BookList.
        /// </summary>
        AddBook = 1,

        /// <summary>
        /// Deletes a book name to BookList.
        /// </summary>
        DeleteBook,

        /// <summary>
        /// Displays the BookList.
        /// </summary>
        DisplayBookList,

        /// <summary>
        /// Exits the operations on BookList.
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Has the operations to be performed on the stack.
    /// </summary>
    public enum StackOperations
    {
        /// <summary>
        /// Push a character into the stack.
        /// </summary>
        PushStack = 1,

        /// <summary>
        /// Pops a character into the stack.
        /// </summary>
        PopStack,

        /// <summary>
        /// Display the stack elements.
        /// </summary>
        DisplayStack,

        /// <summary>
        /// Exits the stack operations.
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Has the operations to be performed on Queue.
    /// </summary>
    public enum QueueOperations
    {
        /// <summary>
        /// Addspersons name to the queue
        /// </summary>
        AddQueue = 1,

        /// <summary>
        /// Delete a person name from the queue.
        /// </summary>
        DeleteQueue,

        /// <summary>
        /// Displays the PersonList.
        /// </summary>
        DisplayQueue,

        /// <summary>
        /// Exits from the Queue operations.
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Has the operations to be performed on the dictionary.
    /// </summary>
    public enum DictionaryOperations
    {
        /// <summary>
        /// Adds student name and grades to the dictionary.
        /// </summary>
        AddGrades = 1,

        /// <summary>
        /// Displays the student name and grades.
        /// </summary>
        DisplayGrades,

        /// <summary>
        /// Deletes an element from the Dictionary.
        /// </summary>
        DeleteGrades,

        /// <summary>
        /// Exits the dictionary operation.
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Has the type collection to be recieved as input for getting sum.
    /// </summary>
    public enum TypeOfCollectionForSum
    {
        /// <summary>
        /// Input as list.
        /// </summary>
        List = 1,

        /// <summary>
        /// Input as queue.
        /// </summary>
        Queue,

        /// <summary>
        /// Input as Stack.
        /// </summary>
        Stack,

        /// <summary>
        /// Exits the sum of collections method.
        /// </summary>
        Exit,
    }
}