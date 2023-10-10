// <copyright file="ShapeOperators.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatres
{
    /// <summary>
    /// ShapeOperators has the methods to display the list of shapes.
    /// </summary>
    public class ShapeOperators
    {
        /// <summary>
        /// Displays the shapeDetails
        /// </summary>
        /// <param name="shape">Shape object</param>
        public static void DisplayShapeDetails(Shapes shape)
        {
            switch (shape)
            {
                case Rectangle rectangle:
                    Console.WriteLine($"The shape is  rectangle with length {rectangle.Length}cm and breadth {rectangle.Breadth}cm and area {rectangle.CalculateArea()}sq.cm");
                    break;
                case Circle circle:
                    Console.WriteLine($"The shape is Circle with radius of {circle.Radius}cm and area of {circle.CalculateArea()}sq.cm");
                    break;
                case Triangle triangle:
                    Console.WriteLine($"The shape is Triangle with length of {triangle.Length}cm and breadth of {triangle.Breadth}cm and area {triangle.CalculateArea()}sq.cm");
                    break;
                default:
                    Console.WriteLine("Unknown shape");
                    break;
                case null:
                    Console.WriteLine("Provided shape is null");
                    break;
            }
        }
    }
}