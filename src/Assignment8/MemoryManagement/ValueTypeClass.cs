// <copyright file="ValueTypeClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ValueAndReferenceType
{
    /// <summary>
    /// ValueTypeClass has the methods for Value Type.
    /// </summary>
    internal static class ValueTypeClass
    {
        /// <summary>
        /// Performs operation on large number of variables.
        /// </summary>
        public static void OperationOnValueType()
        {
            while (true)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    int number = 0;
                    number += i;
                }
            }
        }
    }
}