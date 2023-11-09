// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SortUsingDelegates
{
    using InputValidator;

    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets or sets the list of products.
        /// </summary>
        /// <value>Products as objects</value>
        public static List<Product> ProductsList { get; set; } = new List<Product>();

        /// <summary>
        /// Main gets the input from user.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Enter the Number of products");
            int numberOfProducts = InputValidators.GetIntegerInput();
            Console.WriteLine("Enter the product details");
            for (int i = 0; i < numberOfProducts; i++)
            {
                Product productToBeAddedToList = new ();
                Console.WriteLine("Enter the product name:");
                productToBeAddedToList.ProductName = InputValidators.GetStringInput();
                Console.WriteLine("Enter the category:");
                productToBeAddedToList.Category = InputValidators.GetStringInput();
                Console.WriteLine("Enter the price:");
                productToBeAddedToList.Price = InputValidators.GetFloatInput();
                ProductsList.Add(productToBeAddedToList);
            }

            Console.WriteLine("Choose the type of sorting\n1.By Name\n2.By Category\n3.By Price\n");
            int choiceOfSorting = InputValidators.GetIntegerInput();
            switch (choiceOfSorting)
            {
                case (int)SortingType.SortByName:
                    ProductsSorters.SortAndDisplay(ProductsSorters.SortByName, ProductsList);
                    break;
                case (int)SortingType.SortByCategory:
                    ProductsSorters.SortAndDisplay(ProductsSorters.SortByCategory, ProductsList);
                    break;
                case (int)SortingType.SortByPrice:
                    ProductsSorters.SortAndDisplay(ProductsSorters.SortByPrice, ProductsList);
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
    }
}