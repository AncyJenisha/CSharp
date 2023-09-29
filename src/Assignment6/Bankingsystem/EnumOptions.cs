// <copyright file="EnumOptions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
        /// <summary>
        /// Account type enum has the types of account.
        /// </summary>
        public enum AccountType
        {
            /// <summary>
            /// Savings account has restrictions in withdrawal.
            /// </summary>
            SavingsAccount = 1,

            /// <summary>
            /// Checking account has no restrictions in withdrawal.
            /// </summary>
            CheckingAccount,

            /// <summary>
            /// Exits the options.
            /// </summary>
            Exit,
        }

        /// <summary>
        /// AccountOptions has the operations to be performed on the account.
        /// </summary>
        public enum AccountOptions
        {
            /// <summary>
            /// Deposit amount.
            /// </summary>
            Deposit = 1,

            /// <summary>
            /// Withdrawal from the balance of the account.
            /// </summary>
            Withdrawal,

            /// <summary>
            /// Displays the balance of the account.
            /// </summary>
            CheckBalance,

            /// <summary>
            /// Exits the options.
            /// </summary>
            Exit,
        }
}