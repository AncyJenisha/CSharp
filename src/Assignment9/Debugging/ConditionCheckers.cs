// <copyright file="ConditionCheckers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Debugging
{
    /// <summary>
    /// Has methods to check the shape of the sides.
    /// </summary>
    internal static class ConditionCheckers
    {
       /// <summary>
       /// Checks if the sides form a square.
       /// </summary>
       /// <param name="sideOfLength">List of the length of sides entered by user.</param>
        public static void CheckIfSquare(List<float> sideOfLength)
        {
            for (int i = 0; i < (sideOfLength.Count - 1); i++)
            {
                if (sideOfLength[i] != sideOfLength[i + 1])
                {
                    Console.WriteLine("The given sides doesn't form a square");
                    return;
                }
            }

            Console.WriteLine("The given sides form a square.");
        }
    }
}