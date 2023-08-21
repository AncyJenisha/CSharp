// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ConsoleAppCalculator
{
    /// <summary>
    /// Class Task1 contains main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Options has all the arithmetic operations in order.
        /// </summary>
        private enum Options
        {
            Addition = 1,
            Subtraction,
            Multiplication,
            Divison,
        }

        /// <summary>
        /// Main method recieves two integers from user
        /// </summary>
        /// <param name="args">reads a line</param>
        /// <exception cref="ArgumentNullException">Throws exception when args is null</exception>
        public static void Main(string[] args)
        {
            float integer1, integer2;
            int option;
            string? stop;
            do
            {
                Console.WriteLine("Enter the first number:");
                integer1 = GetInput();
                Console.WriteLine("Enter the second number:");
                integer2 = GetInput();
            getoption:
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Divison");
                Console.WriteLine("Enter the option: ");
                option = GetIntegerInput();
                switch (option)
                {
                    case (int)Options.Addition:
                        MathUtils.Add(integer1, integer2);
                        break;
                    case (int)Options.Subtraction:
                        MathUtils.Subtract(integer1, integer2);
                        break;
                    case (int)Options.Multiplication:
                        MathUtils.Multiply(integer1, integer2);
                        break;
                    case (int)Options.Divison:
                        MathUtils.Divide(integer1, integer2);
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        goto getoption;
                }

                Console.WriteLine("Enter 1 to stop");
                stop = Console.ReadLine();
            }
            while (stop != "1");
        }

        /// <summary>
        /// GetInput method gets input as string and converts to float.
        /// </summary>
        /// <returns>Input converted to float</returns>
        public static float GetInput()
        {
        getfloat:
            string? n = Console.ReadLine();
            if (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Enter a valid number");
                goto getfloat;
            }

            if (!float.TryParse(n, out float number))
            {
                Console.WriteLine("Enter a valid number");
                goto getfloat;
            }

            return number;
        }

        /// <summary>
        /// GetIntegerInput method gets input as string and converts to integer
        /// </summary>
        /// <returns>Input converted to integer</returns>
        public static int GetIntegerInput()
        {
        getint:
            string? n = Console.ReadLine();
            if (string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Enter a valid number");
                goto getint;
            }

            if (!int.TryParse(n, out int integer))
            {
                Console.WriteLine("Enter a valid number");
                goto getint;
            }

            return integer;
        }
    }
}