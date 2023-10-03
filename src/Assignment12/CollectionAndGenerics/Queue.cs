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
        private static Queue<string> QueueOfNames { get; set; } = new Queue<string>();

        /// <summary>
        /// Adds a string at the last of the Queue.
        /// </summary>
        public static void EnqueueNames()
        {
            string nameToBeAddedToQueue = InputValidators.GetStringInput();
            QueueOfNames.Enqueue(nameToBeAddedToQueue);
        }

        /// <summary>
        /// Removes the first string from the QueueOfNames.
        /// </summary>
        public static void DequeueNames()
        {
            QueueOfNames.Dequeue();
        }

        /// <summary>
        /// Displays the queue elements.
        /// </summary>
        public static void DisplayQueue()
        {
            foreach (var queue in QueueOfNames)
            {
                Console.WriteLine(queue);
            }
        }
    }
}