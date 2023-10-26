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
        public static List<Product> ProductsList { get; set; } = new List<Product>();

        /// <summary>
        /// Adds Default products to the list.
        /// </summary>
        public void IntializeWithDefaultProducts()
        {
            Product firstProduct = new ();
            firstProduct.ProductId = 1;
            firstProduct.ProductName = "Mobile Phone";
            firstProduct.ProductCategory = "Electronics";
            firstProduct.ProductPrice = 300;

            ProductsList.Add(firstProduct);

            Product secondProduct = new ();

            secondProduct.ProductId = 2;
            secondProduct.ProductName = "Laptop";
            secondProduct.ProductCategory = "Electronics";
            secondProduct.ProductPrice = 600;

            ProductsList.Add(secondProduct);

            Product thirdProduct = new ();
            thirdProduct.ProductId = 3;
            thirdProduct.ProductName = "Bed";
            thirdProduct.ProductCategory = "Furniture";
            thirdProduct.ProductPrice = 6000;

            ProductsList.Add(thirdProduct);

            Product fourthProduct = new ();
            fourthProduct.ProductId = 4;
            fourthProduct.ProductName = "Hide and seek";
            fourthProduct.ProductCategory = "Snacks";
            fourthProduct.ProductPrice = 1.50F;

            ProductsList.Add(fourthProduct);

            Product fifthProduct = new ();
            fifthProduct.ProductId = 5;
            fifthProduct.ProductName = "KitKat";
            fifthProduct.ProductCategory = "Snacks";
            fifthProduct.ProductPrice = 0.5F;

            ProductsList.Add(fifthProduct);

            Product sixthProduct = new ();
            sixthProduct.ProductId = 6;
            sixthProduct.ProductName = "The Alchemist";
            sixthProduct.ProductCategory = "Books";
            sixthProduct.ProductPrice = 15F;

            ProductsList.Add(sixthProduct);

            Product seventhProduct = new ();
            seventhProduct.ProductId = 7;
            seventhProduct.ProductName = "Paradise Lost";
            seventhProduct.ProductCategory = "Books";
            seventhProduct.ProductPrice = 20F;

            ProductsList.Add(seventhProduct);
        }
    }
}