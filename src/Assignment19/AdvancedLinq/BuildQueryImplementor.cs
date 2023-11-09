// <copyright file="BuildQueryImplementor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Has Methods to implement BuildQuery.
    /// </summary>
    public class BuildQueryImplementor
    {
        /// <summary>
        /// Creates Instance for QueryBuilder and implements it.
        /// </summary>
        /// <returns>Joined list of products and supplier</returns>
        public List<(Product, Supplier)> ImplementBuildQuery()
        {
            QueryBuilder queryBuilder = new QueryBuilder(ProductsManager.Products);
            List<Supplier> suppliersList = SupplierManager.Suppliers;
            var result = queryBuilder
                .Filter(p => p.ProductPrice > 100)
                .SortBy(p => p.ProductPrice)
                .Join(
                suppliersList,
                product => product.ProductId,
                supplier => supplier.ProductId,
                (product, supplier) => (product, supplier))
                .Execute();

            return result.ToList();
        }
    }
}