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
        public static List<Supplier> SuppliersList { get; set; } = new List<Supplier>();

        /// <summary>
        /// Adds default suppliers to the SuppliersList.
        /// </summary>
        public void InitializeWithDefaultSuppliers()
        {
            Supplier firstSupplier = new Supplier();
            firstSupplier.SupplierId = 1;
            firstSupplier.SupplierName = "Samsung";
            firstSupplier.ProductId = 1;

            SuppliersList.Add(firstSupplier);

            Supplier secondSupplier = new Supplier();
            secondSupplier.SupplierId = 2;
            secondSupplier.SupplierName = "Dell";
            secondSupplier.ProductId = 2;

            SuppliersList.Add(secondSupplier);

            Supplier thirdSupplier = new Supplier();
            thirdSupplier.SupplierId = 3;
            thirdSupplier.SupplierName = "Duroflex";
            thirdSupplier.ProductId = 3;

            SuppliersList.Add(thirdSupplier);

            Supplier fourthSupplier = new Supplier();
            fourthSupplier.SupplierId = 4;
            fourthSupplier.SupplierName = "ParleG";
            fourthSupplier.ProductId = 4;

            SuppliersList.Add(fourthSupplier);

            Supplier fifthSupplier = new Supplier();
            fifthSupplier.SupplierId = 5;
            fifthSupplier.SupplierName = "Cadberry";
            fifthSupplier.ProductId = 5;

            SuppliersList.Add(fifthSupplier);

            Supplier sixthSupplier = new Supplier();
            sixthSupplier.SupplierId = 6;
            sixthSupplier.SupplierName = "Harper Collins";
            sixthSupplier.ProductId = 6;

            SuppliersList.Add(sixthSupplier);

            Supplier seventhSupplier = new Supplier();
            seventhSupplier.SupplierId = 7;
            seventhSupplier.SupplierName = "Mass Market PaperBack";
            seventhSupplier.ProductId = 7;

            SuppliersList.Add(seventhSupplier);
        }
    }
}