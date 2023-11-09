// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CalculationService
{
    using ValidatorforInputs;

    /// <summary>
    /// Program class has the main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method gets type of service chose by the user.
        /// </summary>
        private static void Main()
        {
            int choiceOfOperation;
            int serviceOption;
            do
            {
                Console.WriteLine("Choose your Service:\n1.Calculator Service\n2.Order Service\n3.Exit");
                serviceOption = InputValidators.ReadIntegerInput();
                switch (serviceOption)
                {
                    case (int)EnumforOptions.ChoiceofService.CalculatorService:
                        do
                        {
                            Console.WriteLine("Enter two numbers");
                            double firstNumber = InputValidators.ReadDoubleInput();
                            double secondNumber = InputValidators.ReadDoubleInput();
                            Console.WriteLine("Choose the mathematical operation to be performed:\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit\n");
                            choiceOfOperation = InputValidators.ReadIntegerInput();

                            switch (choiceOfOperation)
                            {
                                case (int)EnumforOptions.ChoiceofMathOperations.Addition:
                                    Console.WriteLine($"Result:{Calculator.Addition(firstNumber, secondNumber)}");
                                    break;
                                case (int)EnumforOptions.ChoiceofMathOperations.Subtraction:
                                    Console.WriteLine($"Result:{Calculator.Subtraction(firstNumber, secondNumber)}");
                                    break;
                                case (int)EnumforOptions.ChoiceofMathOperations.Multiplication:
                                    Console.WriteLine($"Result:{Calculator.Multiplication(firstNumber, secondNumber)}");
                                    break;
                                case (int)EnumforOptions.ChoiceofMathOperations.Division:
                                    Console.WriteLine($"Result:{Calculator.Division(firstNumber, secondNumber)}");
                                    break;
                                case (int)EnumforOptions.ChoiceofMathOperations.Exit:
                                    break;
                                default:
                                    Console.WriteLine("Enter a valid option");
                                    break;
                            }
                        }
                        while (choiceOfOperation != 5);
                        break;

                    case (int)EnumforOptions.ChoiceofService.OrderService:
                        OrderService.Orderservice();
                        break;

                    case (int)EnumforOptions.ChoiceofService.Exit:
                        return;

                    default:
                        Console.WriteLine("Choose the appropriate option\n");
                        break;
                }
            }
            while (serviceOption != 3);
        }
    }
}