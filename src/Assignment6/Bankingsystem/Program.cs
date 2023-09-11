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
            bool x = true;
            bool y = true;
            do
            {
                string accountnumber;
                Console.WriteLine("\nChoose the account type\n1.Savings Account\n2.Checking Account\n3.Exit");
                int accounttype = Inputvalidators.IntegerValidator();
                switch (accounttype)
                {
                    case (int)EnumOptions.AccountType.Savingsaccount:
                        Console.WriteLine("Enter the account number:");
                        do
                        {
                            accountnumber = Inputvalidators.StringValidator();
                        }
                        while (Inputvalidators.AccountNumberValidate(accountnumber) == false);
                        BankAccount savingsaccount = new SavingsAccount(accountnumber);
                        do
                        {
                            Console.WriteLine("\nChoose The account option:\n1.Deposit\n2.Withdrawal\n3.Check Balance\n4.Exit");
                            int accountoptions = Inputvalidators.IntegerValidator();
                            switch (accountoptions)
                            {
                                case (int)EnumOptions.AccountOptions.Deposit:
                                    Console.WriteLine("Enter the amount to be deposited:");
                                    float depositamount = Inputvalidators.FloatValidator();
                                    savingsaccount.DepositAmount(depositamount);
                                    break;

                                case (int)EnumOptions.AccountOptions.Withdrawal:
                                    Console.WriteLine("Enter the amount to be Withdrawn:");
                                    float withdrawamount = Inputvalidators.FloatValidator();
                                    savingsaccount.WithdrawAmount(withdrawamount);
                                    break;

                                case (int)EnumOptions.AccountOptions.CheckBalance:
                                    savingsaccount.CheckBalance();
                                    break;

                                case (int)EnumOptions.AccountOptions.Exit:
                                    x = false;
                                    break;

                                default:
                                    Console.WriteLine("Choose appropriate option.");
                                    break;
                            }
                        }
                        while (x == true);
                        break;

                    case (int)EnumOptions.AccountType.Checkingaccount:
                        Console.WriteLine("Enter the account number:");
                        do
                        {
                            accountnumber = Inputvalidators.StringValidator();
                        }
                        while (Inputvalidators.AccountNumberValidate(accountnumber) == false);
                        BankAccount checkingaccount = new CheckingAccount(accountnumber);
                        do
                        {
                            Console.WriteLine("\nChoose the account option:\n1.Deposit\n2.Withdrawal\n3.CheckBalance\n4.Exit");
                            int accountoptions1 = Inputvalidators.IntegerValidator();
                            switch (accountoptions1)
                            {
                                case (int)EnumOptions.AccountOptions.Deposit:
                                    Console.WriteLine("Enter the amount to be deposited:");
                                    float depositamount = Inputvalidators.FloatValidator();
                                    checkingaccount.DepositAmount(depositamount);
                                    break;

                                case (int)EnumOptions.AccountOptions.Withdrawal:
                                    Console.WriteLine("Enter the amount to be Withdrawn:");
                                    float withdrawamount = Inputvalidators.FloatValidator();
                                    checkingaccount.WithdrawAmount(withdrawamount);
                                    break;

                                case (int)EnumOptions.AccountOptions.CheckBalance:
                                    checkingaccount.CheckBalance();
                                    break;

                                case (int)EnumOptions.AccountOptions.Exit:
                                    y = false;
                                    break;

                                default:
                                    Console.WriteLine("Choose appropriate option.");
                                    break;
                            }
                        }
                        while (y == true);
                        break;

                    case (int)EnumOptions.AccountType.Exit:
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