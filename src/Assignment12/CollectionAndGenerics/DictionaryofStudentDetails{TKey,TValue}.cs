// <copyright file="DictionaryofStudentDetails{TKey,TValue}.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    using System.Collections.Generic;

    /// <summary>
    /// Dictionary class has methods for operations on Dictionary.
    /// </summary>
    /// <typeparam name = "TKey" >The key is string type.</typeparam>
    /// <typeparam name = "TValue" >The value is double type.</typeparam>
    /// <value>Dictionary of string key and double values.</value>
    public class DictionaryofStudentDetails<TKey, TValue>
    {
        /// <summary>
        /// Gets or sets student name and grades.
        /// </summary>
        /// <value>student name is string and student grade is double.</value>
        public static Dictionary<TKey, T> StudentDetails { get; set; } = new ();

        /// <summary>
        /// Adds Students name and grades to the dictionary.
        /// </summary>
        public void AddDetails()
        {
            Console.WriteLine("Enter the student name\n");
            string studentName = InputValidators.GetValidInput<string>();
            Console.WriteLine("Enter the student's grade\n");
            float studentGrade = InputValidators.GetValidInput<float>();
            StudentDetails.Add((TKey)(object)studentName, (TValue)(object)studentGrade);
        }

        /// <summary>
        /// Removes the element from dictionary.
        /// </summary>
        public void RemoveDetails()
        {
            string nameOfStudentToDelete = InputValidators.GetValidInput<string>();
            foreach (var studentName in StudentDetails)
            {
                if (studentName.Equals(nameOfStudentToDelete))
                {
                    StudentDetails.Remove((TKey)(object)nameOfStudentToDelete);
                    Console.WriteLine("Student details removed\n");
                    return;
                }
            }

            Console.WriteLine("Enter the correct student name\n");
        }
    }
}