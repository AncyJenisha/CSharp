// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment6_Employee
{
    /// <summary>
    /// Options enum has thetypes of employees.
    /// </summary>
    public enum Options
    {
        /// <summary>
        /// Manager creates an object manager.
        /// </summary>
        Manager = 1,

        /// <summary>
        /// Developer creates an object developer.
        /// </summary>
        Developer,

        /// <summary>
        /// Exit stops the program.
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Progran class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets the values from user.
        /// </summary>
        private static void Main()
        {
            do
            {
                Console.WriteLine("Choose the Employee");
                Console.WriteLine("1.Manager\n2.Developer\n3.Exit");
                int choice = InputReader.GetIntegerInput();
                switch (choice)
                {
                    case (int)Options.Manager:
                        Console.WriteLine("Enter the name of the Manager");
                        string name = InputReader.GetStringInput();
                        Console.WriteLine("Enter the salary of manager");
                        float salary = InputReader.GetFloatInput();
                        var manager = new Manager(name, salary);
                        manager.PrintDetails();
                        manager.Bonus();
                        break;

                    case (int)Options.Developer:
                        Console.WriteLine("Enter the name of Developer");
                        string developername = InputReader.GetStringInput();
                        Console.WriteLine("Enter the salary of developer");
                        float developersalary = InputReader.GetFloatInput();
                        var developer = new Developer(developername, developersalary);
                        developer.PrintDetails();
                        developer.Bonus();
                        break;

                    case (int)Options.Exit:
                        return;
                }
            }
            while (true);
        }
    }
}