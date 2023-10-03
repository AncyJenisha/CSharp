// <copyright file="StackOfCharacters.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CollectionAndGenerics
{
    /// <summary>
    /// Stack has the methods to perform operations on stack.
    /// </summary>
    public static class StackOfCharacters
    {
        /// <summary>
        /// Gets or Sets characters to be stored in stack.
        /// <typeparam name = "T" >The value is double type.</typeparam>
        /// </summary>
        private static Stack<T> StackOfCharcters { get; set; } = new ();

        /// <summary>
        /// Push a character to the stack.
        /// </summary>
        public static void PushCharacterToStack()
        {
            char characterToBeAddedToTheStack;
            Console.WriteLine("Enter the character to be pushed\n");
            characterToBeAddedToTheStack = InputValidators.GetInput();
            StackOfCharcters.Push(characterToBeAddedToTheStack);
        }

        /// <summary>
        /// Pops the character from the stack.
        /// </summary>
        public static void PopCharacterToStack()
        {
            if (StackOfCharcters.Count > 0)
            {
                Console.WriteLine(StackOfCharcters.Pop().ToString());
            }
            else
            {
                Console.WriteLine("The stack is empty\n");
            }
        }

        /// <summary>
        /// Displays the Stack Elements.
        /// </summary>
        public static void DisplayStackElements()
        {
            foreach (char c in StackOfCharcters)
            {
                Console.WriteLine(c);
            }
        }
    }
}