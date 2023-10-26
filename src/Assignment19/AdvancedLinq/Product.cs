// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Has the product details as properties.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique id of the product.
        /// </summary>
        /// <value>ID of the product as list</value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        /// <value>Price of the product as float</value>
        public float ProductPrice { get; set; }

        /// <summary>
        /// Gets or sets the name of the product
        /// </summary>
        /// <value>Name of the product as string</value>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        /// <value>Category of the product as string</value>
        public string? ProductCategory { get; set; }
    }
}