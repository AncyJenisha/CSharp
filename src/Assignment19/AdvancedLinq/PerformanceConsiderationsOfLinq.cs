// <copyright file="PerformanceConsiderationsOfLinq.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    using ConsoleTables;

    /// <summary>
    /// Has the method which filters and sorts the books from the product list.
    /// </summary>
    public class PerformanceConsiderationsOfLinq
    {
        /// <summary>
        /// The method filters the books from the product list and sorts them by price.
        /// </summary>
        /// <returns> List of Books from products list</returns>
        public List<Product> FilterAndSortBooks()
        {
            List<Product> productsList = ProductsManager.Products;

            var listOfBooks = from product in productsList
                              where product.ProductCategory == "Books"
                              select product;

            List<Product> sortedListOfBooks = listOfBooks.OrderByDescending(product => product.ProductPrice).ToList();

            return sortedListOfBooks;
        }
    }
}