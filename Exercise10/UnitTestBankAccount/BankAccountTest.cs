using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBankAccount
{
    [TestClass]
    public class BankAccountTest
    {
        [TestInitialize]
        public void SetUp()
        {
            BankExample.BankAccount.Deposit(100);
        }

        [TestMethod]
        public void TestWitdrawal()
        {
            // Make possible withdrawal
            BankExample.BankAccount.Withdraw(40);
            Assert.AreEqual(60, BankExample.BankAccount.GetBalance());

            // Use negative amount
            try
            {
                BankExample.BankAccount.Withdraw(-1);
                Assert.Fail("No exception thrown");  // if the above method won't throw exception it means the test failed.
            } catch(Exception e)
            {
                Assert.IsTrue(e is ArgumentOutOfRangeException);
                string msg = e.Message;
                Assert.IsTrue(msg.Contains("Amount for withdrawal is less than 0"));
                Assert.AreEqual(60, BankExample.BankAccount.GetBalance());
            }

            // Withdraw more than the balance
            try
            {
                BankExample.BankAccount.Withdraw(100);
                Assert.Fail("No exception thrown");
            } catch(Exception e)
            {
                Assert.IsTrue(e is ArgumentOutOfRangeException);
                string msg = e.Message;
                Assert.IsTrue(msg.Contains("Insufficient balance!"));
                Assert.AreEqual(60, BankExample.BankAccount.GetBalance());
            }
        }

        [TestMethod]
        public void TestDeposit()
        {
            // Make possible Deposit
            BankExample.BankAccount.Deposit(60);
            Assert.AreEqual(160, BankExample.BankAccount.GetBalance());

            // Use negative amount
            try
            {
                BankExample.BankAccount.Deposit(-1);
                Assert.Fail("No exception thrown");  // if the above method won't throw exception it means the test failed.
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is ArgumentOutOfRangeException);
                string msg = e.Message;
                Assert.IsTrue(msg.Contains("Amount for deposit is less than 0"));
                Assert.AreEqual(160, BankExample.BankAccount.GetBalance());
            }
        }

        [TestCleanup]
        public void OnTearDown()
        {
            BankExample.BankAccount.Withdraw(BankExample.BankAccount.GetBalance());
        }
    }
}
