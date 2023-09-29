// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
    /// <summary>
    /// Program class has the main method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method creates objects to access the classes.
        /// </summary>
        private static void Main()
        {
            bool continueSavingsAccountOptions = true;
            bool continueCheckingAccountOptions = true;
            do
            {
                string accountNumber;
                Console.WriteLine("\nChoose the account type\n1.Savings Account\n2.Checking Account\n3.Exit");
                int accountType = InputValidators.IntegerValidator();
                switch (accountType)
                {
                    case (int)AccountType.SavingsAccount:
                        Console.WriteLine("Enter the account number:");
                        do
                        {
                            accountNumber = InputValidators.StringValidator();
                        }
                        while (!InputValidators.AccountNumberValidate(accountNumber));
                        BankAccount savingsAccount = new SavingsAccount(accountNumber);
                        do
                        {
                            Console.WriteLine("\nChoose The account option:\n1.Deposit\n2.Withdrawal\n3.Check Balance\n4.Exit");
                            int savingsAccountOptions = InputValidators.IntegerValidator();
                            switch (savingsAccountOptions)
                            {
                                case (int)AccountOptions.Deposit:
                                    Console.WriteLine("Enter the amount to be deposited:");
                                    float depositAmount = InputValidators.FloatValidator();
                                    savingsAccount.DepositAmount(depositAmount);
                                    break;

                                case (int)AccountOptions.Withdrawal:
                                    Console.WriteLine("Enter the amount to be Withdrawn:");
                                    float withdrawAmount = InputValidators.FloatValidator();
                                    savingsAccount.WithdrawAmount(withdrawAmount);
                                    break;

                                case (int)AccountOptions.CheckBalance:
                                    savingsAccount.CheckBalance();
                                    break;

                                case (int)AccountOptions.Exit:
                                    continueSavingsAccountOptions = false;
                                    break;

                                default:
                                    Console.WriteLine("Choose appropriate option.");
                                    break;
                            }
                        }
                        while (continueSavingsAccountOptions == true);
                        break;

                    case (int)AccountType.CheckingAccount:
                        Console.WriteLine("Enter the account number:");
                        do
                        {
                            accountNumber = InputValidators.StringValidator();
                        }
                        while (InputValidators.AccountNumberValidate(accountNumber) == false);
                        BankAccount checkingAccount = new CheckingAccount(accountNumber);
                        do
                        {
                            Console.WriteLine("\nChoose the account option:\n1.Deposit\n2.Withdrawal\n3.CheckBalance\n4.Exit");
                            int checkingAccountOptions = InputValidators.IntegerValidator();
                            switch (checkingAccountOptions)
                            {
                                case (int)AccountOptions.Deposit:
                                    Console.WriteLine("Enter the amount to be deposited:");
                                    float depositAmount = InputValidators.FloatValidator();
                                    checkingAccount.DepositAmount(depositAmount);
                                    break;

                                case (int)AccountOptions.Withdrawal:
                                    Console.WriteLine("Enter the amount to be Withdrawn:");
                                    float withdrawAmount = InputValidators.FloatValidator();
                                    checkingAccount.WithdrawAmount(withdrawAmount);
                                    break;

                                case (int)AccountOptions.CheckBalance:
                                    checkingAccount.CheckBalance();
                                    break;

                                case (int)AccountOptions.Exit:
                                    continueCheckingAccountOptions = false;
                                    break;

                                default:
                                    Console.WriteLine("Choose appropriate option.");
                                    break;
                            }
                        }
                        while (continueCheckingAccountOptions == true);
                        break;

                    case (int)AccountType.Exit:
                        return;

                    default:
                        Console.WriteLine("Choose the correct option");
                        break;
                }
            }
            while (true);
        }
    }
}