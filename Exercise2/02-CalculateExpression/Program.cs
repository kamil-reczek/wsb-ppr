using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CalculateExpression
{
    class Program
    {
        private static double getDouble(string msg)
        {
            double result = 0;
            while (true)
            {
                Console.Write(msg);
                if (double.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine("Not a double. Try again!");
            }
            return result;
        }
        static void Main(string[] args)
        {
            double a = getDouble("a= ");
            double b = getDouble("b= ");

            if(a == b)
            {
                Console.WriteLine("Division by 0!!!");
            } else
            {
                Console.WriteLine("ab/(a+b) = " + a*b/(a+b));
            }
        }
    }
}
