// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeHierarchy
{
    /// <summary>
    /// Rectangle class is derived from shape class.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// Assigns value to length and width of the class.
        /// </summary>
        /// <param name="length">Legth as float.</param>
        /// <param name="width">Width as float.</param>
        /// <param name="color">Color as string.</param>
        public Rectangle(float length, float width, string color)
        {
            this.Length = length;
            this.Width = width;
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets has the length of the shape.
        /// </summary>
        private float Length { get; set; }

        /// <summary>
        /// Gets or sets has the width of the shape.
        /// </summary>
        private float Width { get; set; }

        /// <summary>
        /// Gets Area of the shape.
        /// </summary>
        /// <returns>Area as float</returns>
        public override float GetArea() => this.Length * this.Width;

        /// <summary>
        /// Prints details of the shape.
        /// </summary>
        public override void PrintDetails()
        {
            Console.WriteLine("\nRectangle");
            Console.WriteLine($"Color={this.Color}");
            Console.WriteLine("Shape Type = Rectangle");
            Console.WriteLine($"Area={this.GetArea()} cm\n");
        }
    }
}