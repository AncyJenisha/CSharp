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
        /// Gets or sets the contacts to a list.
        /// </summary>
        /// <value>List of objects</value>
        public static List<Contact> ContactList { get; set; } = new List<Contact>();

        /// <summary>
        /// AddNewContact adds a new contact to the list.
        /// </summary>
        public static void AddNewContact()
        {
            Contact contact = new ();
            do
            {
                Console.WriteLine("\nEnter the Name: ");
                contact.Name = InputHelpers.GetStringInput();
            }
            while (Validators.NameValidate(contact.Name) == false);
            do
            {
                Console.WriteLine("Enter the phone Number:");
                contact.PhoneNumber = InputHelpers.GetStringInput();
            }
            while (Validators.PhoneValidate(contact.PhoneNumber) == false);
            do
            {
                Console.WriteLine("Enter the Email ID:");
                contact.Email = InputHelpers.GetStringInput();
            }
            while (Validators.EmailValidate(contact.Email) == false);
            Console.WriteLine("Enter notes:");
            contact.Notes = InputHelpers.GetStringInput();
            contact.Id = ContactList!.Count + 1;
            ContactList.Add(contact);
        }

        /// <summary>
        /// DisplayContact method displays the contact list.
        /// </summary>
        /// <param name="item">Gets the List of contacts.</param>
        public static void DisplayContact(Contact item)
        {
            Console.WriteLine($"\nId:{item.Id}\nName:{item.Name}\nPhone Number:{item.PhoneNumber}\nEmail Id:{item.Email}\nNotes:{item.Notes}");
        }

        /// <summary>
        /// It searches the Contact List.
        /// </summary>
        public static void SearchContact()
        {
            // To check if there are no contacts in the list.
            if (ContactList!.Count == 0)
            {
                Console.WriteLine("No Contacts to display");
                return;
            }
            else
            {
                string nameToSearch;
                Console.WriteLine("\nEnter the name to search: ");
                nameToSearch = InputHelpers.GetStringInput();
                foreach (Contact contact in ContactList!)
                {
                    if (contact.Name is not null)
                    {
                        if (contact.Name.Contains(nameToSearch))
                        {
                            DisplayContact(contact);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Removes the contact that is to be deleted and updates the list
        /// </summary>
        public static void DeleteContact()
        {
            if (ContactList.Count == 0)
            {
                Console.WriteLine("\nNo Contacts to display");
                return;
            }
            else
            {
                bool flag = false;
                foreach (var item in ProgramHelpers.ContactList)
                {
                    ProgramHelpers.DisplayContact(item);
                }

                Console.WriteLine("\nEnter the ID to be deleted:");
                int idToRemove = InputHelpers.GetInput();
                if (idToRemove > 0 && idToRemove <= ContactList.Count)
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

                    Console.WriteLine("Contact Removed.");

                }

                else
                {
                    Console.WriteLine("Enter valid id");
                }
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
                if (ProgramHelpers.ContactList.Count == 0)
                {
                    Console.WriteLine("No contacts to display");
                    return;
                }
                else
                {
                    foreach (var item in ProgramHelpers.ContactList)
                    {
                        ProgramHelpers.DisplayContact(item);
                    }
                }

                do
                {
                    Console.WriteLine("\nEnter the id to change.");
                    idToEdit = InputHelpers.GetInput();
                    if (idToEdit <= 0 || idToEdit > ContactList.Count)
                    {
                        Console.WriteLine("Enter the correct id");
                    }
                }
                while (idToEdit <= 0 || idToEdit > ProgramHelpers.ContactList.Count);
                int indexChange = idToEdit - 1;
                Console.WriteLine("1.Change ContactName\n2.Change PhoneNumber\n3.Change Email Id\n4.Change Notes\n");
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