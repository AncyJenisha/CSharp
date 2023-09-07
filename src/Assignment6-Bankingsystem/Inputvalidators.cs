// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment6_Bankingsystem
{
    internal static class Inputvalidators
    {
        public static int GetInput()
        {
            int integer;
            string? n = Console.ReadLine();
            while (!int.TryParse(n, out integer))
            {
                Console.WriteLine("Enter valid Number");
                n = Console.ReadLine();
            }

            return integer;
        }
    }
}