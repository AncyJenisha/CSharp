// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GarbageCollection
{
    /// <summary>
    /// Program classhas the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The method gets the input from user.
        /// </summary>
        private static void Main()
        {
            while (true)
            {
                for (int i = 0; i < 10000000; i++)
                {
                    SampleClass sampleObject = new ();
                    if (i % 500000 == 0)
                    {
                        GC.Collect();
                    }
                }
            }
        }
    }
}