// <copyright file="ProductsSorters.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SortUsingDelegates
{
    using InputValidator;

    /// <summary>
    /// Has methods to sort products.
    /// </summary>
    public static class ProductsSorters
    {
        /// <summary>
        /// Points to functions that gets two objects as input
        /// </summary>
        /// <param name="firstProduct">First Product object</param>
        /// <param name="secondProduct">Second Product object</param>
        /// <returns>integer based on sorting</returns>
        public delegate int SortDelegate(Product firstProduct, Product secondProduct);

        /// <summary>
        /// Sorts product by name.
        /// </summary>
        /// <param name="firstProduct">The first product entered by user.</param>
        /// <param name="secondProduct">The second product entered by user.</param>
        /// <returns>Integer</returns>
        public static int SortByName(Product firstProduct, Product secondProduct)
        {
            int count = firstProduct.ProductName!.CompareTo(secondProduct.ProductName);
            return count;
        }

        /// <summary>
        /// Sorts by the category of the product
        /// </summary>
        /// <param name="firstProduct">The first product enetered by user.</param>
        /// <param name="secondProduct">The second product entered by user.</param>
        /// <returns>Integer</returns>
        public static int SortByCategory(Product firstProduct, Product secondProduct)
        {
            int count = firstProduct.Category!.CompareTo(secondProduct.Category);
            return count;
        }

        /// <summary>
        /// Sorts by the category of the product
        /// </summary>
        /// <param name="firstProduct">The first product enetered by user.</param>
        /// <param name="secondProduct">The second product entered by user.</param>
        /// <returns>Integer</returns>
        public static int SortByPrice(Product firstProduct, Product secondProduct)
        {
            int count = firstProduct.Price.CompareTo(secondProduct.Price);
            return count;
        }

        /// <summary>
        /// SortAndDisplay displays the sorted elements of the list.
        /// </summary>
        /// <param name="sortDelegate">Delegate of methods</param>
        /// <param name="listOfProducts">List of product details.</param>
        public static void SortAndDisplay(SortDelegate sortDelegate, List<Product> listOfProducts)
        {
            listOfProducts.Sort((firstProduct, secondProduct) => sortDelegate(firstProduct, secondProduct));
            foreach (Product product in listOfProducts)
            {
                Console.WriteLine($"Product Name:{product.ProductName}");
                Console.WriteLine($"Product Category:{product.Category}");
                Console.WriteLine($"Product Price:{product.Price}");
            }
        }
    }
}