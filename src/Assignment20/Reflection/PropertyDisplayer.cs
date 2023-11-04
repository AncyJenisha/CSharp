// <copyright file="PropertyDisplayer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    using System.Reflection;

    /// <summary>
    /// PropertyDisplayer - Has methods to display the assembly information.
    /// </summary>
    public class PropertyDisplayer
    {
        /// <summary>
        /// DisplayMemberInformation - Displays the types in the assembly.
        /// </summary>
        /// <param name="assemblyTypes">Array of types in the assembly.</param>
        public void DisplayMemberInformation(MemberInfo[] assemblyTypes)
        {
            Console.WriteLine("Types in the Assembly\n");

            foreach (var assembly in assemblyTypes)
            {
                Console.WriteLine(assembly);
            }
        }

        /// <summary>
        /// DisplayPropertyInformation - Displays the Properties of the Types.
        /// </summary>
        /// <param name="memberProperties">Array of types in the assembly.</param>
        public void DisplayPropertyInformation(PropertyInfo[] memberProperties)
        {
            Console.WriteLine("\n\nProperties of the member:\n");

            foreach (var member in memberProperties)
            {
                Console.WriteLine(member);
            }
        }

        /// <summary>
        /// DisplayMethodInformation - Displays the methods of the Types.
        /// </summary>
        /// <param name="methodNames">Array of methods in the type.</param>
        public void DisplayMethodInformation(MemberInfo[] methodNames)
        {
            Console.WriteLine("\n\nTypes of the method:\n");

            foreach (var method in methodNames)
            {
                Console.WriteLine(method.Name);
            }
        }

        /// <summary>
        /// DisplayFieldInformation - Displays the field.
        /// </summary>
        /// <param name="fields">FieldInfo as array.</param>
        public void DisplayFieldInformation(FieldInfo[] fields)
        {
            Console.WriteLine("\n\nFields in the type:\n");

            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
            }
        }

        /// <summary>
        /// DisplayFieldInformation - Displays the field.
        /// </summary>
        /// <param name="propertyInfo">FieldInfo as array.</param>
        public void DisplayPropertyValue(PropertyInfo propertyInfo)
        {
            Employee employee = new Employee();
            Console.WriteLine("\n\nProperties in the object:\n");
            Console.WriteLine($"Changed Property Value : {propertyInfo.GetValue(employee)}");
        }
    }
}