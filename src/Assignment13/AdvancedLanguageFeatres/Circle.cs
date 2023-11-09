// <copyright file="Circle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatres
{
    /// <summary>
    /// Circle is derived class from base class Shapes.
    /// </summary>
    public class Circle : Shapes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Radius as float value entered by user.</param>
        public Circle(float radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius of the circle.
        /// </summary>
        /// <value>Radius as float value</value>
        public float Radius { get; set; }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>Area as float</returns>
        public override float CalculateArea()
        {
            float area = 0.628F * this.Radius;
            return area;
        }
    }
}