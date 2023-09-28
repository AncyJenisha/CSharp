// <copyright file="Calculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    /// <summary>
    /// Calculator class has the methods for mathematical operations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds firstNumber and secondNumber
        /// </summary>
        /// <param name="firstNumber">The first number entered by user as double.</param>
        /// <param name="secondNumber">The second number entered by user as double.</param>
        /// <returns>Sum of firstNumber and secondNumber as double</returns>
        public static double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Subtracts secondNumber from firstNumber.
        /// </summary>
        /// <param name="firstNumber">The first number entered by user.</param>
        /// <param name="secondNumber">The second number entered by user.</param>
        /// <returns>The difference between firstNumber and secondNumber</returns>
        public static double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Multiplies firstNumber and secondNumber.
        /// </summary>
        /// <param name="firstNumber">The first number entered by user,which is the multiplicant.</param>
        /// <param name="secondNumber">The second number entered by user, which is the multiplier.</param>
        /// <returns>The product of firstNumber and secondNumber</returns>
        public static double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// Divides firstNumber by secondNumber.
        /// </summary>
        /// <param name="firstNumber">The first number entered by user,which is the divident.</param>
        /// <param name="secondNumber">The second number entered by user, which is the divisior.</param>
        /// <returns>The quotient when firstNumber is divided by secondNumber</returns>
        public static double Division(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("The second number cannot be zero");
                return 0;
            }
        }
    }
}