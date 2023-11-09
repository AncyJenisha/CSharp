// <copyright file="SupplierManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// SupplierManager manages the list of suppliers.
    /// </summary>
    public class SupplierManager
    {
        /// <summary>
        /// Gets or sets the list of suppliers
        /// </summary>
        /// <value>List of Suppliers</value>
        public static List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        /// <summary>
        /// Adds default suppliers to the Suppliers.
        /// </summary>
        public void InitializeWithDefaultSuppliers()
        {
            Supplier firstSupplier = new Supplier(1, "Samsung", 1);
            Suppliers.Add(firstSupplier);

            Supplier secondSupplier = new Supplier(2, "Dell", 2);
            Suppliers.Add(secondSupplier);

            Supplier thirdSupplier = new Supplier(3, "Duroflex", 3);
            Suppliers.Add(thirdSupplier);

            Supplier fourthSupplier = new Supplier(4, "Parle",4);
            Suppliers.Add(fourthSupplier);

            Supplier fifthSupplier = new Supplier(5,"Cadberry", 5);
            Suppliers.Add(fifthSupplier);

            Supplier sixthSupplier = new Supplier(6,"Harper Collins", 6);
            Suppliers.Add(sixthSupplier);

            Supplier seventhSupplier = new Supplier(7, "Mass Market PaperBack", 7);
            Suppliers.Add(seventhSupplier);
        }
    }
}