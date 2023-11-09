// <copyright file="SortingType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SortUsingDelegates
{
    /// <summary>
    /// Has the enum for type of sorting.
    /// </summary>
    public enum SortingType
    {
        /// <summary>
        /// Calls the method to be sorted by name.
        /// </summary>
        SortByName = 1,

        /// <summary>
        /// Calls the method to be sorted by category
        /// </summary>
        SortByCategory,

        /// <summary>
        /// calls the method to be sorted by price.
        /// </summary>
        SortByPrice,
    }
}