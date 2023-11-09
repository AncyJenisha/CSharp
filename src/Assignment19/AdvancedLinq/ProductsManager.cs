// <copyright file="ProductsManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Has the methods to manage list of products.
    /// </summary>
    public class ProductsManager
    {
        /// <summary>
        /// Gets or sets the list of products with thier details.
        /// </summary>
        /// <value>The products as objects</value>
        public static List<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Adds Default products to the list.
        /// </summary>
        public void IntializeWithDefaultProducts()
        {
            Product firstProduct = new (1, 300F, "Mobile Phone", "Electronics");
            Products.Add(firstProduct);

            Product secondProduct = new (2,600f, "Laptop", "Electronics");
            Products.Add(secondProduct);

            Product thirdProduct = new(3, 6000f, "Bed", "Furniture");
            Products.Add(thirdProduct);

            Product fourthProduct = new (4, 1.50F, "Hide and seek", "Snacks");
            Products.Add(fourthProduct);

            Product fifthProduct = new (5, 0.5F, "KitKat", "Snacks");
            Products.Add(fifthProduct);

            Product sixthProduct = new (6, 15F, "The Alchemist", "Books");
            Products.Add(sixthProduct);

            Product seventhProduct = new (7, 20F, "Paradise Lost", "Books");
            Products.Add(seventhProduct);
        }
    }
}