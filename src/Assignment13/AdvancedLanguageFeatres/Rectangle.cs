// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatres
{
    /// <summary>
    /// Rectangle class is derived class from base class shapes.
    /// </summary>
    public class Rectangle : Shapes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">Length entered by user as float</param>
        /// <param name="breadth">Breadth entered by user as float</param>
        public Rectangle(float length, float breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }

        /// <summary>
        /// Gets or sets Length as float
        /// </summary>
        /// <value>Length as float.</value>
        public float Length { get; set; }

        /// <summary>
        /// Gets or sets breadth as float
        /// </summary>
        /// <value>Breadth entered by user</value>
        public float Breadth { get; set; }

        /// <summary>
        /// Calculates area of Rectangle.
        /// </summary>
        /// <returns>Area as float</returns>
        public override float CalculateArea()
        {
            float area = this.Length * this.Breadth;
            return area;
        }
    }
}