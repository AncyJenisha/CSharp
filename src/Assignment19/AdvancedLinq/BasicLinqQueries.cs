// <copyright file="BasicLinqQueries.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace AdvancedLinq
{
    using ConsoleTables;

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
            List<Product> productsList = ProductsManager.ProductsList;

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
            Product expensiveProduct = new ();

            List<Product> productsList = ProductsManager.ProductsList;

            var groupedProductList = from product in productsList.OrderByDescending((product) => product.ProductPrice)
                                     group product by product.ProductCategory into categoryGroup
                                     select categoryGroup;

            return groupedProductList.ToList();
        }

        /// <summary>
        /// Joins the product and supplier list.
        /// </summary>
        /// <returns>List of tuple</returns>
        public List<Tuple<int, string?, float, string?, int, string?>> JoinProductAndSupplierList()
        {
            List<Product> productsList = ProductsManager.ProductsList;
            List<Supplier> suppliersList = SupplierManager.SuppliersList;

            var joinedProductsAndSuppliersList = productsList.Join(
                suppliersList,
                product => product.ProductId,
                supplier => supplier.ProductId,
                (product, supplier) => Tuple.Create(
                    product.ProductId,
                    product.ProductName,
                    product.ProductPrice,
                    product.ProductCategory,
                    supplier.SupplierId,
                    supplier.SupplierName)).ToList();

            return joinedProductsAndSuppliersList;
        }
    }
}