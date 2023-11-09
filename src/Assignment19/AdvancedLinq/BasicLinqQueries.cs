// <copyright file="BasicLinqQueries.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace AdvancedLinq
{
    using ConsoleTables;
    using System.Net.Http.Headers;

    /// <summary>
    /// Has the methods to explain basic and complex linq queries.
    /// </summary>
    public class BasicLinqQueries
    {
        /// <summary>
        /// Filters the products by category and sort by price.
        /// </summary>
        /// <returns>A list of tuple with name and price of product</returns>
        public List<Tuple<string, float>> FilterProducts()
        {
            List<Product> productsList = ProductsManager.Products;

            var filteredProducts = from product in productsList
                                   where product.ProductCategory == "Electronics"
                                   && product.ProductPrice > 500
                                   select Tuple.Create(product.ProductName, product.ProductPrice);

            List<Tuple<string, float>> filteredProductsInDescendingOrder = filteredProducts.OrderByDescending((product) => product.Item2).ToList();
            return filteredProductsInDescendingOrder;
        }

        /// <summary>
        /// Group products by category and joins the supplier list to it.
        /// </summary>
        /// <returns>IGrouping of products</returns>
        public List<IGrouping<string, Product>> GroupProductsBasedOnCategory()
        {
            List<Product> productsList = ProductsManager.Products;

            var groupedProductList = from product in productsList.OrderByDescending((product) => product.ProductPrice)
                                     group product by product.ProductCategory into categoryGroup
                                     select categoryGroup;

            return groupedProductList.ToList();
        }

        /// <summary>
        /// Joins the product and supplier list.
        /// </summary>
        /// <returns>List of tuple</returns>
        public List<JoinedProductSupplier> JoinProductAndSupplierList()
        {
            List<Product> productsList = ProductsManager.Products;
            List<Supplier> suppliersList = SupplierManager.Suppliers;
            JoinedProductSupplier joinedProductSupplier = new JoinedProductSupplier();
            List<JoinedProductSupplier> joinedProductsAndSuppliersList = new List<JoinedProductSupplier>();
            joinedProductsAndSuppliersList = productsList.Join(
                suppliersList,
                product => product.ProductId,
                supplier => supplier.SupplierId,
                (product, supplier) => new JoinedProductSupplier()
                {
                    SupplierObject = supplier,
                    ProductObject = product,
                }).ToList();

            return joinedProductsAndSuppliersList;
        }
    }
}