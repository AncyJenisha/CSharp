// <copyright file="DynamicObjectInspector.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    using System.Reflection;

    /// <summary>
    /// DynamicObjectInspector - Gets an object as input and display and change its Properties.
    /// </summary>
    public class DynamicObjectInspector
    {
        /// <summary>
        /// Gets or sets the property information as array
        /// </summary>
        /// <value>PropertyInfo as array elements</value>
        public PropertyInfo[]? Properties { get; set; }

        /// <summary>
        /// InspectDynamicObject - inspects the Properties of the object.
        /// </summary>
        /// <param name="obj">The object to be inspected.</param>
        /// <returns>PropertyInfo as array</returns>
        public PropertyInfo[] InspectDynamicObject(object obj)
        {
            Console.WriteLine($"Type of Object : {obj.GetType()}");
            this.Properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in this.Properties)
            {
                Console.WriteLine($"Property name: {property.Name}; Property value :{property.GetValue(obj)}");
            }

            return this.Properties;
        }

        /// <summary>
        /// Sets the value to the property of the object
        /// </summary>
        /// <param name="obj">The object whose property to be changed</param>
        /// <param name="name">The value to be set to the property</param>
        /// <returns>PropertInfo as array</returns>
        public PropertyInfo SetValueToProperty(object obj, string name)
        {
            PropertyInfo? propertyInfo = obj.GetType().GetProperty("Name");
            propertyInfo.SetValue(obj, name, null);
            return propertyInfo;
        }
    }
}