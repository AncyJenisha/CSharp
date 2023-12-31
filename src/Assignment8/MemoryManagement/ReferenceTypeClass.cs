﻿// <copyright file="ReferenceTypeClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ValueAndReferenceType
{
    /// <summary>
    /// Has the reference type data.
    /// </summary>
    public class ReferenceTypeClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceTypeClass"/> class.
        /// Has ReferenceTypeNumbers value
        /// </summary>
        /// <param name="number">integer</param>
        public ReferenceTypeClass(int number)
        {
            this.ReferenceTypeNumber = number;
        }

        /// <summary>
        /// Gets or sets Reference type data.
        /// </summary>
        /// <value>Integer</value>
        public int ReferenceTypeNumber { get; set; }

        /// <summary>
        /// Creates Large array of integers.
        /// </summary>
        public static void ArrayofIntegers()
        {
            int[] largeArray = new int[1000000];
            while (true)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    largeArray[i] = i;
                }
            }
        }
    }
}