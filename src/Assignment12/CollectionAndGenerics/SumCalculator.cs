// <copyright file="SumCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace CollectionAndGenerics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Gives the sum of all elements from the collection.
    /// </summary>
    public class SumCalculator
    {
        /// <summary>
        /// Gets current elements from the collection.
        /// </summary>
        /// <param name="collectionOfNumber">Collection of Numbers as integers</param>
        /// <returns>Sum as integer</returns>
        public static int SumOfElementsofCollection(IEnumerable<int> collectionOfNumber)
        {
            int sum = 0;
            foreach (int i in collectionOfNumber)
            {
                sum += i;
            }

            return sum;
        }
    }
}