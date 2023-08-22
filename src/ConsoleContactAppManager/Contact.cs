// <copyright file="Contact.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    /// <summary>
    /// Class Contact has  name, phone number, email, notes as properties.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// Constructor Contact passes the input from user.
        /// </summary>
        /// <param name="name">Name as string</param>
        /// <param name="phoneNumber">PhoneNumber</param>
        /// <param name="email">Email of object 'contact'</param>
        /// <param name="notes">Has additional notes</param>
        /// <param name="id">Has the unique id for the contact</param>
        public Contact(int id, string? name, string? phoneNumber, string? email, string? notes)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or sets stores Name of the person
        /// </summary>
        /// <value>string</value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets stores PhoneNumber.
        /// </summary>
        /// <value>string
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets stores Email ID.
        /// </summary>
        /// <value>string</value>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets stores Notes.
        /// </summary>
        /// <value>string</value>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the serial number of the contact.
        /// </summary>
        /// <value>Id in integer</value>
        public int Id { get; set; }
    }
}