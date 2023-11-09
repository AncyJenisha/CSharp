// <copyright file="Queue.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// Queue has methods for operations to be performed on the queue.
    /// </summary>
    public static class Queue
    {
        /// <summary>
        /// Gets or sets elements to the Generic Queue.
        /// </summary>
        private static GenericQueue<string> QueueOfNames { get; set; } = new ();

        /// <summary>
        /// Adds a string at the last of the Queue.
        /// </summary>
        public static void EnqueueNames()
        {
            Console.WriteLine("Enter the Name:");
            string nameToBeAddedToQueue = InputValidators.GetStringInput();
            QueueOfNames.AddName(nameToBeAddedToQueue);
        }

        /// <summary>
        /// Removes the first string from the Names.
        /// </summary>
        public static void DequeueNames()
        {
            QueueOfNames.RemoveName();
        }
    }
}