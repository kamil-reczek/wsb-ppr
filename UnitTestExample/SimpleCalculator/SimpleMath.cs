using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SimpleMath
    {
        /// <summary>
        /// Adds two double numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns><see cref="Double"/></returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Multiplies two double numbers
        /// </summary>
        /// <param name="a">First factor</param>
        /// <param name="b">Second factor</param>
        /// <returns><see cref="Double"/></returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Subtracts second number from the first
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Number to be subtracted</param>
        /// <returns><see cref="Double"/></returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }


        /// <summary>
        /// Divides two number
        /// </summary>
        /// <param name="a">Number to be divided</param>
        /// <param name="b">Divisor</param>
        /// <returns><see cref="Double"/></returns>
        /// <exception cref="ArgumentException">Throws excetions when <paramref name="b"/> is equal 0</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException("Cannot divide by 0!");
            return a / b;
        }
    }
}
