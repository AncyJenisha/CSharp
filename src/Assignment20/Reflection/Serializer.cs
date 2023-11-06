// <copyright file="Serializer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Reflection
{
    using System.Reflection;

    /// <summary>
    /// Serializer - Has methods to serilize the object.
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// Gets or sets the Properties of the type.
        /// </summary>
        /// <value>PropertyInfo as array</value>
        public PropertyInfo[] PropertyTypes { get; set; }

        /// <summary>
        /// Gets or sets the methods from the type.
        /// </summary>
        /// <value>MethodInfo as array</value>
        public MethodInfo[] MethodType { get; set; }

        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <param name="obj">The object to be serialized.</param>
        public void SerializeObject(object obj)
        {
            if (obj != null)
            {
                this.PropertyTypes = obj.GetType().GetTypeInfo().GetProperties();

                foreach (PropertyInfo property in this.PropertyTypes)
                {
                    Console.WriteLine($"{{\"{property.Name}\" : \"{property.GetValue(obj)}\"}}\n");
                }
            }
        }
    }
}