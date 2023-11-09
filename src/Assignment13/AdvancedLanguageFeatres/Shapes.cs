// <copyright file="Shapes.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatres
{
    /// <summary>
    /// Is the base class and has the properties for shapes
    /// </summary>
    public abstract class Shapes
    {
        /// <summary>
        /// Gets or sets the name of the shape.
        /// </summary>
        /// <value>Shape name as string.</value>
        public string? ShapeType { get; set; }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>Area as float.</returns>
        public abstract float CalculateArea();
    }
}