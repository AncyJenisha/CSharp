// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Lambda
{
    using System.Linq;
    using InputValidator;

    /// <summary>
    /// Program class has the main method
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets input from user.
        /// </summary>
        private static void Main()
        {
            List<int> listofNumbers = new ();
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                int numberToBeAddedToList = InputValidators.GetIntegerInput();
                listofNumbers.Add(numberToBeAddedToList);
            }

            IEnumerable<int> filteredData = listofNumbers.Where(num => num % 2 == 0);
            IEnumerable<int> filteredResult = from num in listofNumbers
                                              where num % 2 == 0
                                              select num * num;

            Console.WriteLine("\nSquared values of even numbers");
            foreach (int number in filteredResult)
            {
                Console.WriteLine(number);
            }
        }
    }
}