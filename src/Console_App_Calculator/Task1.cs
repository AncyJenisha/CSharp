// <copyright file="Task1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSharp1
{
    /// <summary>
    /// Class Task1 contains main method.
    /// </summary>
    public class Task1
    {
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

            int integer1, integer2, option, next;
            string num, n;
            do
            {
                getint1:
                Console.WriteLine("Enter integer1:");
                num = Console.ReadLine();
                if (string.IsNullOrEmpty(num))
                {
                    goto getint1;
                }

                try
                {
                    integer1 = Convert.ToInt32(num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number");
                    goto getint1;
                }

                getint2:
                Console.WriteLine("Enter integer2:");
                n = Console.ReadLine();
                if (string.IsNullOrEmpty(n))
                {
                    goto getint2;
                }

                try
                {
                    integer2 = Convert.ToInt32(n);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid input");
                    goto getint2;
                }

                getoption:
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Divison");
                Console.WriteLine("Enter the option: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MathUtils.Add(integer1, integer2);
                        break;
                    case 2:
                        MathUtils.Subtract(integer1, integer2);
                        break;
                    case 3:
                        MathUtils.Multiply(integer1, integer2);
                        break;
                    case 4:
                        MathUtils.Divide(integer1, integer2);
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        goto getoption;
                }

                Console.WriteLine("Enter 1 to continue");
                next = Convert.ToInt32(Console.ReadLine());
            }
            while (next == 1);
        }
    }
}