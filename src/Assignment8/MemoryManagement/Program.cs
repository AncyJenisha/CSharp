// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ValueAndReferenceType
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main receives input from user.
        /// </summary>
        private static void Main()
        {
            int valueTypeNumber = 1;
            int firstNumber = 1000;
            ReferenceTypeClass referenceTypeClass = new (firstNumber);
            Modifier(valueTypeNumber, referenceTypeClass);
            Console.WriteLine($"ValueType:{valueTypeNumber}\nReferenceType:{referenceTypeClass.ReferenceTypeNumber}");
            ReferenceTypeClass.ArrayofIntegers();
            ValueTypeClass.OperationOnValueType();
        }

        /// <summary>
        /// Modifier Method that modifies both value and reference type.
        /// </summary>
        /// <param name="firstNumber">Integer</param>
        /// <param name="secondNumber">ReferenceTypeClass</param>
        private static void Modifier(int firstNumber, ReferenceTypeClass secondNumber)
        {
            firstNumber++;
            secondNumber.ReferenceTypeNumber++;
        }
    }
}