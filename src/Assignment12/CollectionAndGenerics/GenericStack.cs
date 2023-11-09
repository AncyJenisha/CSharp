// <copyright file="GenericStack.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// Has methods for operations for a generic stack.
    /// </summary>
    /// <typeparam name="T">Generic Type parameter.</typeparam>
    public class GenericStack<T>
    {
        /// <summary>
        /// Gets or Sets characters to be stored in stack.
        /// <typeparam name = "T" >Generic parameter.</typeparam>
        /// </summary>
        /// <value>Character as elements.</value>
        public static Stack<T> Characters { get; set; } = new Stack<T>();

        /// <summary>
        /// Gets the count of the GenericStack.
        /// </summary>
        /// <value>Integer as count</value>
        public int Count => Characters.Count;

        /// <summary>
        /// Adds a character to the Stack.
        /// </summary>
        /// <param name="characterToBeAddedToTheStack">Generic type to character.</param>
        public void AddCharactersToStack(T characterToBeAddedToTheStack)
        {
            Characters.Push(characterToBeAddedToTheStack);
        }

        /// <summary>
        /// Removes a character from the stack.
        /// </summary>
        public void RemoveCharacters()
        {
            if (Characters.Count > 0)
            {
                Console.WriteLine(Characters.Pop());
            }
            else
            {
                Console.WriteLine("Stack is Empty");
            }
        }

        /// <summary>
        /// Displays the characters from the list.
        /// </summary>
        public void DisplayCharacters()
        {
            if (this.Count == 0)
            {
                Console.WriteLine("No characters to display");
            }
            else
            {
                foreach (T character in Characters)
                {
                    Console.WriteLine(character);
                }
            }
        }
    }
}