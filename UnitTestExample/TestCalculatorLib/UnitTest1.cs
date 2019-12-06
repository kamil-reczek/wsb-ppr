using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace TestCalculatorLib
{
    [TestClass]
    public class UnitTestSimpleCalc
    {
        [TestMethod]
        public void AdditionTest()
        {
            // Test if we get the expected result
            int a = 2;
            int b = 2;
            double result = SimpleCalculator.SimpleMath.Add(a, b);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            // Test if the result is true
            int a = 2;
            int b = 3;
            double result = SimpleMath.Multiply(a, b);
            Assert.IsTrue(result == 6);
        }


        [TestMethod]
        public void DivisionTest()
        {
            // Test throwing exception
            int a = 1;
            int b = 0;
            double result;

            // if testing exception, use try-catch
            try
            {
                result = SimpleCalculator.SimpleMath.Divide(a, b);  // this will thorw an ArgumentException
                Assert.Fail();  // if we are here, it means the exception wasn't thrown, so the test failed
            } catch(Exception e)
            {
                // check if this is the right type of excpetion
                Assert.IsTrue(e is ArgumentException);
                // check if the message contains custom string
                string msg = e.Message;
                Assert.IsTrue(msg.Contains("Cannot divide by 0!"));
            }

        }
    }
}
