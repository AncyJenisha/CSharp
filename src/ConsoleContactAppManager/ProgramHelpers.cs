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
        /// EditFields has the attributes of the contact from which user can select to edit.
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
            do
            {
                Console.WriteLine("Enter the Name: ");
                name = Validators.GetStringInput();
            }
            while (Validators.NameValidate(name) == 0);
            do
            {
                Console.WriteLine("Enter the phone Number:");
                phone = Validators.GetStringInput();
            }
            while (Validators.PhoneValidate(phone) == 0);
            do
            {
                Console.WriteLine("Enter the Email ID:");
                email = Validators.GetStringInput();
            }
            while (Validators.EmailValidate(email) == 0);
            Console.WriteLine("Enter notes:");
            notes = Validators.GetStringInput();
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
                Console.WriteLine($"phone Number:{item.PhoneNumber}");
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
            // To check if there are no contacts in the list.
            if (!contactList.Any())
            {
                Console.WriteLine("No Contacts to display");
                return;
            }

            string nameToSearch;
            List<Contact> searchcontactList = new ();
            Console.WriteLine("Enter the name to search: ");
            nameToSearch = Validators.GetStringInput();
            foreach (Contact contact in contactList)
            {
                if (contact.Name is not null) // To change null state to non-null state before dereferencing.
                {
                    if (contact.Name.Contains(nameToSearch))
                    {
                        searchcontactList.Add(contact);
                    }
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

            bool flag = false;
            DisplayContact(contactList);
            Console.WriteLine("Enter the ID to be deleted:");
            int idToRemove = Validators.GetInput();
            if (idToRemove > 0 && idToRemove <= contactList.Count)
            {
                foreach (Contact contact in contactList.ToList())
                {
                    if (contact.Id == idToRemove)
                    {
                        contactList.RemoveAt(idToRemove - 1);
                        flag = true;
                    }

                    // To update the contact id after deletion of a contact.
                    else if (flag)
                    {
                        contact.Id--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter valid id");
            }

            Console.WriteLine("Contact Removed.");
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
            DisplayContact(contactList);
            Console.WriteLine("Enter the id to change.");
            idToEdit = Validators.GetInput();
            int indexChange = idToEdit - 1;
            Console.WriteLine("1.Change ContactName\n2.Change PhoneNumber\n3.Change Email Id\n4.Change Notes");
            Console.WriteLine("Enter the option");
            fieldToEdit = Validators.GetInput();

            switch (fieldToEdit)
            {
                case (int)EditFields.Name:
                    do
                    {
                        Console.WriteLine("Enter the name");
                        newChange = Validators.GetStringInput();
                    }
                    while (Validators.NameValidate(newChange) == 0);
                    contactList[indexChange].Name = newChange;
                    Console.WriteLine("Contact Name changed.");
                    break;

                case (int)EditFields.PhoneNumber:
                    do
                    {
                        Console.WriteLine("Enter the Phone Number");
                        newChange = Validators.GetStringInput();
                    }
                    while (Validators.PhoneValidate(newChange) == 0);
                    contactList[indexChange].PhoneNumber = newChange;
                    Console.WriteLine("Contact Number changed.");
                    break;

                case (int)EditFields.EmailId:
                    do
                    {
                        Console.WriteLine("Enter the EmailId");
                        newChange = Validators.GetStringInput();
                    }
                    while (Validators.EmailValidate(newChange) == 0);
                    contactList[idToEdit - 1].Email = newChange;
                    Console.WriteLine("Contact Email Changed.");
                    break;

                case (int)EditFields.Notes:
                    Console.WriteLine("Enter the notes");
                    newChange = Validators.GetStringInput();
                    contactList[indexChange].Notes = newChange;
                    Console.WriteLine("Contact Notes Changed");
                    break;

                default:
                    Console.WriteLine("Enter appropriate option to edit");
                    break;
            }

            return contactList;
        }
    }
}