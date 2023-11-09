// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SortUsingDelegates
{
    /// <summary>
    /// Class product has the properties defined for the products.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>Name as String</value>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        /// <value>Category as string</value>
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        /// <value>Price as float</value>
        public float Price { get; set; }
    }
}