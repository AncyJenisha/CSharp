// <copyright file="Products.cs" company="PlaceholderCompany">
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
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="productId">The productId as integer</param>
        /// <param name="productPrice">The product price as float</param>
        /// <param name="productName">The product name as string</param>
        /// <param name="productCategory">The product category as string</param>
        public Product(int productId, float productPrice, string? productName, string? productCategory)
        {
            this.ProductId = productId;
            this.ProductPrice = productPrice;
            this.ProductName = productName;
            this.ProductCategory = productCategory;
        }

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