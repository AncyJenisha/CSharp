// <copyright file="ImplementPlugin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    using System.Reflection;

    /// <summary>
    /// ImplemantPlugin - Has methods and properties to inspect the plugin interfaces.
    /// </summary>
    public class ImplementPlugin
    {
        private Assembly _assembly = Assembly.LoadFile(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// Gets or sets the methods from the type.
        /// </summary>
        /// <value>Type </value>
        public Type MethodType { get; set; }

        /// <summary>
        /// Gets or sets the types of the assembly.
        /// </summary>
        /// <value>MemeberInfo as array</value>
        public Type[] MemberType { get; set; }

        /// <summary>
        /// Gets or sets the method from the plugin to be invoked.
        /// </summary>
        /// <value>The method to be invoked.</value>
        public MethodInfo MethodToBeInvoked { get; set; }

        /// <summary>
        /// Gets or sets the methods from the type.
        /// </summary>
        /// <value>MethodInfo </value>
        public Type InterfaceType { get; set; }

        /// <summary>
        /// GetAssemblyDetails - Gets the assembly types as array.
        /// </summary>
        public void GetAssemblyDetails()
        {
            this.MemberType = this._assembly.GetTypes();
        }

        /// <summary>
        /// GetMethodDetails - Gets the methods of the type.
        /// </summary>
        public void GetInterfaces()
        {
            foreach (var type in this.MemberType)
            {
                if (type.GetInterface("IBankAccount") != null)
                {
                    this.InterfaceType = type;
                }
            }
        }

        /// <summary>
        /// CallMethodsThroughtPlugin - Calls the methods through the interface.
        /// </summary>
        public void CallMethodsThroughPlugin()
        {
            var instance = Activator.CreateInstance(this.InterfaceType);

            this.MethodToBeInvoked = this.InterfaceType.GetMethod("WithdrawAmount");

            var invoked = this.MethodToBeInvoked.Invoke(instance, new object[] { 1500F });
        }
    }
}