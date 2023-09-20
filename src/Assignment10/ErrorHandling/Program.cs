// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ErrorHandling
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method has the exception
        /// </summary>
        private static void Main()
        {
            int[] array = new int[5];
            Console.WriteLine("Enter two numbers to be divided");
            int number1 = InputReaders.GetInteger();
            int number2 = InputReaders.GetInteger();

            try
            {
                Operators.Divide(number1, number2);
            }
            catch (Exception dividebyzeroexception)
            {
                Console.WriteLine(dividebyzeroexception.ToString());
                Console.WriteLine($"The Error:{dividebyzeroexception.Message}");
            }
            finally
            {
                Console.WriteLine("Division Operation Completed\n");
            }

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);
            ArrayOperation.AddElementsToArray(array);

            Console.WriteLine("Enter the index of the number to be displayed:");
            string? index = Console.ReadLine();
            try
            {
                if (!int.TryParse(index, out int integer))
                {
                    throw new InvalidInputException("Enter a valid Number\n");
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }

            int.TryParse(index, out int arrayindex);
            try
            {
                Console.WriteLine(array[arrayindex]);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }

            string? currentstacktrace = Environment.StackTrace;
            Console.WriteLine(currentstacktrace);
        }

        /// <summary>
        /// Method recieves the unhandled exception and displays message.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="ex">Name of exception.</param>
        private static void HandleException(object sender, UnhandledExceptionEventArgs ex)
        {
            Console.WriteLine("The input was not a number\n");
        }
    }
}