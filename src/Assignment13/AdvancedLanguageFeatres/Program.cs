// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdvancedLanguageFeatres
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets or sets List of Shape objects.
        /// </summary>
        /// <value>List of objects.</value>
        public static List<Shapes> ListOfShapes { get; set; } = new ();

        /// <summary>
        /// Main method has the entry of the program
        /// </summary>
        private static void Main()
        {
            ListOfShapes.Add(new Circle(14.02F));
            ListOfShapes.Add(new Rectangle(13.25F, 14.25F));
            ListOfShapes.Add(new Triangle(45.02F, 35.13F));
            ListOfShapes.Add(new Circle(13.16F));
            ListOfShapes.Add(new Triangle(18.23F, 25.25F));

            foreach (var shape in ListOfShapes)
            {
                ShapeOperators.DisplayShapeDetails(shape);
            }
        }
    }
}