// <copyright file="enums.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ContactManagerApp
{
    /// <summary>
    /// Options has the different options for the user to perform.
    /// </summary>
    public enum Options
    {
        /// <summary>
        /// Adds new contact to the list.
        /// </summary>
        AddNewContact = 1,

        /// <summary>
        /// Displays the contacts in the list.
        /// </summary>
        Display,

        /// <summary>
        /// Searches the list for the name given by the user.
        /// </summary>
        Search,

        /// <summary>
        /// Edits the contacts to the data given by user.
        /// </summary>
        Edit,

        /// <summary>
        /// Removes the contact from the user.
        /// </summary>
        Delete,

        /// <summary>
        /// Stops the process and exits the program.
        /// </summary>
        Stop,
    }

    /// <summary>
    /// EditFields has the attributes of the contact from which user can select to edit.
    /// </summary>
    public enum EditFields
    {
        /// <summary>
        /// Edits name of the contact to the name given by user.
        /// </summary>
        Name = 1,

        /// <summary>
        /// Changes the Phone number of the contact to the number entered by user.
        /// </summary>
        PhoneNumber,

        /// <summary>
        /// Changes email id to the new email id entered by user.
        /// </summary>
        EmailId,

        /// <summary>
        /// Changes the notes to the new notes entered by user.
        /// </summary>
        Notes,
    }
}
