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
            InputValidator validator = new ();
            AssemblyInspector assemblyInspector = new ();
            DynamicObjectInspector dynamicObjectInspector = new ();
            Employee employee = new ();
            PropertyDisplayer propertyDisplayer = new ();
            ImplementPlugin implementPlugin = new ();
            Serializer serializer = new ();

            int choiceOfOperation;
            do
            {
                Console.WriteLine("Choose the operation\n1.Inspect Assembly MetaData\n2.Inspect Dynamic Object\n3.Set value to property\n4.Check Types which uses the interfaces and invoke them.\n5.Serialize the object\n6.Exit\n");
                choiceOfOperation = validator.GetIntegerInput();
                switch (choiceOfOperation)
                {
                    case (int)OperationOptions.InspectAssemblyMetaData:
                        assemblyInspector.GetAssemblyDetails();
                        assemblyInspector.GetPropertyDetails();
                        assemblyInspector.GetMethodDetails();
                        assemblyInspector.GetFieldDetails();
                        propertyDisplayer.DisplayMemberInformation(assemblyInspector.MemberType);
                        propertyDisplayer.DisplayPropertyInformation(assemblyInspector.PropertyTypes);
                        propertyDisplayer.DisplayMethodInformation(assemblyInspector.MethodType);
                        propertyDisplayer.DisplayFieldInformation(assemblyInspector.FieldTypes);
                        break;

                    case (int)OperationOptions.InspectDynamicObject:
                        dynamicObjectInspector.InspectDynamicObject(employee);
                        break;

                    case (int)OperationOptions.SetValueToProperty:
                        propertyDisplayer.DisplayPropertyValue(dynamicObjectInspector.SetValueToProperty(employee, "Ancy"));
                        break;

                    case (int)OperationOptions.InpectInterfaces:
                        implementPlugin.GetAssemblyDetails();
                        implementPlugin.GetInterfaces();
                        propertyDisplayer.DisplayMemberInformation(implementPlugin.MemberType);
                        propertyDisplayer.DisplayInterfaceTypes(implementPlugin.InterfaceType);
                        implementPlugin.CallMethodsThroughPlugin();
                        break;

                    case (int)OperationOptions.SerializeObject:
                        serializer.SerializeObject(employee);
                        break;

                    case (int)OperationOptions.Exit:
                        break;

                    default:
                        Console.WriteLine("Choose a valid option");
                        break;
                }
            }
            while (choiceOfOperation != 6);
        }
    }
}