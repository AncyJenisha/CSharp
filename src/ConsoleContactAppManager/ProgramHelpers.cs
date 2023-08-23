// <copyright file="ProgramHelpers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class ProgramHelpers has methods to perform the functions of the options entered.
    /// </summary>
    internal static class ProgramHelpers
    {
        /// <summary>
        /// EditFields has the fields of the contact from which user can select a field to edit.
        /// </summary>
        private enum EditFields
        {
            Name = 1,
            PhoneNumber,
            EmailId,
            Notes,
        }

        /// <summary>
        /// AddNewContact adds a new contact to the list.
        /// </summary>
        /// <param name="contactList">gets the old list</param>
        /// <returns>Updated List</returns>
        public static List<Contact> AddNewContact(List<Contact> contactList)
        {
            string? name, phone, email, notes;
            int id;
            Console.WriteLine("Enter the Name: ");
            do
            {
                name = GetStringInput();
            }
            while (NameValidate(name) == 0);
            Console.WriteLine("Enter the Phone Number:");
            phone = GetStringInput();
            Console.WriteLine("Enter the Email ID:");
            do
            {
                email = GetStringInput();
            }
            while (EmailValidate(email) == 0);
            Console.WriteLine("Enter notes:");
            notes = GetStringInput();
            id = contactList.Count + 1;
            contactList.Add(new Contact(id, name, phone, email, notes));
            return contactList;
        }

        /// <summary>
        /// DisplayContact method displays the contact list.
        /// </summary>
        /// <param name="contactList">Gets the List of contacts</param>
        public static void DisplayContact(List<Contact> contactList)
        {
            if (!contactList.Any())
            {
                Console.WriteLine("No contacts to display");
                return;
            }

            foreach (var item in contactList)
            {
                Console.WriteLine($"Id:{item.Id}");
                Console.WriteLine($"Name:{item.Name}");
                Console.WriteLine($"Phone Number:{item.PhoneNumber}");
                Console.WriteLine($"Email ID:{item.Email}");
                Console.WriteLine($"Notes:{item.Notes}");
                Console.WriteLine(" ");
            }
        }

        /// <summary>
        /// It searches the Contact List.
        /// </summary>
        /// <param name="contactList">List of stored contacts.</param>
        public static void SearchContact(List<Contact> contactList)
        {
            if (!contactList.Any())
            {
                Console.WriteLine("No Contacts to display");
                return;
            }

            string? nameToSearch;
            List<Contact> searchcontactList = new ();
            Console.WriteLine("Enter the name to search: ");
            nameToSearch = GetStringInput();
            foreach (Contact contact in contactList)
            {
                if (contact.Name == nameToSearch)
                {
                    searchcontactList.Add(contact);
                }
            }

            DisplayContact(searchcontactList);
        }

        /// <summary>
        /// Removes the contact that is to be deleted and updates the list
        /// </summary>
        /// <param name="contactList">updated list</param>
        public static void DeleteContact(List<Contact> contactList)
        {
            if (!contactList.Any())
            {
                Console.WriteLine("No Contacts to display");
                return;
            }

            int newId = 0;
            Console.WriteLine("Enter the ID to be deleted:");
            int idToRemove = GetInput();
            if (idToRemove > 0 && idToRemove < contactList.Count)
            {
                foreach (Contact contact in contactList)
                {
                    if (contact.Id == idToRemove)
                    {
                        contactList.RemoveAt(idToRemove);
                        newId = contact.Id;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter valid id");
            }

            Console.WriteLine("Contact Removed.");
            if (newId > 0)
            {
                for (int i = newId + 1; i > contactList.Count; i++)
                {
                    contactList[i].Id = i + 1;
                }
            }
        }

        /// <summary>
        /// EditContact method changes the list by user and updates the contact list.
        /// </summary>
        /// <param name="contactList">Takes the entire contact list.</param>
        /// <returns>updated list</returns>
        public static List<Contact> EditContact(List<Contact> contactList)
        {
            if (!contactList.Any())
            {
                Console.WriteLine("No contacts to display");
                return contactList;
            }

            string newChange;
            int fieldToEdit, idToEdit;
            Console.WriteLine("Enter the id to change.");
            idToEdit = GetInput();
            Console.WriteLine("1.Change ContactName\n2.Change PhoneNumber\n3.Change Email Id\n4.Change Notes");
            fieldToEdit = GetInput();

            switch (fieldToEdit)
            {
                case (int)EditFields.Name:
                    newChange = GetStringInput();
                    contactList[idToEdit].Name = newChange;
                    break;
                case (int)EditFields.PhoneNumber:
                    newChange = GetStringInput();
                    contactList[idToEdit].PhoneNumber = newChange;
                    break;
                case (int)EditFields.EmailId:
                    newChange = GetStringInput();
                    while (EmailValidate(newChange) == 0)
                    {
                        newChange = GetStringInput();
                    }

                    contactList[idToEdit].Email = newChange;
                    break;
                case (int)EditFields.Notes:
                    newChange = GetStringInput();
                    contactList[idToEdit].Notes = newChange;
                    break;
                default:
                    Console.WriteLine("Enter appropriate field to edit");
                    break;
            }

            return contactList;
        }

        /// <summary>
        /// GetInput method gets input and converts it into integer.
        /// </summary>
        /// <returns>integer</returns>
        public static int GetInput()
        {
            int integer;
            string? n = Console.ReadLine();
            while (!int.TryParse(n, out integer))
            {
                Console.WriteLine("Enter valid Number");
                n = Console.ReadLine();
            }

            return integer;
        }

        /// <summary>
        /// It gets the string and check if it is valid.
        /// </summary>
        /// <returns>Valid String</returns>
        public static string GetStringInput()
        {
            string? n = Console.ReadLine();
            while (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Enter a valid Input");
                n = Console.ReadLine();
            }

            return n;
        }

        /// <summary>
        /// The CheckIfEmpty method checks if the contact list is empty.
        /// </summary>
        /// <param name="contactList"> The contact list is passed as input </param>
        /// <returns>Returns 0 if there is no contact in the list and 1 if the list has contacts</returns>
        public static int CheckIfEmpty(List<Contact> contactList)
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("The contact list is empty");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Validates the email
        /// </summary>
        /// <param name="email"> The email entered by user is validated. </param>
        /// <returns>Returns 0 if email is invalid and 1 if emailis valid.</returns>
        public static int EmailValidate(string email)
        {
            string emailpattern = "^(\\w+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            if (!Regex.IsMatch(email, emailpattern))
            {
                Console.WriteLine("Enter a valid Email");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Validates the name entered by user
        /// </summary>
        /// <param name="name"> The name enetered as string by the user</param>
        /// <returns> Returns 0 if name is invalid and 1 if the name is valid.</returns>
        public static int NameValidate(string name)
        {
            string namepattern = "^(/[A-Z][a-z])+$";
            if (!Regex.IsMatch(name, namepattern))
            {
                Console.WriteLine("Enter correct name");
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
