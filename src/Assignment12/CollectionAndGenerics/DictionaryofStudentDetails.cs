// <copyright file="DictionaryofStudentDetails.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    using System.Collections.Generic;

    /// <summary>
    /// Dictionary class has methods for operations on Dictionary.
    /// </summary>
    public class DictionaryofStudentDetails
    {
        /// <summary>
        /// Gets or sets student name and grades.
        /// </summary>
        /// <value>student name is string and student grade is double.</value>
        public static GenericDictionary<string, float> StudentDetails { get; set; } = new ();

        /// <summary>
        /// Adds Students name and grades to the dictionary.
        /// </summary>
        public static void AddDetails()
        {
            Console.WriteLine("Enter the student name:");
            string studentName = InputValidators.GetStringInput();
            Console.WriteLine("Enter the student's grade:");
            float studentGrade = InputValidators.GetFloatInput();
            StudentDetails.AddStudentDetails(studentName, studentGrade);
        }

        /// <summary>
        /// Removes the element from dictionary.
        /// </summary>
        public static void RemoveDetails()
        {
            Console.WriteLine("Enter the name of the student to be deleted.");
            string nameOfStudentToDelete = InputValidators.GetStringInput();
            StudentDetails.RemoveStudentDetails(nameOfStudentToDelete);
        }
    }
}