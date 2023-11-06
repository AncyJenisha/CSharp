﻿// <copyright file="OperationOptions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    /// <summary>
    /// Has the options for operation.
    /// </summary>
    public enum OperationOptions
    {
        /// <summary>
        /// Calls the methods for inspecting assembly metadata.
        /// </summary>
        InspectAssemblyMetaData = 1,

        /// <summary>
        /// Calls the method to inspect dynamic object.
        /// </summary>
        InspectDynamicObject,

        /// <summary>
        /// Calls the method to set value to the property of the object.
        /// </summary>
        SetValueToProperty,

        /// <summary>
        /// Calls the method to get the types which implement the interfaces.
        /// </summary>
        InpectInterfaces,

        /// <summary>
        /// Serializes the object and displays the serialized object.
        /// </summary>
        SerializeObject,

        /// <summary>
        /// Exits the program.
        /// </summary>
        Exit,
    }
}