// <copyright file="Notifier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatures
{
    /// <summary>
    /// Has the delegete notify
    /// </summary>
    public static class Notifier
    {
        /// <summary>
        /// Points to functions that gets a string as input and returns void.
        /// </summary>
        /// <param name="message">Message as string input parameter</param>
        public delegate void Notify(string message);

        /// <summary>
        /// Handles the messages of the notifying delegate.
        /// </summary>
        public static event Notify? OnAction;

        /// <summary>
        /// Invokes the greet message function.
        /// </summary>
        /// <param name="message">Meassage to be passed with the event.</param>
        public static void OnActionPerformed(string message)
        {
            OnAction?.Invoke(message);
        }
    }
}