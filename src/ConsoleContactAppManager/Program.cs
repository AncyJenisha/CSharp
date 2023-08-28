// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    /// <summary>
    /// Program class has the options to perform and it recives the option from user.
    /// </summary>
    internal partial class Program
    {
        /// <summary>
        /// Main Method has displays the options of the tasks and call the methods for the option chosen.
        /// </summary>
        /// <param name="args">string</param>
        public static void Main()
        {
            int option;

            do
            {
                Console.WriteLine("\n1.AddNewContact\n 2.Display\n 3.Search\n 4.Edit\n 5.Delete\n 6.Exit\n");
                Console.WriteLine("Enter your option:");
                option = InputHelpers.GetInput();

                switch (option)
                {
                    case (int)Options.AddNewContact:
                        ProgramHelpers.AddNewContact();
                        break;
                    case (int)Options.Display:
                        ProgramHelpers.DisplayContact(ProgramHelpers.ContactList!);
                        break;
                    case (int)Options.Search:
                        ProgramHelpers.SearchContact();
                        break;
                    case (int)Options.Edit:
                        ProgramHelpers.EditContact();
                        break;
                    case (int)Options.Delete:
                        ProgramHelpers.DeleteContact();
                        break;
                    case (int)Options.Stop:
                        return;
                    default:
                        Console.WriteLine("Enter a valid Option");
                        break;
                }
            }
            while (true);
        }
    }
}
