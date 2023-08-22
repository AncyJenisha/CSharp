// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    /// <summary>
    /// Program class has the options to perform and it recives the option from user.
    /// </summary>
    internal class Program
    {
        private enum Options
        {
            AddNewContact = 1,
            Display,
            Search,
            Edit,
            Delete,
            Stop,
        }

        /// <summary>
        /// Main Method has displays the options of the tasks and call the methods for the option chosen.
        /// </summary>
        /// <param name="args">Gets the options and calls the method.</param>
        /// <returns>Returns zero to stop the application.</returns>
        public static int Main(string[] args)
        {
            List<Contact> contactList = new ();

            int option;

            // string name, phone, email, notes;
            do
            {
                Console.WriteLine("1.AddNewContact 2.Display 3.Search 4.Edit 5.Delete 6.Exit");
                Console.WriteLine("Enter your option:");
                option = ProgramHelpers.GetInput();

                switch (option)
                {
                    case (int)Options.AddNewContact:
                        contactList = ProgramHelpers.AddNewContact(contactList);
                        break;
                    case (int)Options.Display:
                        ProgramHelpers.DisplayContact(contactList);
                        break;
                    case (int)Options.Search:
                        ProgramHelpers.SearchContact(contactList);
                        break;
                    case (int)Options.Edit:
                        ProgramHelpers.EditContact(contactList);
                        break;
                    case (int)Options.Delete:
                        ProgramHelpers.DeleteContact(contactList);
                        break;
                    case (int)Options.Stop:
                        return 0;
                    default:
                        Console.WriteLine("Enter a valid Option");
                        break;
                }
            }
            while (true);
        }
    }
}
