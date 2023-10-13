// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace IdisposableImplementation
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Method creates an object for managed and unmanaged resources class and calls its methods.
        /// </summary>
        private static void Main()
        {
            ManagedResources managedResources = new ();
            managedResources.AddData("Hello World!");
            Console.WriteLine(managedResources.ListOfData[0]);
            managedResources.Dispose();
            Console.WriteLine(managedResources.ListOfData.Count);

            UnmanagedResources unmanagedResources = new ("Test.txt");
            unmanagedResources.WriteToFile("Hello World!!");
            unmanagedResources.Dispose();
        }
    }
}