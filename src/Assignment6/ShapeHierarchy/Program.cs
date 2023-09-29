// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeHierarchy
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method has objects for different shapes.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Enter the Length of Rectangle in cm");
            float length = InputReader.GetFloatInput();
            Console.WriteLine("Enter the Width of Rectangle in cm");
            float width = InputReader.GetFloatInput();
            Console.WriteLine("Enter the color of Rectangle");
            string color = InputReader.GetStringInput();
            var rectangle = new Rectangle(length, width, color);
            rectangle.PrintDetails();
            rectangle.GetArea();
            Console.WriteLine("Enter the radius of Circle in cm");
            float radius = InputReader.GetFloatInput();
            Console.WriteLine("Enter the color of Circle");
            string colour = InputReader.GetStringInput();
            var circle = new Circle(radius, colour);
            circle.PrintDetails();
            circle.GetArea();
        }
    }
}