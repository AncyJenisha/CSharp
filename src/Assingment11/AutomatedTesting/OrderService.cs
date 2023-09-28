// <copyright file="OrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    using ValidatorforInputs;

    /// <summary>
    /// OrderService has the
    /// </summary>
    internal static class OrderService
    {
        /// <summary>
        /// OrderService
        /// </summary>
        public static void Orderservice()
        {
            int typeofuser;
            int optionchosebyseller;
            int optionchosebybuyer;
            do
            {
                Console.WriteLine("\n1.Seller\n2.Buyer\n3.Exit\n");
                typeofuser = InputValidators.ReadIntegerInput();
                switch (typeofuser)
                {
                    case (int)EnumforOptions.OrderServiceUser.Seller:
                        do
                        {
                            Console.WriteLine("\n1.Add Products\n2.Display the avilable products\n3.Delete Products put for sale\n4.Exit");
                            optionchosebyseller = InputValidators.ReadIntegerInput();
                            switch (optionchosebyseller)
                            {
                                case (int)EnumforOptions.OptionsforSellers.AddProducts:
                                    SellerServices.AddProducts();
                                    break;
                                case (int)EnumforOptions.OptionsforSellers.DisplayAvailableProducts:
                                    SellerServices.DisplayProducts();
                                    break;
                                case (int)EnumforOptions.OptionsforSellers.DeleteAvailableProducts:
                                    SellerServices.DeleteProducts();
                                    break;
                                case (int)EnumforOptions.OptionsforSellers.Exit:
                                    break;
                                default:
                                    Console.WriteLine("Choose a valid option\n");
                                    break;
                            }
                        }
                        while (optionchosebyseller != 4);
                        break;

                    case (int)EnumforOptions.OrderServiceUser.Buyer:
                        do
                        {
                            Console.WriteLine("1.Add Products to cart\n2.Display the Products Ordered\n3.Remove products from cart\n4.Exit\n");
                            optionchosebybuyer = InputValidators.ReadIntegerInput();
                            switch (optionchosebybuyer)
                            {
                                case (int)EnumforOptions.Optionsforbuyers.AddProductstoCart:
                                    BuyerServices.AddProductstocart();
                                    break;
                                case (int)EnumforOptions.Optionsforbuyers.DisplayOrderedProducts:
                                    BuyerServices.DisplayOrder();
                                    break;
                                case (int)EnumforOptions.Optionsforbuyers.CancelOrder:
                                    BuyerServices.RemoveFromCart();
                                    break;
                                case (int)EnumforOptions.Optionsforbuyers.Exit:
                                    break;
                                default:
                                    Console.WriteLine("Choose a valid option\n");
                                    break;
                            }
                        }
                        while (optionchosebybuyer != 4);
                        break;

                    case (int)EnumforOptions.OrderServiceUser.Exit:
                        break;
                    default:
                        Console.WriteLine("Choose a valid option\n");
                        break;
                }
            }
            while (typeofuser != 3);
        }
    }
}