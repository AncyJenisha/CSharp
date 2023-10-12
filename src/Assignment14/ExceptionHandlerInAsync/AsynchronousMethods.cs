// <copyright file="AsynchronousMethods.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ExceptionHandlerInAsync
{
    /// <summary>
    /// Has asynchronous methods.
    /// </summary>
    public class AsynchronousMethods
    {
       /// <summary>
       /// A void Async method.
       /// </summary>
       /// <exception cref="NotImplementedException">Throws an execption</exception>
        public static async void VoidMethod()
        {
            await Task.Delay(1000);
            throw new Exception();
        }

        /// <summary>
        /// A Async Task Method.
        /// </summary>
        /// <returns>Task method</returns>
        /// <exception cref="NotImplementedException">Throws a exception.</exception>
        public static async Task TaskMethod()
        {
            await Task.Delay(1000);
            throw new Exception();
        }
    }
}