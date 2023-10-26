// <copyright file="LinqToObjects.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLinq
{
    /// <summary>
    /// Has the methods to demonstrate the LinqToObjects.
    /// </summary>
    public class LinqToObjects
    {
        private static int[] arrayOfIntegers = { 7, 13, 16, 18, 26, 10, 6, 7, 96, 102, 78, 21, 23 };

        /// <summary>
        /// The method generates unique pairs that add up to the given target sum.
        /// </summary>
        /// <returns>List of tuple with two integers</returns>
        public List<(int, int)> GenerateUniquePairsThatAddUpToTarget()
        {
            InputValidators inputValidators = new InputValidators();
            int[] sortedNumbers = arrayOfIntegers.OrderByDescending((number) => number).ToArray();
            Console.WriteLine($"The second Largest Number:{sortedNumbers[1]}");
            Console.WriteLine("Enter the target number:");
            int targetNumber = inputValidators.GetIntegerInput();
            IEnumerable<(int, int)> expectedSum;
            expectedSum = from x in sortedNumbers
                          from y in sortedNumbers
                          where x + y == targetNumber && x != y
                          where x > y
                          select (x, y);
            return expectedSum.ToList();
        }
    }
}