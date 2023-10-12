// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ExceptionHandlerInAsync
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method calls the asynchronous methods.
        /// </summary>
        /// <returns>Task Object</returns>
        public static async Task Main()
        {
           /* try
            {
                AsynchronousMethods.VoidMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }*/

            try
            {
                await AsynchronousMethods.TaskMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}