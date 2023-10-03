// <copyright file="Circle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeHierarchy
{
    /// <summary>
    /// Circle is a derived class of Shape.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// Circle gets the radius and sets its value to circle.
        /// </summary>
        /// <param name="radius">radius given by user as float value</param>
        /// <param name="color">color given by user as input</param>
        public Circle(float radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets radius gets and sets the value.
        /// </summary>
        private float Radius { get; set; }

        /// <summary>
        /// Gives the area of the Shape.
        /// </summary>
        /// <returns>Area as float</returns>
        public override float GetArea() => 6.24F * this.Radius;

        /// <summary>
        /// Prints the details of the Shape.
        /// </summary>
        public override void PrintDetails()
        {
            Console.WriteLine("\nCircle");
            Console.WriteLine($"Color= {this.Color}");
            Console.WriteLine("Shape Type = Circle");
            Console.WriteLine($"Area={this.GetArea()}cm\n");
        }
    }
}