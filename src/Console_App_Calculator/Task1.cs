// <copyright file="Task1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ConsoleCalculator
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

            int integer1, integer2, option, stop;
            string? n1, n2;
            do
            {
            getint1:
                Console.WriteLine("Enter integer1:");
                n1 = Console.ReadLine();
                if (string.IsNullOrEmpty(n1))
                {
                    goto getint1;
                }


            getint2:
                Console.WriteLine("Enter integer2:");
                n2 = Console.ReadLine();
                if (string.IsNullOrEmpty(n2))
                {
                    goto getint2;
                }

                try
                {
                    integer2 = Convert.ToInt32(n2);
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
                stop = Convert.ToInt32(Console.ReadLine());
            }
            while (stop == 1);
        }
        static private int GetInput(string  )
        {
            n = Console.ReadLine();
            if(int.TryParse(n, out int integer))
            {
                return integer;
            }
            else
            {
                goto getint1;
            }
        }
    }
}