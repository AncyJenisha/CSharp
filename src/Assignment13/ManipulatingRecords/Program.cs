// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ManipulatingRecords
{
    /// <summary>
    /// Program class has the main method
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Method gets the input from user.
        /// </summary>
        public static void Main()
        {
            Book firstBook = new ("The Alchemist", "Paulo Coelho", 9788172234980);
            Book secondBook = new ("Paradise Lost", "John Milton", 9781684221196);
            Book thirdBook = new ("The Alchemist", "Paulo Coelho", 9788172234980);
            if (firstBook == thirdBook)
            {
                Console.WriteLine("\nBook1 and Book3 are same");
            }
            else
            {
                Console.WriteLine("\nBook1 and Book3 are not same");
            }

            Book fourthBook = secondBook with { title = "Paradise Regained", isbn = 9788172235987 };
            Console.WriteLine($"\nBefore:{secondBook}\nAfter:{fourthBook}\n");
            RecordDisplayer.DisplayBookRecord(firstBook);
        }
    }
}