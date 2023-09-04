// <copyright file="MathUtilis.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task5MathApp
{
    using MathApp;
    using Task5DisplayApp;

    /// <summary>
    /// Has the methods for the mathematical operations.
    /// </summary>
    public static class MathUtilis
    {
        /// <summary>
        /// Read Input gets numbers from user.
        /// </summary>
        public static void Readinput()
        {
            float number1, number2;
            int choiceofoperation;
            Console.WriteLine("Enter the first number:");
            number1 = Inputreader.GetInput();
            Console.WriteLine("Enter the second number:");
            number2 = Inputreader.GetInput();
            Console.WriteLine("The operations to be performed.\n 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division\n 5.Exit\n");
            Console.WriteLine("Enter your choice of operation");
            choiceofoperation = Inputreader.GetIntegerInput();
            Choice.ChoiceofMathoperation(choiceofoperation, number1, number2);
        }

        /// <summary>
        /// Adds two numbers and passes it to the display method.
        /// </summary>
        /// <param name="number1">The first number entered by user</param>
        /// <param name="number2">The second number entered by user</param>
        public static void Addition(float number1, float number2)
        {
            Task5DisplayApp.Program.Display(number1 + number2);
        }

        /// <summary>
        /// Subtracts number2 from number1 and passes it to display method.
        /// </summary>
        /// <param name="number1">The first number entered by user.</param>
        /// <param name="number2">The second number entered by user.</param>
        public static void Subtraction(float number1, float number2)
        {
            Task5DisplayApp.Program.Display(number1 - number2);
        }

        /// <summary>
        /// Multiplies number1 and number2 and passes it to display method.
        /// </summary>
        /// <param name="number1">The first number entered by user.</param>
        /// <param name="number2">The second number entered by user.</param>
        public static void Multiplication(float number1, float number2)
        {
            Task5DisplayApp.Program.Display(number2 * number1);
        }

        /// <summary>
        /// Divides number1 by number2 and passes it to display method.
        /// </summary>
        /// <param name="number1">The first number entered by user.</param>
        /// <param name="number2">The second number entered by user.</param>
        public static void Division(float number1, float number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("The second number cannot be zero");
            }
            else
            {
                Task5DisplayApp.Program.Display(number1 / number2);
            }
        }
    }
}