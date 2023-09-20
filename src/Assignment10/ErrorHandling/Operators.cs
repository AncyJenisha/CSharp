// <copyright file="Operators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ErrorHandling
{
    /// <summary>
    /// Has the methods to perform division operation.
    /// </summary>
    public static class Operators
    {
        /// <summary>
        /// Divides the number by zero
        /// </summary>
        /// <param name="x">First number entered by user</param>
        /// <param name="y">Second number entered by user</param>
        /// <returns>Divident</returns>
        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}