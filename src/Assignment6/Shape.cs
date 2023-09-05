// <copyright file="Shape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment6
{
    /// <summary>
    /// Class Shape is abstract and has methods to calculate area and print details.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Gets or sets has the color of the shape.
        /// </summary>
        /// <value>string as color of the shape.</value>
        public string? Color { get; set; }

        /// <summary>
        /// GetArea has the area of the shape.
        /// </summary>
        /// <returns>Area</returns>
        public abstract float GetArea();

        /// <summary>
        /// It prints the details of the shape.
        /// </summary>
        public abstract void PrintDetails();
    }
}