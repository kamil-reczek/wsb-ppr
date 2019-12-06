using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankExample;

namespace UseBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Add some money to Bank Account
                BankAccount.Deposit(100);
                Console.WriteLine("Current balance is " + BankAccount.GetBalance());

                // Withdraw money 
                BankAccount.Withdraw(50);
                Console.WriteLine("Current balance is " + BankAccount.GetBalance());

                // Withdraw more money than balance
                BankAccount.Withdraw(100);
                Console.WriteLine("Current balance is " + BankAccount.GetBalance());


            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Current balance is " + BankAccount.GetBalance());
            }
        }
    }
}
