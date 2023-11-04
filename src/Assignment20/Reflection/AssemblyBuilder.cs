// <copyright file="AssemblyBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    public class TypeBuilder
    {
        public void BuildAssembly()
        {
            var aName = new AssemblyName("DynamicAssemblyExample");
            AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(aName,AssemblyBuilderAccess.Run);
        }
    }
}