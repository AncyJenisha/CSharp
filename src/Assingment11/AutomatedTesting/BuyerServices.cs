// <copyright file="BuyerServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    using ConsoleTables;
    using ValidatorforInputs;

    /// <summary>
    /// Has the methds for functions for buyer.
    /// </summary>
    public static class BuyerServices
    {
        /// <summary>
        /// Gets or sets list of products oredered by buyer.
        /// </summary>
        /// <value>List of oredered products objects.</value>
        public static List<Products> OrderedProductsList { get; set; } = new List<Products>();

        /// <summary>
        /// Method to adds products to the cart.
        /// </summary>
        public static void AddProductstocart()
        {
            int idToSelect;
            Products product = new ();
            SellerServices.DisplayProducts();
            Console.WriteLine("Choose the Product Id:");
            idToSelect = InputValidators.ReadIntegerInput();
            if (idToSelect < 0 || idToSelect > SellerServices.ProductsforSaleList.Count)
            {
                Console.WriteLine("Enter a valid product id\n");
            }
            else
            {
                product.ProductName = SellerServices.ProductsforSaleList[idToSelect - 1].ProductName;
                Console.WriteLine("Enter the quantity:\n");
                int quantity = InputValidators.ReadIntegerInput();
                product.Quantity = quantity;
                product.Id = OrderedProductsList.Count + 1;
                product.Price = SellerServices.ProductsforSaleList[idToSelect - 1].Price * quantity;
                SellerServices.ProductsforSaleList[idToSelect - 1].Quantity = SellerServices.ProductsforSaleList[idToSelect - 1].Quantity - quantity;
                OrderedProductsList.Add(product);
            }
        }

        /// <summary>
        /// Displays the products list ordered by the buyer.
        /// </summary>
        public static void DisplayOrder()
        {
            var table = new ConsoleTable("Id", "Product Name", "Quantity", "Price");
            if (OrderedProductsList.Count > 0)
            {
                foreach (var product in OrderedProductsList)
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
        /// To delete a product from list.
        /// </summary>
        public static void RemoveFromCart()
        {
            DisplayOrder();
            Console.WriteLine("\nEnter the ID of the product to be deleted:");
            int idToRemove = InputValidators.ReadIntegerInput();
            if (idToRemove > 0 && idToRemove <= OrderedProductsList.Count)
            {
                bool flag = false;
                foreach (Products products in OrderedProductsList.ToList())
                {
                    if (products.Id == idToRemove)
                    {
                        foreach (var product in SellerServices.ProductsforSaleList)
                        {
                            if (product.ProductName == OrderedProductsList[idToRemove - 1].ProductName)
                            {
                                product.Quantity += OrderedProductsList[idToRemove - 1].Quantity;
                            }
                        }

                        OrderedProductsList.RemoveAt(idToRemove - 1);
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