// <copyright file="Products.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    /// <summary>
    /// Products class has the class defined for the Product, with id, price, quantity, name.
    /// </summary>
    public class Products
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Products"/> class.
        /// </summary>
        /// <param name="productName">Name of the product</param>
        /// <param name="quantity">Number of products put up for sale.</param>
        /// <param name="price">Price of the product.</param>
        /// <param name="id">serial number for the product.</param>
        public Products(int id, string productName, int quantity, double price)
        {
            this.Id = id;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Products"/> class.
        /// </summary>
        public Products()
        {
        }

        /// <summary>
        /// Gets or sets the Serial number of the product.
        /// </summary>
        /// <value>Integer as serial number.</value>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        /// <value>Product name as string</value>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets or sets Quantity of the products put up for sale.
        /// </summary>
        /// <value>Quantity as an integer</value>
        public int? Quantity { get; set; }

        /// <summary>
        /// gets or sets the Price of the product.
        /// </summary>
        /// <value>Price as double</value>
        public double? Price { get; set; }
    }
}