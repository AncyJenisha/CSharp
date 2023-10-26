// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Program class has the main method which is the entry of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets the user choice and calls the method to implement each task.
        /// </summary>
        private static void Main()
        {
            int choice;
            ProductsManager productsManager = new ProductsManager();
            productsManager.IntializeWithDefaultProducts();

            SupplierManager supplierManager = new SupplierManager();
            supplierManager.InitializeWithDefaultSuppliers();

            InputValidators inputValidators = new InputValidators();
            DisplayList displayList = new DisplayList();

            do
            {
                Console.WriteLine("1.Basic Linq Queries\n2.Group Products by category\n3.Join Products and Supplier List\n4.Linq To Objects\n5.Performance Considerations of Linq\n6.Advanced Linq Features\n7.Filter By Expression Trees\n8.Using Build Query\n9.Exit");
                Console.WriteLine("Enter the choice:");
                choice = inputValidators.GetIntegerInput();
                switch (choice)
                {
                    case (int)ChoiceOfOperation.BasicLinqQueries:
                        displayList.DisplayFilteredProducts();
                        break;
                    case (int)ChoiceOfOperation.GroupProductsBasedOnCategory:
                        displayList.DisplayGroupProducts();
                        break;
                    case (int)ChoiceOfOperation.JoinProductsAndSupplier:
                        displayList.DisplayJoinProductAndSupplierList();
                        break;
                    case (int)ChoiceOfOperation.LinqToObjects:
                        displayList.DisplayUniquePairsThatAddUpToTarget();
                        break;
                    case (int)ChoiceOfOperation.PerformanceConsiderationsOfLinq:
                        displayList.DisplayFilterAndSortBooksList();
                        break;
                    case (int)ChoiceOfOperation.AdvancedLinqFeatures:
                        displayList.DisplayProductsListFilteredByLambdaExpression();
                        break;
                    case (int)ChoiceOfOperation.FilterByExpresssionTree:
                        displayList.DisplayProductsListFilteredByExpressionTree();
                        break;
                    case (int)ChoiceOfOperation.UsingQueryBuilder:
                        displayList.DisplayImplemantationOfBuildQuery();
                        break;
                    case (int)ChoiceOfOperation.Exit:
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        break;
                }
            }
            while (choice != 8);
        }
    }
}