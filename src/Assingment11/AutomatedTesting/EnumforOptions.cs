// <copyright file="EnumforOptions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    /// <summary>
    /// Has the enum for Math Operations.
    /// </summary>
    public class EnumforOptions
    {
        /// <summary>
        /// ChoiceofService calls the service to be executed.
        /// </summary>
        public enum ChoiceofService
        {
            /// <summary>
            /// Calls the CalculatorService to execute.
            /// </summary>
            CalculatorService = 1,

            /// <summary>
            /// calls the OrderService to be executed.
            /// </summary>
            OrderService,

            /// <summary>
            /// Exits the application.
            /// </summary>
            Exit,
        }

        /// <summary>
        /// Has the different mathematical operations to be performed.
        /// </summary>
        public enum ChoiceofMathOperations
        {
            /// <summary>
            /// Calls the method for addition of two numbers.
            /// </summary>
            Addition = 1,

            /// <summary>
            /// Calls the method for subtracting two numbers
            /// </summary>
            Subtraction,

            /// <summary>
            /// Calls the method for multiplying two numbers
            /// </summary>
            Multiplication,

            /// <summary>
            /// Calls method for dividing two numbers.
            /// </summary>
            Division,

            /// <summary>
            /// Exits the Calculator Service.
            /// </summary>
            Exit,
        }

        /// <summary>
        /// It has the options for choosing the type of user.
        /// </summary>
        public enum OrderServiceUser
        {
            /// <summary>
            /// For sellers to update products.
            /// </summary>
            Seller = 1,

            /// <summary>
            /// Buyer buys products from the list.
            /// </summary>
            Buyer,

            /// <summary>
            /// Exits the OrderService
            /// </summary>
            Exit,
        }

        /// <summary>
        /// Calls the methods used for the seller to perform the tasks.
        /// </summary>
        public enum OptionsforSellers
        {
            /// <summary>
            /// Adds products to the list.
            /// </summary>
            AddProducts = 1,

            /// <summary>
            /// Displays the available products.
            /// </summary>
            DisplayAvailableProducts,

            /// <summary>
            /// Deletes the products put for sale.
            /// </summary>
            DeleteAvailableProducts,

            /// <summary>
            /// Exit the seller option.
            /// </summary>
            Exit,
        }

        /// <summary>
        /// Has the Options for the buyers.
        /// </summary>
        public enum Optionsforbuyers
        {
            /// <summary>
            /// Adds Products to the cart.
            /// </summary>
            AddProductstoCart = 1,

            /// <summary>
            /// Display the list of ordered products.
            /// </summary>
            DisplayOrderedProducts,

            /// <summary>
            /// Deletes an order
            /// </summary>
            CancelOrder,

            /// <summary>
            /// Exits the option.
            /// </summary>
            Exit,
        }
    }
}