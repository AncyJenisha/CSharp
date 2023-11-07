// <copyright file="AssemblyInspector.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    using System.Reflection;

    /// <summary>
    /// AssemblyInspector - Has methods and Properties for inspecting the assembly.
    /// </summary>
    public class AssemblyInspector
    {
        private Assembly _assembly = Assembly.LoadFile(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// Gets or sets the types of the assembly.
        /// </summary>
        /// <value>MemeberInfo as array</value>
        public MemberInfo[] MemberType { get; set; }

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
        /// Gets or sets the fields from the type.
        /// </summary>
        /// <value>FieldInfo as array</value>
        public FieldInfo[] FieldTypes { get; set; }

        /// <summary>
        /// Gets or sets the events from the type.
        /// </summary>
        /// <value>EventInfo as array</value>
        public EventInfo[] EventTypes { get; set; }

        /// <summary>
        /// GetAssemblyDetails - Gets the assembly types as array.
        /// </summary>
        public void GetAssemblyDetails()
        {
            this.MemberType = this._assembly.GetTypes();
        }

        /// <summary>
        /// GetPropertyDetails - Gets the property of type as array.
        /// </summary>
        public void GetPropertyDetails()
        {
            this.PropertyTypes = this.MemberType.GetType().GetTypeInfo().GetProperties();
        }

        /// <summary>
        /// GetMethodDetails - Gets the methods of the type.
        /// </summary>
        public void GetMethodDetails()
        {
            this.MethodType = this.MemberType.GetType().GetMethods();
        }

        /// <summary>
        /// GetFieldDetails - Gets the fields of the type.
        /// </summary>
        public void GetFieldDetails()
        {
            this.FieldTypes = this.MemberType.GetType().GetFields();
        }

        /// <summary>
        /// GetEventDetails - Gets the events of the type.
        /// </summary>
        public void GetEventDetails()
        {
            this.EventTypes = this.MemberType.GetType().GetEvents();
        }
    }
}