// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EmployeeHierarchy
{
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
                        manager.CalculateBonus();
                        break;

                    case (int)Options.Developer:
                        Console.WriteLine("Enter the name of Developer");
                        string developerName = InputReader.GetStringInput();
                        Console.WriteLine("Enter the salary of developer");
                        float developerSalary = InputReader.GetFloatInput();
                        var developer = new Developer(developerName, developerSalary);
                        developer.PrintDetails();
                        developer.CalculateBonus();
                        break;

                    case (int)Options.Exit:
                        return;
                }
            }
            while (true);
        }
    }
}