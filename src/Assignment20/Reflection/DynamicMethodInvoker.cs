// <copyright file="DynamicMethodInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// DynamicNethodInvoker - Has methods to invoke the methods from array of methodInfo.
    /// </summary>
    public class DynamicMethodInvoker
    {
        /// <summary>
        /// Gets or sets the method information as array.
        /// </summary>
        /// <value>Array of methodinfo</value>
        public MethodInfo[] MethodType { get; set; }

        /// <summary>
        /// Gets or sets the invoked method objects as array.
        /// </summary>
        /// <value>Array of invoked methods.</value>
        public object[] MethodValue { get; set; }

        /// <summary>
        /// InvokeMethod - invokes the methods from the methodInfoArray.
        /// </summary>
        /// <param name="obj">The object of the class whose methods needs to invoked</param>
        public void InvokeMethod(object obj)
        {
            this.MethodType = obj.GetType().GetMethods();
            for (int i = 0; i < this.MethodType.Length; i++)
            {
                this.MethodValue[i] = this.MethodType[i].Invoke(obj, null);
            }
        }
    }
}