using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SimpleCalculator
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
        private static char getCharacter(string msg)
        {
            char result;
            while (true)
            {
                Console.Write(msg);
                if (char.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine("Operator shoud equal: +, -, /, *, %. Try again!");
            }
            return result;
        }

        private static void displayResult(double a, char op, double b, double res)
        {
            Console.WriteLine($"{a} {op} {b} = {res}");
        }

        private static void calculate(double a, char op, double b)
        {
            switch (op)
            {
                case '+':
                    displayResult(a, op, b, a + b);
                    break;
                case '-':
                    displayResult(a, op, b, a - b);
                    break;
                case '*':
                    displayResult(a, op, b, a * b);
                    break;
                case '/':
                    if (b != 0) displayResult(a, op, b, a / b);
                    else Console.WriteLine("Division by 0!!!");
                    break;
                case '%':
                    if (b != 0) displayResult(a, op, b, a % b);
                    else Console.WriteLine("Division by 0!!!");
                    break;
                default:
                    Console.WriteLine($"Wrong operation provided {op}");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- SIMPLE CALCULATOR ---");
            double a = getDouble("Provide first number a= ");
            char op = getCharacter("Provide operator op= ");
            double b = getDouble("Provide second number b= ");
            calculate(a, op, b);
        }
    }
}
