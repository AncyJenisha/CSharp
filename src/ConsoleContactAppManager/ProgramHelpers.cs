// <copyright file="ProgramHelpers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
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
            name = GetStringInput();
            Console.WriteLine("Enter the Phone Number:");
            phone = GetStringInput();
            Console.WriteLine("Enter the Email ID:");
            email = GetStringInput();
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
            if (contactList.Count == 0)
            {
                Console.WriteLine("No contact to display");
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
            int newId = 0;
            DisplayContact(contactList);
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
            string newChange;
            int fieldToEdit, idToEdit;
            DisplayContact(contactList);
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
    }
}
