// <copyright file="ChoiceOfOperation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Has the choice of operations to be recieved from user.
    /// </summary>
    public enum ChoiceOfOperation
    {
        /// <summary>
        /// Calls the methods which filters the product list and sorts them by price.
        /// </summary>
        BasicLinqQueries = 1,

        /// <summary>
        /// Calls the method which groups the products.
        /// </summary>
        GroupProductsBasedOnCategory,

        /// <summary>
        /// Calls the method which joins the products and suppliers.
        /// </summary>
        JoinProductsAndSupplier,

        /// <summary>
        /// Calls the method which generate unique number pairs that add up to the given target sum.
        /// </summary>
        LinqToObjects,

        /// <summary>
        /// Calls the method which filters and sorts the books from the product list.
        /// </summary>
        PerformanceConsiderationsOfLinq,

        /// <summary>
        /// Calls the method that gets a function and sorts the list by it.
        /// </summary>
        AdvancedLinqFeatures,

        /// <summary>
        /// Calls the method which sorts the list based on the property specified by user.
        /// </summary>
        FilterByExpresssionTree,

        /// <summary>
        /// Calls the method which uses the BuildQuery.
        /// </summary>
        UsingQueryBuilder,

        /// <summary>
        /// Exits the program.
        /// </summary>
        Exit,
    }
}