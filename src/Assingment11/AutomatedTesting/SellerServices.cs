// <copyright file="SellerServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    using ConsoleTables;
    using ValidatorforInputs;

    /// <summary>
    /// Has the methods for the functions sed by seller.
    /// </summary>
    public static class SellerServices
    {
        /// <summary>
        /// Gets or sets list of products put up by seller.
        /// </summary>
        /// <value>List of selling products objects.</value>
        public static List<Products> ProductsforSaleList { get; set; } = new List<Products>();

        /// <summary>
        /// Adds products put up for sale by the seller.
        /// </summary>
        public static void AddProducts()
        {
            Products product = new ();
            Console.WriteLine("Enter the product name:");
            product.ProductName = InputValidators.GetStringInput();
            Console.WriteLine("\nEnter the Quantity:");
            product.Quantity = InputValidators.ReadIntegerInput();
            Console.WriteLine("\nEnter the Price:");
            product.Price = InputValidators.ReadDoubleInput();
            product.Id = ProductsforSaleList.Count + 1;
            ProductsforSaleList.Add(product);
        }

        /// <summary>
        /// Displays the product list.
        /// </summary>
        /// <param name="product">Product details as an object.</param>
        public static void DisplayProducts()
        {
            var table = new ConsoleTable("Id", "Product Name", "Quantity", "PricePerUnit");
            if (ProductsforSaleList.Count > 0)
            {
                foreach (var product in SellerServices.ProductsforSaleList)
                {
                    table.AddRow(product.Id, product.ProductName, product.Quantity, product.Price);
                }

                table.Write();
            }
            else
            {
                Console.WriteLine("No Products to display");
            }
        }

        /// <summary>
        /// Deletes the products from list
        /// </summary>
        public static void DeleteProducts()
        {
            bool flag = false;
            SellerServices.DisplayProducts();
            Console.WriteLine("\nEnter the ID of the product to be deleted:");
            int idToRemove = InputValidators.ReadIntegerInput();
            if (idToRemove > 0 && idToRemove <= ProductsforSaleList.Count)
            {
                foreach (Products products in ProductsforSaleList.ToList())
                {
                    if (products.Id == idToRemove)
                    {
                        ProductsforSaleList.RemoveAt(idToRemove - 1);
                        flag = true;
                    }
                    else if (flag)
                    {
                        products.Id--;
                    }
                }

                Console.WriteLine("Product Removed.");
            }
            else
            {
                Console.WriteLine("Enter valid id");
            }
        }
    }
}