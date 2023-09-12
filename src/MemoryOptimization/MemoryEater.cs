// <copyright file="MemoryEater.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MemoryOptimization
{
    /// <summary>
    /// MemoryEater creates a list.
    /// </summary>
    public class MemoryEater
    {
        /// <summary>
        /// Allocate method adds integers to list.
        /// </summary>
        public static void Allocate()
        {
            while (true)
            {
                List<int[]>? memAlloc = new ();
                memAlloc.Add(new int[100000000]);
                Thread.Sleep(10);
            }
        }
    }
}