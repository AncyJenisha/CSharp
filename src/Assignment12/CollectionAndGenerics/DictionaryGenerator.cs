// <copyright file="DictionaryGenerator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace CollectionAndGenerics
{
    using ValidatorsApp;

    /// <summary>
    /// Has a method that Creates Dictionary.
    /// </summary>
    public class DictionaryGenerator
    {
        /// <summary>
        /// Creates a readonly dictionary.
        /// </summary>
        /// <param name="employeeDetails">Dictionary of employee details.</param>
        /// <returns>A readonly Dictionary of employee details.</returns>
        public static IReadOnlyDictionary<int, string> CreateDictionary(Dictionary<int, string> employeeDetails)
        {
            IReadOnlyDictionary<int, string> readOnlyEmployeeDetails = employeeDetails;
            return readOnlyEmployeeDetails;
        }
    }
}