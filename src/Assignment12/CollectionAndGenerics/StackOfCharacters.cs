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
        private static GenericStack<char> StackOfCharactersObject { get; set; } = new ();

        /// <summary>
        /// Push a character to the stack.
        /// </summary>
        public static void PushCharacterToStack()
        {
            char characterToBeAddedToTheStack;
            Console.WriteLine("Enter the character to be pushed:");
            characterToBeAddedToTheStack = InputValidators.GetCharacterInput();
            StackOfCharactersObject.AddCharactersToStack(characterToBeAddedToTheStack);
        }

        /// <summary>
        /// Pops the character from the stack.
        /// </summary>
        /// </summary>
        public static void PopCharacterToStack()
        {
            if (StackOfCharactersObject.GenericStackCount > 0)
            {
                StackOfCharactersObject.RemoveCharacters();
            }
            else
            {
                Console.WriteLine("The stack is empty\n");
            }
        }
    }
}