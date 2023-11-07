namespace MyMathLibrary
{
    using MathNet.Numerics;
    using System.Numerics;

    /// <summary>
    /// FibonnaciCalculator - Has method to generate fibonnaci sequence upto given number.
    /// </summary>
    public class FibonacciCalculator
    {
        /// <summary>
        /// CalculateFibonnaci - Gets a number and returns an array of fibonacci sequence upto the number.
        /// </summary>
        /// <param name="number">The length of the fibonnaci sequence to be generated.</param>
        /// <returns>An array of fibonacci sequence.</returns>
        public BigInteger[] CalculateFibonnaci(int number)
        {
            var fibonnaciSequence = Generate.Fibonacci(number);
            return fibonnaciSequence;
        }
    }
}