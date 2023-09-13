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
            int valuetypenumber = 1;
            int number1 = 1000;
            ReferenceTypeClass referencetypeclass = new (number1);
            Modifier(valuetypenumber, referencetypeclass);
            Console.WriteLine($"ValueType:{valuetypenumber}\nReferenceType:{referencetypeclass.Referencetypenumber}");
            ReferenceTypeClass.ArrayofIntegers();
            ValueTypeClass.OperationOnValueType();
        }

        /// <summary>
        /// Modifier Method that modifies both value and reference type.
        /// </summary>
        /// <param name="number1">Integer</param>
        /// <param name="number2">ReferenceTypeClass</param>
        private static void Modifier(int number1, ReferenceTypeClass number2)
        {
            number1++;
            number2.Referencetypenumber++;
        }
    }
}