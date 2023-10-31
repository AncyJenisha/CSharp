// <copyright file="ListDisplayer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace AdvancedLinq
{
    using ConsoleTables;

    /// <summary>
    /// Has methods to display the list.
    /// </summary>
    public class ListDisplayer
    {
        /// <summary>
        /// Displays the filtered products list.
        /// </summary>
        public void DisplayFilteredProducts()
        {
            float totalPrice = 0;
            int numberOfProducts = 0;

            var table = new ConsoleTable("Product Name", "ProductPrice");
            BasicLinqQueries basicLinqQueries = new BasicLinqQueries();

            List<Tuple<string, float>> filteredProductsList = basicLinqQueries.FilterProducts();

            Console.WriteLine("Filtering and Sorting the list\n\nProducts under Electronics Category:\n");
            foreach (var product in filteredProductsList)
            {
                table.AddRow(product.Item1, product.Item2);
                totalPrice += product.Item2;
                numberOfProducts++;
            }

            Console.WriteLine($"The average Price:{totalPrice / numberOfProducts}\n\n");

            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Displays the list of unique pairs that add upto the target number.
        /// </summary>
        public void DisplayUniquePairsThatAddUpToTarget()
        {
            LinqToObjects linqToObjects = new LinqToObjects();

            Console.WriteLine("Generating Unique Pairs that add to the given target sum\n");
            List<(int, int)> expectedSum = linqToObjects.GenerateUniquePairsThatAddUpToTarget();
            if (expectedSum.Count() == 0)
            {
                Console.WriteLine("No two numbers in the list add up to the target number");
            }
            else
            {
                foreach (var number in expectedSum)
                {
                    Console.WriteLine($"{number.Item1} and {number.Item2} add upto the target number");
                }

                Console.WriteLine("\n\n");
            }
        }

        /// <summary>
        /// Displays the list of products grouped by category.
        /// </summary>
        public void DisplayGroupProducts()
        {
            int countOfProductsInCategory = 0;
            Product expensiveProduct = new Product();
            BasicLinqQueries basicLinqQueries = new BasicLinqQueries();
            var table = new ConsoleTable("ProductId", "ProductName", "ProductPrice", "Category");

            Console.WriteLine("Grouping Products");
            var groupedProductList = basicLinqQueries.GroupProductsBasedOnCategory();
            foreach (var categoryGroup in groupedProductList)
            {
                foreach (var product in categoryGroup)
                {
                    table.AddRow(product.ProductId, product.ProductName, product.ProductPrice, product.ProductCategory);
                    expensiveProduct = categoryGroup.First();
                    countOfProductsInCategory++;
                }

                Console.WriteLine($"The Number of products in {expensiveProduct.ProductCategory}: {countOfProductsInCategory}\nThe most expensive product of {expensiveProduct.ProductCategory} is {expensiveProduct.ProductName} of Price {expensiveProduct.ProductPrice}\n\n");
            }

            Console.WriteLine("Products Grouped By Category");

            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Displays the joined list of product and supplier.
        /// </summary>
        public void DisplayJoinProductAndSupplierList()
        {
            BasicLinqQueries basicLinqQueries = new BasicLinqQueries();
            var joinedList = basicLinqQueries.JoinProductAndSupplierList();
            var table = new ConsoleTable("ProductId", "ProductName", "ProductPrice", "Category", "SupplierId", "SupplierName");

            Console.WriteLine("Implementing Join to join two lists");
            foreach (var product in joinedList)
            {
                table.AddRow(product.Item1, product.Item2, product.Item3, product.Item4, product.Item5, product.Item6);
            }

            Console.WriteLine("Products and Suppliers");
            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Displays the filtered books from the list of products.
        /// </summary>
        public void DisplayFilterAndSortBooksList()
        {
            PerformanceConsiderationsOfLinq performanceConsiderationsOfLinq = new PerformanceConsiderationsOfLinq();
            List<Product> sortedListOfBooks = performanceConsiderationsOfLinq.FilterAndSortBooks();
            var table = new ConsoleTable("Product ID", "Product Name", "ProductPrice", "Product Category");

            Console.WriteLine("Sorting Books from the products list");

            foreach (var book in sortedListOfBooks)
            {
                table.AddRow(book.ProductId, book.ProductName, book.ProductPrice, book.ProductCategory);
            }

            Console.WriteLine("List Of Books");
            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Displays the list of filtered products using the lambda expression.
        /// </summary>
        public void DisplayProductsListFilteredByLambdaExpression()
        {
            AdvancedLinqFeatures advancedLinqFeatures = new AdvancedLinqFeatures();
            List<Product> listOfFilteredProducts = advancedLinqFeatures.FilterListOfProductsUsingLambdaExpression(product => product.ProductCategory == "Snacks");
            var table = new ConsoleTable("Product ID", "Product Name", "ProductPrice", "Product Category");

            Console.WriteLine("Filter using lambda Expression");

            foreach (Product product in listOfFilteredProducts)
            {
                table.AddRow(product.ProductId, product.ProductName, product.ProductPrice, product.ProductCategory);
            }

            Console.WriteLine("Filtered List");
            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Displays the products list filtered by expression trees.
        /// </summary>
        public void DisplayProductsListFilteredByExpressionTree()
        {
            AdvancedLinqFeatures advancedLinqFeatures = new AdvancedLinqFeatures();
            List<Product> listOfFilteredProducts = advancedLinqFeatures.FilterListOfProductsUsingExpressionTree();
            var table = new ConsoleTable("Product ID", "Product Name", "ProductPrice", "Product Category");

            foreach (Product product in listOfFilteredProducts)
            {
                table.AddRow(product.ProductId, product.ProductName, product.ProductPrice, product.ProductCategory);
            }

            Console.WriteLine("Filtered by expression tress");
            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Displays the implementation of build query.
        /// </summary>
        public void DisplayImplemantationOfBuildQuery()
        {
            BuildQueryImplementor buildQueryImplementor = new BuildQueryImplementor();

            List<(Product, Supplier)> joinedList = buildQueryImplementor.ImplementBuildQuery();

            var table = new ConsoleTable("Product ID", "Product Name", "ProductPrice", "Product Category");

            foreach (var product in joinedList)
            {
                table.AddRow(product.Item1.ProductId, product.Item1.ProductName, product.Item1.ProductPrice, product.Item1.ProductCategory);
            }

            Console.WriteLine("Filterd by implementing build query");
            table.Write(Format.MarkDown);
            Console.WriteLine("\n\n");
        }
    }
}