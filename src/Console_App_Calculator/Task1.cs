// <copyright file="Task1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ConsoleAppCalculator
{
    /// <summary>
    /// Class Task1 contains main method.
    /// </summary>
    public class Task1
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
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int integer1, integer2, option, stop;
            do
            {
                Console.WriteLine("Enter Integer1:");
                integer1 = GetInput();
                Console.WriteLine("Enter Integer2:");
                integer2 = GetInput();
            getoption:
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Divison");
                Console.WriteLine("Enter the option: ");
                option = GetInput();
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
                stop = GetInput();
            }
            while (stop != 1);
        }

        /// <summary>
        /// GetInput method gets input as string and converts to integer
        /// </summary>
        /// <returns>input converted to integer</returns>
        public static int GetInput()
        {
        getint:
            string? n = Console.ReadLine();
            if (string.IsNullOrEmpty(n))
            {
                goto getint;
            }

            bool convert = int.TryParse(n, out int integer);
            if (convert != true)
            {
                Console.WriteLine("Enter a valid number");
                goto getint;
            }

            return integer;
        }
    }
}