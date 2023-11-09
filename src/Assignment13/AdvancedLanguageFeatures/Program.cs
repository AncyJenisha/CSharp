// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace AdvancedLanguageFeatures
{
    /// <summary>
    /// Program class has the main method and the entry of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method that prints greeting message.
        /// </summary>
        /// <param name="message">Message entered by the user.</param>
        public static void GreetMessage(string? message)
        {
            Console.WriteLine($"Hello!! {message}");
        }

        /// <summary>
        /// Main method has the method subcribed to the event.
        /// </summary>
        private static void Main()
        {
            Notifier.Notify eventObject = new (GreetMessage);

            Notifier.OnAction += GreetMessage;
            Notifier.OnActionPerformed("This event is triggered");
        }
    }
}