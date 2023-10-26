// <copyright file="Supplier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Has the Supplier properties
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Gets or sets the Id of supplier as integer.
        /// </summary>
        /// <value>Id as integer</value>
        public int SupplierId { get; set; }

        /// <summary>
        /// Gets or sets the name of the supplier
        /// </summary>
        /// <value>Supplier name as string</value>
        public string? SupplierName { get; set; }

        /// <summary>
        /// Gets or sets the Id of the product
        /// </summary>
        /// <value>Id of the product as integer</value>
        public int ProductId { get; set; }
    }
}