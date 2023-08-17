// <copyright file="Contacts.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Security.Cryptography.X509Certificates;

namespace ContactManager
{
    public class Contacts
    {
        public string name;
        public string email;
        public string phone;
        public string additionalNotes;
        public Contacts(string name, string email, string phone, string additionalNotes)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.AdditionalNotes = additionalNotes;
        }

        public string Name
        {
            get { return name; }
            set { Name = value; }
        }

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string Phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string AdditionalNotes
        {
            get { return AdditionalNotes; }
            set { AdditionalNotes = value; }
        }
    }
}