// <copyright file="QueryBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    using System.Diagnostics.Metrics;
    using System.Security.Cryptography;

    /// <summary>
    /// Has methods to build query.
    /// </summary>
    public class QueryBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBuilder"/> class.
        /// </summary>
        /// <param name="listOfProducts">The list of products</param>
        public QueryBuilder(List<Product> listOfProducts)
        {
            this.ListOfProductsToBeQueried = listOfProducts;
        }

        private List<Product> ListOfProductsToBeQueried { get; set; }

        private List<Supplier> ListOfSuppliersToBeJoined { get; set; } = SupplierManager.Suppliers;

        private IEnumerable<Product> FilteredProducts { get; set; }

        private IEnumerable<(Product, Supplier)> JoinedList { get; set; }

        /// <summary>
        /// Accepts a lambda expression that represents a filter condition and adds it to the query.
        /// </summary>
        /// <param name="function">A lambda function with filter condition</param>
        /// <returns>Filtered List Of Products</returns>
        public QueryBuilder Filter(Func<Product, bool> function)
        {
           this.FilteredProducts = this.ListOfProductsToBeQueried.Where(function);
           return this;
        }

        /// <summary>
        /// The method gets a lambda function that has the condition to sort.
        /// </summary>
        /// <param name="function">The lambda method with condition to filter</param>
        /// <returns>Sorted List</returns>
        public QueryBuilder SortBy(Func<Product, float> function)
        {
            this.FilteredProducts.OrderByDescending(function);
            return this;
        }

        /// <summary>
        /// It gets the lambda method with condition to join.
        /// </summary>
        /// <param name="inner">The Supplier</param>
        /// <param name="outerKeySelector">Id Of Products</param>
        /// <param name="innerKeySelector">Id Of Supplier</param>
        /// <param name="resultSelector">The result of the lambda function</param>
        /// <returns>Joined List</returns>
        public QueryBuilder Join(IEnumerable<Supplier> inner, Func<Product, int> outerKeySelector, Func<Supplier, int> innerKeySelector, Func<Product, Supplier, (Product, Supplier)> resultSelector)
        {
            this.JoinedList = this.FilteredProducts.Join(inner, outerKeySelector, innerKeySelector, resultSelector);
            return this;
        }

        /// <summary>
        /// Executes the Query and returns the list.
        /// </summary>
        /// <returns>The list obtained after execeuting the query</returns>
        public List<(Product, Supplier)> Execute()
        {
            return this.JoinedList.ToList();
        }
    }
}