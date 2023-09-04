// <copyright file="Choice.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MathApp
{
    using Task5MathApp;

    /// <summary>
    /// It has the options for the mathematical operations to be
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// Options enum has the mathematical operations to be performed.
        /// </summary>
        private enum Options
        {
            Addition = 1,
            Subtraction,
            Multiplication,
            Division,
            Exit,
        }

        /// <summary>
        /// Gets input from user and calls the corresponding method of math operation.
        /// </summary>
        /// <param name="choiceofoperation">The option chosen by the user for the mathematical operation to be performed.</param>
        /// <param name="number1">The first number entered by user</param>
        /// <param name="number2">The second number entered by user</param>
        public static void ChoiceofMathoperation(int choiceofoperation, float number1, float number2)
        {
            switch (choiceofoperation)
            {
                case (int)Options.Addition:
                    MathUtilis.Addition(number1, number2);
                    break;

                case (int)Options.Subtraction:
                    MathUtilis.Subtraction(number1, number2);
                    break;

                case (int)Options.Multiplication:
                    MathUtilis.Multiplication(number1, number2);
                    break;

                case (int)Options.Division:
                    MathUtilis.Division(number1, number2);
                    break;

                case (int)Options.Exit:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}