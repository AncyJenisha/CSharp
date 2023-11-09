// <copyright file="JoinedProductSupplier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// JoinedProductSupplier - Has the properties of the joined Products and supllier.
    /// </summary>
    public class JoinedProductSupplier
    {
        /// <summary>
        /// Gets or sets the Supplier Object.
        /// </summary>
        /// <value>Object of Supplier class</value>
        public Supplier SupplierObject { get; set; }

        /// <summary>
        /// Gets or sets the object of Products class.
        /// </summary>
        /// <value>Object of product class</value>
        public Product ProductObject { get; set; }
    }
}