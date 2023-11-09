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
        /// <param name="firstNumber">First number entered by user</param>
        /// <param name="secondNumber">Second number entered by user</param>
        /// <returns>Divident</returns>
        public static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}