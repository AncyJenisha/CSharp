// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment6
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Enter the Length of Rectangle in cm");
            float length = InputReader.GetFloatInput();
            Console.WriteLine("Enter the Width of Rectangle in cm");
            float width = InputReader.GetFloatInput();
            Console.WriteLine("Enter the color of Rectangle");
            string color = InputReader.GetStringInput();
            var ra = new Rectangle(length, width, color);
            ra.PrintDetails();
            ra.GetArea();
            Console.WriteLine("Enter the radius of Circle in cm");
            float radius = InputReader.GetFloatInput();
            Console.WriteLine("Enter the color of Circle");
            string color1 = InputReader.GetStringInput();
            var cr = new Circle(radius, color1);
            cr.PrintDetails();
            cr.GetArea();
        }
    }
}