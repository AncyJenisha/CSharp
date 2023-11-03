// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    /// <summary>
    /// Program class has the main method which is the entry for the program.
    /// </summary>
    internal partial class Program
    {
        /// <summary>
        /// Main -
        /// </summary>
        private static void Main()
        {
            InputValidator validator = new InputValidator();
            AssemblyInspector assemblyInspector = new ();
            PropertyDisplayer propertyDisplayer = new PropertyDisplayer();
            int choiceOfOperation;
            Console.WriteLine("Choose the operation\n1.Inspect Assembly MetaData\n2.");
            choiceOfOperation = validator.GetIntegerInput();
            switch (choiceOfOperation)
            {
                case (int)OperationOptions.InspectAssemblyMetaData:
                    assemblyInspector.GetAssemblyDetails();
                    assemblyInspector.GetPropertyDetails();
                    assemblyInspector.GetMethodDetails();
                    propertyDisplayer.DisplayMemberInformation(assemblyInspector.MemberType);
                    propertyDisplayer.DisplayPropertyInformation(assemblyInspector.PropertyTypes);
                    propertyDisplayer.DisplayMethodInformation(assemblyInspector.MethodType);
                    propertyDisplayer.DisplayFieldInformation(assemblyInspector.FieldTypes);
                    break;

                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
    }
}