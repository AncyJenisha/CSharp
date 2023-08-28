// <copyright file="ProgramHelpers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    /// <summary>
    /// Class ProgramHelpers has methods to perform the functions of the options entered.
    /// </summary>
    public class ProgramHelpers
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
        /// Gets or sets the contacts to a list.
        /// </summary>
        /// <value>List of objects</value>
        public static List<Contact> ContactList { get; set; } = new List<Contact>();

        /// <summary>
        /// AddNewContact adds a new contact to the list.
        /// </summary>
        public static void AddNewContact()
        {
            Contact contacts = new ();
            do
            {
                Console.WriteLine("\nEnter the Name: ");
                contacts.Name = InputHelpers.GetStringInput();
            }
            while (Validators.NameValidate(contacts.Name) == false);
            do
            {
                Console.WriteLine("Enter the phone Number:");
                contacts.PhoneNumber = InputHelpers.GetStringInput();
            }
            while (Validators.PhoneValidate(contacts.PhoneNumber) == false);
            do
            {
                Console.WriteLine("Enter the Email ID:");
                contacts.Email = InputHelpers.GetStringInput();
            }
            while (Validators.EmailValidate(contacts.Email) == false);
            Console.WriteLine("Enter notes:");
            contacts.Notes = InputHelpers.GetStringInput();
            contacts.Id = ContactList!.Count + 1;
            ContactList.Add(contacts);
        }

        /// <summary>
        /// DisplayContact method displays the contact list.
        /// </summary>
        /// <param name="contactList">Gets the List of contacts</param>
        public static void DisplayContact(List<Contact> contactList)
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("No contacts to display");
                return;
            }
            else
            {
                foreach (var item in contactList)
                {
                    Console.WriteLine($"\nId:{item.Id}");
                    Console.WriteLine($"Name:{item.Name}");
                    Console.WriteLine($"phone Number:{item.PhoneNumber}");
                    Console.WriteLine($"Email ID:{item.Email}");
                    Console.WriteLine($"Notes:{item.Notes}");
                }
            }
        }

        /// <summary>
        /// It searches the Contact List.
        /// </summary>
        public static void SearchContact()
        {
            List<Contact> searchcontactList;

            // To check if there are no contacts in the list.
            if (ContactList!.Count == 0)
            {
                Console.WriteLine("No Contacts to display");
                return;
            }
            else
            {
                string nameToSearch;
                searchcontactList = new ();
                Console.WriteLine("\nEnter the name to search: ");
                nameToSearch = InputHelpers.GetStringInput();
                foreach (Contact contacts in ContactList!)
                {
                    if (contacts.Name is not null)
                    {
                        if (contacts.Name.Contains(nameToSearch))
                        {
                            searchcontactList.Add(contacts);
                        }
                    }
                }
            }

            DisplayContact(searchcontactList);
        }

        /// <summary>
        /// Removes the contact that is to be deleted and updates the list
        /// </summary>
        public static void DeleteContact()
        {
            if (ContactList!.Count == 0)
            {
                Console.WriteLine("\nNo Contacts to display");
                return;
            }
            else
            {
                bool flag = false;
                DisplayContact(ContactList);
                Console.WriteLine("Enter the ID to be deleted:");
                int idToRemove = InputHelpers.GetInput();
                if (idToRemove > 0 && idToRemove <= ContactList!.Count)
                {
                    foreach (Contact contacts in ContactList.ToList())
                    {
                        if (contacts.Id == idToRemove)
                        {
                            ContactList.RemoveAt(idToRemove - 1);
                            flag = true;
                        }
                        else if (flag)
                        {
                            contacts.Id--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid id");
                }

                Console.WriteLine("Contact Removed.");
            }
        }

        /// <summary>
        /// EditContact method changes the list by user and updates the contact list.
        /// </summary>
        public static void EditContact()
        {
            if (ContactList!.Count == 0)
            {
                Console.WriteLine("No contacts to display");
                return;
            }
            else
            {
                string newChange;
                int fieldToEdit, idToEdit;
                DisplayContact(ContactList);
                Console.WriteLine("Enter the id to change.");
                idToEdit = InputHelpers.GetInput();
                int indexChange = idToEdit - 1;
                Console.WriteLine("1.Change ContactName\n2.Change PhoneNumber\n3.Change Email Id\n4.Change Notes");
                Console.WriteLine("Enter the option");
                fieldToEdit = InputHelpers.GetInput();

                switch (fieldToEdit)
                {
                    case (int)EditFields.Name:
                        do
                        {
                            Console.WriteLine("Enter the name");
                            newChange = InputHelpers.GetStringInput();
                        }
                        while (Validators.NameValidate(newChange) == false);
                        ContactList[indexChange].Name = newChange;
                        Console.WriteLine("Contact Name changed.");
                        break;

                    case (int)EditFields.PhoneNumber:
                        do
                        {
                            Console.WriteLine("Enter the Phone Number");
                            newChange = InputHelpers.GetStringInput();
                        }
                        while (Validators.PhoneValidate(newChange) == false);
                        ContactList[indexChange].PhoneNumber = newChange;
                        Console.WriteLine("Contact Number changed.");
                        break;

                    case (int)EditFields.EmailId:
                        do
                        {
                            Console.WriteLine("Enter the EmailId");
                            newChange = InputHelpers.GetStringInput();
                        }
                        while (Validators.EmailValidate(newChange) == false);
                        ContactList[idToEdit - 1].Email = newChange;
                        Console.WriteLine("Contact Email Changed.");
                        break;

                    case (int)EditFields.Notes:
                        Console.WriteLine("Enter the notes");
                        newChange = InputHelpers.GetStringInput();
                        ContactList[indexChange].Notes = newChange;
                        Console.WriteLine("Contact Notes Changed");
                        break;

                    default:
                        Console.WriteLine("Enter appropriate option to edit");
                        break;
                }
            }
        }
    }
}