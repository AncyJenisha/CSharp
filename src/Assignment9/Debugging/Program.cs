// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Debugging
{
    /// <summary>
    /// Program class has main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Enter the length of the sides in cm");
            List<float> lengthOfSide = new List<float>();
            for (int i = 0; i < 4; i++)
            {
                float side = InputReaders.GetFloatInput();
                lengthOfSide.Add(side);
            }

            ConditionCheckers.CheckIfSquare(lengthOfSide);
        }
    }
}