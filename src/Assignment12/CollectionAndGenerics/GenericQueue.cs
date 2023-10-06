// <copyright file="GenericQueue.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// Has methods for operations on GenericQueue
    /// </summary>
    /// <typeparam name="T">Generic Type parameter.</typeparam>
    public class GenericQueue<T>
    {
        /// <summary>
        /// Gets or Sets the Names as string to the generic list.
        /// </summary>
        /// <value>Names as String.</value>
        public static Queue<T> GenericQueueOfNames { get; set; } = new Queue<T>();

        /// <summary>
        /// Gets the count of Generic Queue.
        /// </summary>
        /// <value>Count as integer</value>
        public int QueueCount => GenericQueueOfNames.Count;

        /// <summary>
        /// Adds the name to the Queue.
        /// </summary>
        /// <param name="nameToBeAddedToQueue">Adds the name as String.</param>
        public void AddName(T nameToBeAddedToQueue)
        {
            GenericQueueOfNames.Enqueue(nameToBeAddedToQueue);
        }

        /// <summary>
        /// Removes name from GenericQueue.
        /// </summary>
        public void RemoveName()
        {
            if (this.QueueCount > 0)
            {
                GenericQueueOfNames.Dequeue();
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }

        /// <summary>
        /// Displays the queue elements.
        /// </summary>
        public void DisplayNames()
        {
            if (GenericQueueOfNames.Count == 0)
            {
                Console.WriteLine("No names to display");
            }
            else
            {
                foreach (var queue in GenericQueueOfNames)
                {
                    Console.WriteLine(queue);
                }
            }
        }
    }
}