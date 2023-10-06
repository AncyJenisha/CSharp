// <copyright file="GenericDictionary.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Has methods for operations on Generic Dictionary.
    /// </summary>
    /// <typeparam name="TKey">Generic type for the Student name</typeparam>
    /// <typeparam name="TValue">Generic type for student grade.</typeparam>
    public class GenericDictionary<TKey, TValue>
         where TKey : notnull
    {
        /// <summary>
        /// Gets or sets the student details to the generic dictionary.
        /// </summary>
        /// <value>Generic type of student name and grade.</value>
        public static Dictionary<TKey, TValue> GenericDictionaryOfStudentDetails { get; set; } = new ();

        /// <summary>
        /// Gets the count of Generic Dictionary.
        /// </summary>
        /// <value>Key as string and value as float</value>
        public int GenericDictionaryCount => GenericDictionaryOfStudentDetails.Count;

        /// <summary>
        /// Adds the student name and grade to the dictionary.
        /// </summary>
        /// <param name="studentName">Student name as Generic type</param>
        /// <param name="studentGrade">Grade of students as Generic Type.</param>
        public void AddStudentDetails(TKey studentName, TValue studentGrade)
        {
            GenericDictionaryOfStudentDetails.Add(studentName, studentGrade);
        }

        /// <summary>
        /// Removes the student details from the Gneric Dictionary.
        /// </summary>
        /// <param name="studentName"> Name of student to be removed.</param>
        public void RemoveStudentDetails(TKey studentName)
        {
            if (GenericDictionaryOfStudentDetails.ContainsKey(studentName))
            {
                GenericDictionaryOfStudentDetails.Remove(studentName);
                Console.WriteLine("Student details removed\n");
                return;
            }
            else
            {
                Console.WriteLine("Enter the correct student name\n");
            }
        }

        /// <summary>
        /// Displays The student details from the generic Dictionary.
        /// </summary>
        public void DisplayStudentDetails()
        {
            if (this.GenericDictionaryCount == 0)
            {
                Console.WriteLine("No student details available");
            }
            else
            {
                foreach (var student in GenericDictionaryOfStudentDetails)
                {
                    Console.WriteLine($"Student Name:{student.Key} Grade:{student.Value}");
                }
            }
        }
    }
}