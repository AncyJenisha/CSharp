// <copyright file="Triangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatres
{
    /// <summary>
    /// Derived class with shape as base class
    /// </summary>
    public class Triangle : Shapes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="length">Length entered by user as input</param>
        /// <param name="breadth">breadth entered by user as input</param>
        public Triangle(float length, float breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }

        /// <summary>
        /// Gets or sets the length of the triangle.
        /// </summary>
        /// <value>Length as float value</value>
        public float Length { get; set; }

        /// <summary>
        /// Gets or sets the breadth of the triangle.
        /// </summary>
        /// <value>Breadth as float value</value>
        public float Breadth { get; set; }

        /// <summary>
        /// Calculates area from the length and breadth.
        /// </summary>
        /// <returns>Area as float</returns>
        public override float CalculateArea()
        {
            float area = 0.5F * this.Length * this.Breadth;
            return area;
        }
    }
}