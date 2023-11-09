// <copyright file="AdvancedLinqFeatures.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    using System.Linq.Expressions;
    using ConsoleTables;

    /// <summary>
    /// Has the methods to demonstrate Advanced Linq Features.
    /// </summary>
    public class AdvancedLinqFeatures
    {
        /// <summary>
        /// Filters the product list based on the function given.
        /// </summary>
        /// <param name="filterProductsList">Method to filter products</param>
        /// <returns>Filtered products List</returns>
        public List<Product> FilterListOfProductsUsingLambdaExpression(Func<Product, bool> filterProductsList)
        {
            List<Product> productsList = ProductsManager.Products;

            var filteredProductListByCategory = from product in productsList
                                                where filterProductsList(product)
                                                select product;

            var filteredProductsList = filteredProductListByCategory.OrderByDescending(product => product.ProductPrice).ToList();

            return filteredProductsList;
        }

        /// <summary>
        /// Filters the Products based on the property specified by user
        /// </summary>
        /// <param name="filterMethod">Method which returns an expression</param>
        /// <returns>List of filtered Products</returns>
        public List<Product> FilterListOfProductsUsingExpressionTree()
        {
            List<Product> listOfProducts = ProductsManager.Products;

            var expression = this.GenerateExpressionTreeToFilterProduct().Compile();
            var listOfFilteredProducts = from product in listOfProducts
                                                   where expression(product)
                                                   select product;
            return listOfFilteredProducts.ToList();
        }

        /// <summary>
        /// The method creates a dynamic linq query.
        /// </summary>
        /// <returns>Delegate of an expression</returns>
        public Expression<Func<Product, bool>> GenerateExpressionTreeToFilterProduct()
        {
            InputValidators inputValidators = new InputValidators();
            List<Product> productsList = ProductsManager.Products;
            ParameterExpression parameterExpression = Expression.Parameter(typeof(Product), "p");

            MemberExpression memberExpression = Expression.Property(parameterExpression, "ProductCategory");

            Console.WriteLine("1.Electronics\n2.Furniture\n3.Snacks\n4.Books\nEnter the Category to be filterd");

            string valueToBeFiltered = inputValidators.GetStringInput();
            ConstantExpression constantExpression = Expression.Constant(valueToBeFiltered, typeof(string));

            BinaryExpression binaryExpression = Expression.Equal(constantExpression, memberExpression);

            var filterExpression = Expression.Lambda<Func<Product, bool>>(binaryExpression, parameterExpression);
            return filterExpression;
        }
    }
}