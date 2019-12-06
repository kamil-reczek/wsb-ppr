using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExample
{
    /// <summary>
    /// Static class that represents simple bank account
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// This private field holds current account balance.
        /// </summary>
        private static int _balance = 0;

        /// <summary>
        /// This method subtracts given amount of money from <see cref="_balance"/>.
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// When amount is less than 0 or if there is insufficient balance
        /// </exception>
        public static void Withdraw(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("Amount for withdrawal is less than 0");
            if (amount > _balance) throw new ArgumentOutOfRangeException("Insufficient balance!");
            _balance -= amount;
        }

        /// <summary>
        /// Get the current <see cref="_balance"/>.
        /// </summary>
        /// <returns></returns>
        public static int GetBalance()
        {
            return _balance;
        }

        /// <summary>
        /// Adds given amount of money to current balance
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// When the amount is less than 0.
        /// </exception>
        public static void Deposit(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("Amount for deposit is less than 0");
            _balance += amount;
        }
    }
}
